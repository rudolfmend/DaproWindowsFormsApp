
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\LoadTextFiles.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    internal class LoadTextFiles
    {
        private readonly DataGridView chosenDataFileGridView;

        public LoadTextFiles(DataGridView dataGridView)
        {
            chosenDataFileGridView = dataGridView;
        }

        private void LoadCsvToDataGridView(string filePath)
        {
            chosenDataFileGridView.Rows.Clear();
            chosenDataFileGridView.Columns.Clear();

            chosenDataFileGridView.Columns.Add("BirthID", "Birth ID");
            chosenDataFileGridView.Columns.Add("LastName", "Last Name");
            chosenDataFileGridView.Columns.Add("FirstName", "First Name");
            chosenDataFileGridView.Columns.Add("Insurance", "Insurance");
            chosenDataFileGridView.Columns.Add("Country", "Country");
            chosenDataFileGridView.Columns.Add("Gender", "Gender");

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line == null) continue;

                        var values = line.Split('|');
                        if (values.Length < 4) continue; // preskočí riadky s nedostatkom údajov

                        var birthID = values[2].Trim();
                        var fullName = values[3].Trim();
                        var nameParts = fullName.Split(' ');

                        if (nameParts.Length >= 2)
                        {
                            var lastName = nameParts[0].Trim();
                            var firstName = nameParts[1].Trim();

                            string country = values.Length > 19 ? values[19].Trim() : "";
                            string gender = values.Length > 21 ? values[21].Trim() : "";

                            chosenDataFileGridView.Rows.Add(birthID, lastName, firstName, "24", country, gender);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pri načítaní CSV súboru: " + ex.Message);
            }
        }
    }
}
