
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\DatabaseService.cs
using log4net;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DaproWindowsFormsApp.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;
        private static readonly ILog _logger = LogManager.GetLogger(typeof(DatabaseService));

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void SavePatients(List<Patient> patients)
        {
            if (!patients.Any())
            {
                _logger.Warn("Pokus o uloženie prázdneho zoznamu pacientov");
                throw new ArgumentException("Nie sú k dispozícii žiadne údaje na uloženie.");
            }

            try
            {
                using (var connection = new SqliteConnection(_connectionString))
                {
                    connection.Open();
                    CreatePatientsTableIfNotExists(connection);

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            InsertPatients(connection, patients, transaction);
                            transaction.Commit();
                            _logger.Info($"Úspešne uložených {patients.Count} pacientov");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            _logger.Error("Chyba pri ukladaní pacientov", ex);
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Chyba pri pripojení k databáze", ex);
                throw;
            }
        }

        private void CreatePatientsTableIfNotExists(SqliteConnection connection)
        {
            const string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Patients (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    BirthID TEXT CHECK(length(BirthID) IN (9,10) OR BirthID IS NULL),
                    LastName TEXT,
                    FirstName TEXT,
                    Insurance TEXT,
                    Country TEXT,
                    Gender TEXT
                );";

            using (var command = new SqliteCommand(createTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void InsertPatients(SqliteConnection connection, List<Patient> patients, SqliteTransaction transaction)
        {
            const string insertQuery = @"
                INSERT INTO Patients (BirthID, LastName, FirstName, Insurance, Country, Gender)
                VALUES (@BirthID, @LastName, @FirstName, @Insurance, @Country, @Gender);";

            using (var command = new SqliteCommand(insertQuery, connection, transaction))
            {
                ConfigureParameters(command);

                foreach (var patient in patients)
                {
                    try
                    {
                        ValidatePatient(patient);
                        SetParameters(command, patient);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        _logger.Error($"Chyba pri spracovaní pacienta {patient.BirthID}", ex);
                        throw;
                    }
                }
            }
        }

        private void ConfigureParameters(SqliteCommand command)
        {
            command.Parameters.Add("@BirthID", SqliteType.Text);
            command.Parameters.Add("@LastName", SqliteType.Text);
            command.Parameters.Add("@FirstName", SqliteType.Text);
            command.Parameters.Add("@Insurance", SqliteType.Text);
            command.Parameters.Add("@Country", SqliteType.Text);
            command.Parameters.Add("@Gender", SqliteType.Text);
        }

        private void SetParameters(SqliteCommand command, Patient patient)
        {
            command.Parameters["@BirthID"].Value = patient.BirthID ?? (object)DBNull.Value;
            command.Parameters["@LastName"].Value = patient.LastName ?? (object)DBNull.Value;
            command.Parameters["@FirstName"].Value = patient.FirstName ?? (object)DBNull.Value;
            command.Parameters["@Insurance"].Value = patient.Insurance ?? (object)DBNull.Value;
            command.Parameters["@Country"].Value = patient.Country ?? (object)DBNull.Value;
            command.Parameters["@Gender"].Value = patient.Gender ?? (object)DBNull.Value;
        }

        private void ValidatePatient(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.BirthID))
                throw new ArgumentException("Rodné číslo je povinné");
            if (string.IsNullOrWhiteSpace(patient.LastName))
                throw new ArgumentException("Priezvisko je povinné");
            if (string.IsNullOrWhiteSpace(patient.FirstName))
                throw new ArgumentException("Meno je povinné");
        }
    }
}