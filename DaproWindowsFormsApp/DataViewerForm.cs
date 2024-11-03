
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\DataViewerForm.cs
using DaproWindowsFormsApp.Services;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    public partial class DataViewerForm : Form
    {
        private readonly DatabaseService _databaseService;
        private readonly string _connectionString;
        private readonly ComboBox comboBoxInsurance;
        private readonly ComboBox comboBoxCountry;
        private readonly ComboBox comboBoxGender;
        private int currentPatientId;
        public DataViewerForm()
        {
            InitializeComponent();
            string dbPath = Path.Combine(Application.StartupPath, "DaproSQLiteDB.db");
            _connectionString = $"Data Source={dbPath}";
            _databaseService = new DatabaseService(_connectionString);

            

            comboBoxInsurance = new ComboBox();
            comboBoxInsurance.Items.AddRange(new string[] { "24", "25", "27" });
            comboBoxInsurance.SelectedIndexChanged += ComboBoxInsurance_SelectedIndexChanged;
            Controls.Add(comboBoxInsurance);
            // controls positioning
            comboBoxInsurance.Location = new System.Drawing.Point(912, 129);

            ComboBoxInsurance.SelectedIndex = 0;
        }


        private void ButtonToPageShowData_Click(object sender, EventArgs e)
        {
            this.Hide();
            var showDataFromDatabaseForm = new ShowDataFromDatabaseForm();
            showDataFromDatabaseForm.Closed += (s, args) => this.Close();
            showDataFromDatabaseForm.Show();
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Nastav popis pre dialógové okno (voliteľné)
                openFileDialog.Title = "Vyberte súbor s dátami";

                // Upravený filter pre CSV, TXT a TSV súbory
                openFileDialog.Filter = "001 súbory (*.001)|*.001|002 súbory (*.002)|*.002|CSV súbory (*.csv)|*.csv|Textové súbory (*.txt)|*.txt|TSV súbory (*.tsv)|*.tsv|Všetky súbory (*.*)|*.*";

                // Zobraz dialógové okno a skontroluj, či používateľ vybral súbor
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Získaj cestu k vybranému súboru
                    string selectedFilePath = openFileDialog.FileName;

                    // Zobraz cestu k vybranému súboru v TextBox-e
                    textBoxDataFile.Text = selectedFilePath;

                    // Načítaj a zobraz údaje v DataGridView
                    LoadCsvToDataGridView(selectedFilePath);
                }
            }
        }

        private void TextBoxDataFile_TextChanged(object sender, EventArgs e)
        {
            // Táto metóda je správne prázdna pre tento účel
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            // Vymazanie existujúcich údajov v DataGridView
            chosenDataFileGridView.Rows.Clear();
            chosenDataFileGridView.Columns.Clear();

            // Pridanie stĺpcov do DataGridView
            chosenDataFileGridView.Columns.Add("BirthID", "Birth ID");
            chosenDataFileGridView.Columns.Add("LastName", "Last Name");
            chosenDataFileGridView.Columns.Add("FirstName", "First Name");
            chosenDataFileGridView.Columns.Add("Insurance", "Insurance");
            chosenDataFileGridView.Columns.Add("Country", "Country");
            chosenDataFileGridView.Columns.Add("Gender", "Gender");

            try
            {
                // Načítanie CSV súboru
                using (var reader = new StreamReader(filePath))
                {
                    // Čítanie riadkov údajov a pridanie ich do DataGridView
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line != null)
                        {
                            var values = line.Split('|');

                            // Kontrola či máme dostatok hodnôt pre základné údaje
                            if (values.Length >= 4)
                            {
                                var birthID = values[2].Trim();
                                var fullName = values[3].Trim();
                                var nameParts = fullName.Split(' ');

                                // Inicializácia premenných pre krajinu a pohlavie
                                string insurance = "";
                                string country = "";
                                string gender = "";

                                // Kontrola či máme dostatok hodnôt pre krajinu (index 19)
                                if (values.Length > 19)
                                {
                                    country = values[19].Trim();
                                }

                                // Kontrola či máme dostatok hodnôt pre pohlavie (index 21)
                                if (values.Length > 21)
                                {
                                    gender = values[21].Trim();
                                }

                                // Kontrola, či máme aspoň meno a priezvisko
                                if (nameParts.Length >= 2)
                                {
                                    var lastName = nameParts[0].Trim();
                                    var firstName = nameParts[1].Trim();

                                    chosenDataFileGridView.Rows.Add(
                                        birthID,
                                        lastName,
                                        firstName,
                                        insurance,
                                        country,
                                        gender
                                    );
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pri načítaní CSV súboru: " + ex.Message);
            }
        }

       

        private List<Patient> GetPatientsFromDataGridView()
        {
            var patients = new List<Patient>();

            foreach (DataGridViewRow row in chosenDataFileGridView.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    var patient = new Patient
                    {
                        BirthID = GetCellValue(row, "BirthID"),
                        LastName = GetCellValue(row, "LastName"),
                        FirstName = GetCellValue(row, "FirstName"),
                        Insurance = GetCellValue(row, "Insurance"),
                        Country = GetCellValue(row, "Country"),
                        Gender = GetCellValue(row, "Gender")
                    };

                    // Základná validácia
                    if (string.IsNullOrWhiteSpace(patient.BirthID) ||
                        string.IsNullOrWhiteSpace(patient.LastName) ||
                        string.IsNullOrWhiteSpace(patient.FirstName))
                    {
                        continue; // Preskočíme neplatné záznamy
                    }

                    patients.Add(patient);
                }
                catch (Exception ex)
                {
                    // Log error alebo zobrazenie warning správy
                    Debug.WriteLine($"Chyba pri spracovaní riadku: {ex.Message}");
                    MessageBox.Show($"Chyba pri spracovaní riadku: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return patients;
        }

        private string GetCellValue(DataGridViewRow row, string columnName)
        {
            return row.Cells[columnName]?.Value?.ToString()?.Trim() ?? string.Empty;
        }

        

        void CreatePatientsTableIfNotExists(SqliteConnection connection)
        {
            var createTableQuery = @"
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


        private void ComboBoxInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxInsurance.SelectedItem != null && currentPatientId > 0)
                {
                    string selectedInsurance = ComboBoxInsurance.SelectedItem.ToString();
                    UpdatePatientField("Insurance", selectedInsurance);
                    MessageBox.Show($"Aktuálna vybraná hodnota: {comboBoxInsurance.SelectedItem}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri aktualizácii poisťovne: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxCountry.SelectedItem != null && currentPatientId > 0)
                {
                    string selectedCountry = ComboBoxCountry.SelectedItem.ToString();
                    UpdatePatientField("Country", selectedCountry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri aktualizácii krajiny: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxGender.SelectedItem != null && currentPatientId > 0)
                {
                    string selectedGender = ComboBoxGender.SelectedItem.ToString();
                    UpdatePatientField("Gender", selectedGender);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri aktualizácii pohlavia: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePatientField(string fieldName, string value)
        {
            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.Transaction = transaction;
                            command.CommandText = $"UPDATE Patients SET {fieldName} = @Value WHERE Id = @Id";
                            command.Parameters.AddWithValue("@Value", value);
                            command.Parameters.AddWithValue("@Id", currentPatientId);
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void SetCurrentPatient(int patientId)
        {
            currentPatientId = patientId;
            LoadPatientData(); // Načíta dáta pacienta do ComboBoxov
        }

        private void LoadPatientData()
        {
            if (currentPatientId <= 0) return;

            using (var connection = new SqliteConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Insurance, Country, Gender FROM Patients WHERE Id = @Id";
                    command.Parameters.AddWithValue("@Id", currentPatientId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ComboBoxInsurance.Text = reader["Insurance"].ToString();
                            ComboBoxCountry.Text = reader["Country"].ToString();
                            ComboBoxGender.Text = reader["Gender"].ToString();
                        }
                    }
                }
            }
        }


        private void ButtonSavePatients_Click(object sender, EventArgs e)
        {
            // Načítaj hodnotu Insurance z ComboBox
            string insuranceValue = comboBoxInsurance?.SelectedItem?.ToString();
            string countryValue = comboBoxCountry?.SelectedItem?.ToString();
            string genderValue = comboBoxGender?.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(insuranceValue))
            {
                MessageBox.Show("Prosím, vyberte hodnotu pre poistenie pred uložením.", "Upozornenie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var patients = GetPatientsFromDataGridView();

                // Nastav hodnotu Insurance pre každý záznam
                foreach (var patient in patients)
                {
                    patient.Insurance = insuranceValue;
                    patient.Country = countryValue;
                    patient.Gender = genderValue;
                }

                // Ulož pacientov do databázy
                _databaseService.SavePatients(patients);

                MessageBox.Show($"{insuranceValue}, {countryValue}, {genderValue} " +
                    $" - Údaje boli úspešne uložené do databázy.", "Úspech",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba pri ukladaní údajov: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

//private void ButtonSavePatientsWithInsurance24_Click(object sender, EventArgs e)
//{
//    try
//    {
//        var patients = GetPatientsFromDataGridView();
//        //_databaseService.SavePatients(patients);
//        SaveDataWithInsurance.SaveDataWithInsurance24(patients);
//        MessageBox.Show("Dôvera-24 Údaje boli úspešne uložené do databázy.", "Úspech",
//            MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"Nastala chyba pri ukladaní údajov: {ex.Message}", "Chyba",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}

//private void ButtonSavePatientsWithInsurance25_Click(object sender, EventArgs e)
//{
//    try
//    {
//        var patients = GetPatientsFromDataGridView();
//        SaveDataWithInsurance25(patients);
//        MessageBox.Show("VŠZP-25 Údaje boli úspešne uložené do databázy.", "Úspech",
//            MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"Nastala chyba pri ukladaní údajov: {ex.Message}", "Chyba",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}

//private void ButtonSavePatientsWithInsurance27_Click(object sender, EventArgs e)
//{
//    try
//    {
//        var patients = GetPatientsFromDataGridView();
//        SaveDataWithInsurance27(patients);
//        MessageBox.Show("Union-27 Údaje boli úspešne uložené do databázy.", "Úspech",
//            MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"Nastala chyba pri ukladaní údajov: {ex.Message}", "Chyba",
//            MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}
