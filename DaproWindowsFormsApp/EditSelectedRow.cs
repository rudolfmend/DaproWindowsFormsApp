
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\EditSelectedRow.cs
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    internal class EditSelectedRow
    {
        private readonly DataGridView dataGridViewShowTableData;
        //private readonly string ConnectionString;
        private const string ConnectionString = "Data Source=DaproSQLiteDB.db";
        private readonly string currentTable;
        private readonly ToolStripStatusLabel statusLabel2;

        public EditSelectedRow(DataGridView dataGridView, string tableName, ToolStripStatusLabel statusLabel)
        {
            dataGridViewShowTableData = dataGridView;
            currentTable = tableName;
            statusLabel2 = statusLabel;
        }

        public void EditRow()
        {
            try
            {
                if (dataGridViewShowTableData == null || !dataGridViewShowTableData.IsHandleCreated)
                {
                    MessageBox.Show("DataGridView nie je inicializovaný.");
                    return;
                }

                if (dataGridViewShowTableData.SelectedRows.Count > 0 &&
                    dataGridViewShowTableData.SelectedRows[0] != null)
                {
                    var selectedRow = dataGridViewShowTableData.SelectedRows[0];
                    var selectedRowCells = selectedRow.Cells;

                    // Vytvorenie formulára pre úpravu
                    using (var editForm = new Form())
                    {
                        editForm.Text = "Upraviť záznam";
                        editForm.Size = new System.Drawing.Size(400, 300);
                        editForm.StartPosition = FormStartPosition.CenterParent;

                        // Vytvorenie ovládacích prvkov
                        int yOffset = 20;
                        var labels = new string[] { "ID:", "Rodné číslo:", "Priezvisko:", "Meno:", "Poisťovňa:", "Krajina:" };
                        var textBoxes = new TextBox[6];

                        for (int i = 0; i < labels.Length; i++)
                        {
                            var label = new Label
                            {
                                Text = labels[i],
                                Location = new System.Drawing.Point(20, yOffset),
                                AutoSize = true
                            };
                            editForm.Controls.Add(label);

                            textBoxes[i] = new TextBox
                            {
                                Location = new System.Drawing.Point(120, yOffset),
                                Width = 200
                            };
                            editForm.Controls.Add(textBoxes[i]);

                            yOffset += 30;
                        }

                        // Naplnenie textboxov aktuálnymi hodnotami
                        textBoxes[0].Text = selectedRowCells["Id"].Value.ToString();
                        textBoxes[0].ReadOnly = true; // ID nemôže byť upravené
                        textBoxes[1].Text = selectedRowCells["BirthID"].Value.ToString();
                        textBoxes[2].Text = selectedRowCells["LastName"].Value.ToString();
                        textBoxes[3].Text = selectedRowCells["FirstName"].Value.ToString();
                        textBoxes[4].Text = selectedRowCells["Insurance"].Value.ToString();
                        textBoxes[5].Text = selectedRowCells["Country"].Value.ToString();

                        // Tlačidlá
                        var saveButton = new Button
                        {
                            Text = "Uložiť",
                            DialogResult = DialogResult.OK,
                            Location = new System.Drawing.Point(120, yOffset)
                        };
                        editForm.Controls.Add(saveButton);

                        var cancelButton = new Button
                        {
                            Text = "Zrušiť",
                            DialogResult = DialogResult.Cancel,
                            Location = new System.Drawing.Point(220, yOffset)
                        };
                        editForm.Controls.Add(cancelButton);

                        // Zobrazenie formulára
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            // Uloženie upravených údajov
                            SaveUpdatedData(
                                Convert.ToInt32(textBoxes[0].Text),
                                textBoxes[1].Text,
                                textBoxes[2].Text,
                                textBoxes[3].Text,
                                textBoxes[4].Text,
                                textBoxes[5].Text
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Prosím, vyberte riadok na úpravu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri úprave záznamu: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUpdatedData(int id, string birthId, string lastName, string firstName, string insurance, string country)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    string updateQuery = $@"UPDATE {currentTable} 
                                         SET BirthID = @BirthID,
                                             LastName = @LastName,
                                             FirstName = @FirstName,
                                             Insurance = @Insurance,
                                             Country = @Country
                                         WHERE Id = @Id";

                    using (var command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@BirthID", birthId);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@Insurance", insurance);
                        command.Parameters.AddWithValue("@Country", country);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Záznam bol úspešne aktualizovaný.");
                            statusLabel2.Text = "Záznam bol úspešne aktualizovaný.";

                            // Aktualizácia zobrazených údajov v DataGridView
                            var selectedRow = dataGridViewShowTableData.SelectedRows[0];
                            selectedRow.Cells["BirthID"].Value = birthId;
                            selectedRow.Cells["LastName"].Value = lastName;
                            selectedRow.Cells["FirstName"].Value = firstName;
                            selectedRow.Cells["Insurance"].Value = insurance;
                            selectedRow.Cells["Country"].Value = country;
                        }
                        else
                        {
                            MessageBox.Show("Nepodarilo sa aktualizovať záznam.");
                            statusLabel2.Text = "Nepodarilo sa aktualizovať záznam.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba pri ukladaní dát: {ex.Message}", "Chyba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusLabel2.Text = "Chyba pri ukladaní dát.";
                }
            }
        }
    }
}