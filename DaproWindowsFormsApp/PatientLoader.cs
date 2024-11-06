
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\PatientLoader.cs
using DaproWindowsFormsApp;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DaproWindowsFormsApp
{
    public class PatientLoader
    {
        public void LoadPatientsFromFile(string filePath)
        {
            try
            {
                // Kontrola existencie súboru
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Súbor {filePath} nebol nájdený.");
                }

                List<Patient> patients = new List<Patient>();
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    var values = line.Split('|');
                    if (values.Length >= 2)
                    {
                        Patient patient = new Patient
                        {
                            Id = int.Parse(values[0]),
                            BirthID = values[2],
                            LastName = values[3],
                            FirstName = values[4]
                        };
                        patients.Add(patient);
                    }
                }

                SavePatientsToDatabase(patients);
            }
            catch (Exception ex)
            {
                // Logovanie alebo zobrazenie chyby
                Console.WriteLine($"Chyba pri načítavaní pacientov: {ex.Message}");
            }
        }

        private void SavePatientsToDatabase(List<Patient> patients)
        {
            // Odstránenie duplicít pomocou LINQ
            var uniquePatients = patients
                .Distinct() // Používa implementovanú IEquatable
                .ToList();

            using (var connection = new SqliteConnection("Data Source=DaproSQLiteDB.db"))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var patient in uniquePatients)
                        {
                            using (var command = connection.CreateCommand())
                            {
                                command.Transaction = transaction;
                                command.CommandText = @"
                            INSERT OR IGNORE INTO Patients (BirthID, LastName, FirstName)
                            VALUES ($birthID, $lastName, $firstName)";

                                command.Parameters.AddWithValue("$birthID", patient.BirthID);
                                command.Parameters.AddWithValue("$lastName", patient.LastName);
                                command.Parameters.AddWithValue("$firstName", patient.FirstName);

                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Chyba pri ukladaní pacientov do databázy: {ex.Message}");
                    }
                }
            }
        }
    }
}
