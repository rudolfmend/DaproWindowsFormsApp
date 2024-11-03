
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\AddPatientForm.cs
using System;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace DaproWindowsFormsApp
{
    public partial class AddPatientForm : Form
    {
        public AddPatientForm()
        {
            InitializeComponent();
        }

        private void ButtonSavePatientToDatabase_Click(object sender, EventArgs e)
        {
            // Kontrola, či povinné polia nie sú prázdne
            if (string.IsNullOrWhiteSpace(TextBoxBirthIDPatient.Text) ||
                string.IsNullOrWhiteSpace(TextBoxLastNamePatient.Text))
            {
                MessageBox.Show("Rodné číslo a priezvisko sú povinné. Vyplňte prosím tieto údaje.");
                return;
            }

            var patient = new Patient
            {
                BirthID = TextBoxBirthIDPatient.Text,
                LastName = TextBoxLastNamePatient.Text,
                FirstName = TextBoxFirstNamePatient.Text,
                Insurance = ComboBoxInsurance.Text,
                Country = ComboBoxCountry.Text,
                Gender = ComboBoxGender.Text
            };

            SavePatientToDatabase(patient);
        }

        private void SavePatientToDatabase(Patient patient)
        {
            string connectionString = "Data Source=DaproSQLiteDB.db";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Vytvorenie tabuľky, ak neexistuje
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Patients (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        BirthID TEXT NOT NULL UNIQUE,
                        LastName TEXT NOT NULL,
                        FirstName TEXT,
                        Insurance TEXT,
                        Country TEXT,
                        Gender TEXT
                    );";
                using (var command = new SqliteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Vloženie údajov pacienta do tabuľky
                string insertPatientQuery = @"
                    INSERT INTO Patients (BirthID, LastName, FirstName, Insurance, Country, Gender)
                    VALUES (@BirthID, @LastName, @FirstName, @Insurance, @Country, @Gender);";

                using (var command = new SqliteCommand(insertPatientQuery, connection))
                {
                    command.Parameters.AddWithValue("@BirthID", patient.BirthID);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);

                    // Nastavenie nullable hodnôt (ak je hodnota null, uloží sa ako DBNull.Value)
                    command.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(patient.FirstName) ? (object)DBNull.Value : patient.FirstName);
                    command.Parameters.AddWithValue("@Insurance", string.IsNullOrWhiteSpace(patient.Insurance) ? (object)DBNull.Value : patient.Insurance);
                    command.Parameters.AddWithValue("@Country", string.IsNullOrWhiteSpace(patient.Country) ? (object)DBNull.Value : patient.Country);
                    command.Parameters.AddWithValue("@Gender", string.IsNullOrWhiteSpace(patient.Gender) ? (object)DBNull.Value : patient.Gender);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Údaje pacienta {patient.LastName} uložené.");
                        ClearInputFields();
                    }
                    catch (SqliteException ex) when (ex.SqliteErrorCode == SQLitePCL.raw.SQLITE_CONSTRAINT)
                    {
                        MessageBox.Show("Pacient s týmto rodným číslom už existuje.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Chyba pri ukladaní pacienta: {ex.Message}");
                    }

                    void ClearInputFields()
                    {
                        foreach (Control control in this.Controls)
                        {
                            if (control is TextBox textBox)
                            {
                                textBox.Clear();
                            }
                            else if (control is ComboBox comboBox)
                            {
                                comboBox.SelectedIndex = -1; // Vyberie žiadnu hodnotu v ComboBoxe
                                comboBox.Text = string.Empty; // Vymaže text v ComboBoxe
                            }
                        }
                    }
                }
            }
        }
    }
}
