
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\SaveDataWithInsurance.cs
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace DaproWindowsFormsApp
{
    internal class SaveDataWithInsurance
    {
        private void CreatePatientsTableIfNotExists(SqliteConnection connection)
        {
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                    CREATE TABLE IF NOT EXISTS Patients (
                        Id INTEGER PRIMARY KEY,
                        BirthID TEXT,
                        LastName TEXT,
                        FirstName TEXT,
                        Insurance TEXT,
                        Country TEXT,
                        Gender TEXT
                    )
                ";
            command.ExecuteNonQuery();
        }

        private void InsertPatientsIntoDatabase(SqliteConnection connection, List<Patient> patients, SqliteTransaction transaction)
        {
            foreach (var patient in patients)
            {
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                        INSERT INTO Patients (Id, BirthID, LastName, FirstName, Insurance, Country, Gender)
                        VALUES ($id, $birthID, $lastName, $firstName, $insurance, $country, $gender)
                    ";
                command.Parameters.AddWithValue("$id", patient.Id);
                command.Parameters.AddWithValue("$birthID", patient.BirthID);
                command.Parameters.AddWithValue("$lastName", patient.LastName);
                command.Parameters.AddWithValue("$firstName", patient.FirstName);
                command.Parameters.AddWithValue("$insurance", patient.Insurance);
                command.Parameters.AddWithValue("$country", patient.Country);
                command.Parameters.AddWithValue("$gender", patient.Gender);
                command.ExecuteNonQuery();
            }
        }
    }
}

//private void SaveDataWithInsurance24(SqliteConnection connection, List<Patient> patientsList, SqliteTransaction transaction)
//{
//    //if (!patients.Any())
//    //{
//    //    throw new ArgumentException("Nie sú k dispozícii žiadne údaje na uloženie.");
//    //}



//    if (patientsList is null)
//    {
//        //throw new ArgumentNullException(nameof(patientsList));
//        try
//        {
//            throw new ArgumentNullException(nameof(patientsList));
//        }
//        catch (ArgumentNullException ex)
//        {
//            Debug.WriteLine(ex.Message);
//            MessageBox.Show(ex.Message, "Chyba pri ukladaní pacientov do databázy", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//    }

//    var insertQuery = @"
//        INSERT INTO Patients (BirthID, LastName, FirstName, Insurance, Country, Gender)
//        VALUES (@BirthID, @LastName, @FirstName, @Insurance, @Country, @Gender);";

//    using (var command = new SqliteCommand(insertQuery, connection, transaction))
//    {
//        // Vytvorenie parametrov
//        command.Parameters.Add("@BirthID", SqliteType.Text);
//        command.Parameters.Add("@LastName", SqliteType.Text);
//        command.Parameters.Add("@FirstName", SqliteType.Text);
//        command.Parameters.Add("@Insurance", SqliteType.Text);
//        command.Parameters.Add("@Country", SqliteType.Text);
//        command.Parameters.Add("@Gender", SqliteType.Text);

//        foreach (var patient in patientsList)
//        {
//            command.Parameters["@BirthID"].Value = patient.BirthID ?? (object)DBNull.Value;
//            command.Parameters["@LastName"].Value = patient.LastName ?? (object)DBNull.Value;
//            command.Parameters["@FirstName"].Value = patient.FirstName ?? (object)DBNull.Value;
//            command.Parameters["@Insurance"].Value = "24"; // Fixná hodnota pre tuto metódu
//            command.Parameters["@Country"].Value = patient.Country ?? (object)DBNull.Value;
//            command.Parameters["@Gender"].Value = patient.Gender ?? (object)DBNull.Value;

//            command.ExecuteNonQuery();
//        }
//    }
//}

//private void SaveDataWithInsurance25(List<Patient> patients)
//{
//    if (!patients.Any())
//    {
//        throw new ArgumentException("Nie sú k dispozícii žiadne údaje na uloženie.");
//    }

//    string dbPath = Path.Combine(Application.StartupPath, "DaproSQLiteDB.db");
//    string connectionString = $"Data Source={dbPath}";

//    using (var connection = new SqliteConnection(connectionString))
//    {
//        connection.Open();

//        // Vytvorenie tabuľky ak neexistuje
//        CreatePatientsTableIfNotExists(connection);

//        using (var transaction = connection.BeginTransaction())
//        {
//            try
//            {
//                InsertPatientsIntoDatabase(connection, patients, transaction);
//                transaction.Commit();
//            }
//            catch (Exception)
//            {
//                transaction.Rollback();
//                throw;
//            }
//        }
//    }
//}

//private void SaveDataWithInsurance27(List<Patient> patients)
//{
//    if (!patients.Any())
//    {
//        throw new ArgumentException("Nie sú k dispozícii žiadne údaje na uloženie.");
//    }

//    string dbPath = Path.Combine(Application.StartupPath, "DaproSQLiteDB.db");
//    string connectionString = $"Data Source={dbPath}";

//    using (var connection = new SqliteConnection(connectionString))
//    {
//        connection.Open();

//        // Vytvorenie tabuľky ak neexistuje
//        CreatePatientsTableIfNotExists(connection);

//        using (var transaction = connection.BeginTransaction())
//        {
//            try
//            {
//                InsertPatientsIntoDatabase(connection, patients, transaction);
//                transaction.Commit();
//            }
//            catch (Exception)
//            {
//                transaction.Rollback();
//                throw;
//            }
//        }
//    }
//}
