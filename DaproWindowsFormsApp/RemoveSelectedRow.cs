using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    internal class RemoveSelectedRow
    {
        private DataGridView dataGridViewShowTableData;
        private string ConnectionString; // Add this line to define the ConnectionString field
        private string currentTable; // Add this line to define the currentTable field
        private ToolStripStatusLabel statusLabel2; // Add this line to define the statusLabel2 field

        public RemoveSelectedRow(DataGridView dataGridView, string connectionString, string tableName, ToolStripStatusLabel statusLabel) // Modify constructor to accept connectionString, tableName, and statusLabel
        {
            dataGridViewShowTableData = dataGridView;
            ConnectionString = connectionString; // Initialize the ConnectionString field
            currentTable = tableName; // Initialize the currentTable field
            statusLabel2 = statusLabel; // Initialize the statusLabel2 field
        }

        private void DeleteRecordFromDatabase(int id)
        {
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $"DELETE FROM {currentTable} WHERE Id = @Id";
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri mazaní záznamu z databázy: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveRow()
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
                    var result = MessageBox.Show("Naozaj chcete vymazať tento záznam?",
                        "Potvrdenie vymazania",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var bindingSource = dataGridViewShowTableData.DataSource as BindingSource;
                        if (bindingSource != null)
                        {
                            var dataTable = bindingSource.DataSource as DataTable;
                            if (dataTable != null)
                            {
                                DataRow dataRow = dataTable.Rows[dataGridViewShowTableData.SelectedRows[0].Index];
                                // Získanie ID záznamu (predpokladá sa, že stĺpec ID existuje)
                                int id = Convert.ToInt32(dataRow["Id"]);

                                // Vymazanie z databázy
                                DeleteRecordFromDatabase(id);

                                // Vymazanie z DataTable
                                dataRow.Delete();
                                dataTable.AcceptChanges();
                                UpdateStatus($"Počet záznamov: {dataTable.Rows.Count}");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nie je vybraný žiadny riadok.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nastala chyba: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatus(string message)
        {
            if (statusLabel2.GetCurrentParent().InvokeRequired)
            {
                statusLabel2.GetCurrentParent().Invoke(new Action(() => UpdateStatus(message)));
                return;
            }
            statusLabel2.Text = message;
        }
    }
}
