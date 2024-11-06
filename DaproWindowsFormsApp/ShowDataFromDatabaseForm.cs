
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\ShowDataFromDatabaseForm.cs
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DaproWindowsFormsApp
{
    public partial class ShowDataFromDatabaseForm : Form
    {
        private readonly DataGridView chosenDataFileGridView;
        private int currentNumberOfPatients = 0;
        private const string ConnectionString = "Data Source=DaproSQLiteDB.db";
        private string currentTable;
        private readonly BindingSource bindingSource = new BindingSource();
        private readonly StatusStrip statusStrip = new StatusStrip();
        private readonly ToolStripStatusLabel statusLabel2 = new ToolStripStatusLabel();
        private readonly TextBox searchBox;
        private readonly bool isSearchBoxDefault = true;


        public ShowDataFromDatabaseForm()
        {
            InitializeComponent();
            InitializeStatusStrip2();
            InitializeDataGridViewSettings();
            //SetupSearchBox();

            // Základná inicializácia DataGridView
            chosenDataFileGridView = new DataGridView
            {
                Dock = DockStyle.Fill, // alebo iné nastavenie pozície
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };

            // Pridajte registráciu Load eventu
            this.Load += ShowDataFromDatabaseForm_Load;
        }

        private void ShowDataFromDatabaseForm_Load(object sender, EventArgs e)
        {
            if (DataGridViewShowTableData == null)
            {
                MessageBox.Show("DataGridView nie je správne inicializovaný.", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ak máte definovanú predvolenú tabuľku, môžete ju načítať
            if (!string.IsNullOrEmpty(currentTable))
            {
                LoadDataFromTable(currentTable);
            }
        }

        private void InitializeStatusStrip2()
        {
            statusStrip.Items.Add(statusLabel2);
            this.Controls.Add(statusStrip);
        }

        private void InitializeDataGridViewSettings()
        {
            DataGridViewShowTableData.DataSource = bindingSource;
            DataGridViewShowTableData.AllowUserToAddRows = false;
            DataGridViewShowTableData.ReadOnly = true;
            DataGridViewShowTableData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewShowTableData.RowsDefaultCellStyle.BackColor = Color.White;
            DataGridViewShowTableData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Pridanie kontextového menu pre export
            var contextMenu = new ContextMenuStrip();
            var exportMenuItem = new ToolStripMenuItem("Export do Excel");
            exportMenuItem.Click += ExportToExcel_Click;
            contextMenu.Items.Add(exportMenuItem);
            DataGridViewShowTableData.ContextMenuStrip = contextMenu;
        }
        private void ButtonBackToPreviousPage_Click(object sender, EventArgs e)
        {
            BackToPreviousPage();
        }

        private void BackToPreviousPage()
        {
            this.Hide();
            var dataViewerForm = new DataViewerForm();
            dataViewerForm.Closed += (s, args) => this.Close();
            dataViewerForm.Show();
        }

        //private void SetupSearchBox()
        //{
        //    searchBox = new TextBox
        //    {
        //        Location = new Point(10, 10),
        //        Size = new Size(200, 20),
        //        ForeColor = Color.Gray,
        //        Text = "Vyhľadať..."
        //    };

        //    // Náhrada za PlaceholderText pomocou udalostí
        //    searchBox.GotFocus += (s, e) =>
        //    {
        //        if (isSearchBoxDefault)
        //        {
        //            searchBox.Text = "";
        //            searchBox.ForeColor = Color.Black;
        //            isSearchBoxDefault = false;
        //        }
        //    };

        //    searchBox.LostFocus += (s, e) =>
        //    {
        //        if (string.IsNullOrWhiteSpace(searchBox.Text))
        //        {
        //            searchBox.Text = "Vyhľadať...";
        //            searchBox.ForeColor = Color.Gray;
        //            isSearchBoxDefault = true;
        //        }
        //    };

        //    searchBox.TextChanged += SearchBox_TextChanged;
        //    this.Controls.Add(searchBox);
        //}

        private void ButtonDataFromPatientsTable_Click(object sender, EventArgs e)
        {
            currentTable = "Patients";
            LoadDataFromTable(currentTable);
        }


        private void LoadDataFromTable(string tableName)
        {
            try
            {
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();

                    string query = $"SELECT * FROM {tableName}";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            bindingSource.DataSource = dataTable;
                            DataGridViewShowTableData.DataSource = bindingSource;
                        }
                    }
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show($"Error loading data from table '{tableName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel2.Text = $"Error loading data from table '{tableName}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel2.Text = "Unexpected error";
            }
        }



        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (isSearchBoxDefault) return;

            if (bindingSource.DataSource is DataTable dataTable)
            {
                string searchText = searchBox.Text.ToLower();
                DataView dv = dataTable.DefaultView;

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Upravené vytvorenie filtra pre všetky stĺpce
                    var filters = new List<string>();
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        filters.Add($"CONVERT({column.ColumnName}, System.String) LIKE '%{searchText}%'");
                    }
                    string filter = string.Join(" OR ", filters);

                    dv.RowFilter = filter;
                }
                else
                {
                    dv.RowFilter = string.Empty;
                }

                UpdateStatus($"Nájdených záznamov: {dv.Count}");
            }
        }

        private void ExportToExcel_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource is DataTable dataTable)
            {
                using (SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = $"{currentTable}_{DateTime.Now:yyyyMMdd}"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            UpdateStatus("Exportujem dáta do Excelu...");
                            ExportToExcel(dataTable, sfd.FileName);
                            UpdateStatus("Export dokončený");

                            if (MessageBox.Show("Export bol úspešný. Chcete otvoriť súbor?", "Export",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                System.Diagnostics.Process.Start(sfd.FileName);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Chyba pri exporte: {ex.Message}", "Chyba",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            UpdateStatus("Chyba pri exporte");
                        }
                    }
                }
            }
        }

        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            // Tu by ste implementovali skutočný export do Excelu
            // Môžete použiť knižnice ako EPPlus, ClosedXML, alebo NPOI
            throw new NotImplementedException("Implementujte export do Excelu pomocou vhodnej knižnice");
        }

        private void UpdateStatus(string message)
        {
            if (statusLabel2.Text != message)
            {
                statusLabel2.Text = message;
                statusStrip.Refresh();
            }
        }

        private void ButtonSortByBirthID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTable))
            {
                MessageBox.Show("Najprv načítajte tabuľku.", "Upozornenie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadSortedData();
        }

        private void ResetIdNumbersOrder()
        {
            try
            {
                UpdateStatus("Resetujem poradie ID...");
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        // 1. Vytvorenie dočasnej tabuľky s novým poradím Id
                        command.CommandText = $@"
                    CREATE TEMP TABLE {currentTable}_temp AS
                    SELECT row_number() OVER (ORDER BY Id) AS new_id, 
                           BirthID, LastName, FirstName, Insurance, Country, Gender
                    FROM {currentTable};
                ";
                        command.ExecuteNonQuery();

                        // 2. Vymazanie pôvodnej tabuľky
                        command.CommandText = $"DROP TABLE {currentTable};";
                        command.ExecuteNonQuery();

                        // 3. Vytvorenie novej tabuľky so správnou štruktúrou
                        command.CommandText = $@"
                    CREATE TABLE {currentTable} (
                        Id INTEGER PRIMARY KEY,
                        BirthID TEXT,
                        LastName TEXT,
                        FirstName TEXT,
                        Insurance TEXT,
                        Country TEXT,
                        Gender TEXT
                    );";
                        command.ExecuteNonQuery();

                        // 4. Prekopírovanie dát
                        command.CommandText = $@"
                    INSERT INTO {currentTable} (Id, BirthID, LastName, FirstName, Insurance, Country, Gender)
                    SELECT new_id, BirthID, LastName, FirstName, Insurance, Country, Gender
                    FROM {currentTable}_temp;";
                        command.ExecuteNonQuery();

                        // 5. Vymazanie dočasnej tabuľky
                        command.CommandText = $"DROP TABLE {currentTable}_temp;";
                        command.ExecuteNonQuery();

                        LoadSortedData(); // Načítanie aktualizovaných dát
                    }
                }
                MessageBox.Show("Poradie ID bolo úspešne resetované.", "Úspech",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStatus("Poradie ID bolo úspešne resetované.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri resetovaní ID: {ex.Message}",
                                "Chyba",
                                buttons: MessageBoxButtons.OK,
                                icon: MessageBoxIcon.Error);
                UpdateStatus("Chyba pri resetovaní poradia čísel ID");
            }
        }

        private void LoadSortedData()
        {
            try
            {
                UpdateStatus("Zoraďujem dáta...");
                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();

                    using (var command = connection.CreateCommand())
                    {
                        // Explicitne definujeme stĺpce
                        dataTable.Columns.Add("Id", typeof(int));
                        dataTable.Columns.Add("BirthID", typeof(string));
                        dataTable.Columns.Add("LastName", typeof(string));
                        dataTable.Columns.Add("FirstName", typeof(string));
                        dataTable.Columns.Add("Insurance", typeof(string));
                        dataTable.Columns.Add("Country", typeof(string));
                        dataTable.Columns.Add("Gender", typeof(string));

                        command.CommandText = $"SELECT * FROM {currentTable} ORDER BY BirthID";
                        using (var reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    // Nastavenie DataGridView
                    DataGridViewShowTableData.AutoGenerateColumns = false;

                    // Vyčistenie existujúcich stĺpcov
                    DataGridViewShowTableData.Columns.Clear();

                    // Pridanie stĺpcov do DataGridView
                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Id",
                        HeaderText = "Id",
                        Name = "Id"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "BirthID",
                        HeaderText = "Rodné číslo",
                        Name = "BirthID"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "LastName",
                        HeaderText = "Priezvisko",
                        Name = "LastName"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "FirstName",
                        HeaderText = "Meno",
                        Name = "FirstName"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Insurance",
                        HeaderText = "Poisťovňa",
                        Name = "Insurance"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Country",
                        HeaderText = "Krajina",
                        Name = "Country"
                    });

                    DataGridViewShowTableData.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "Gender",
                        HeaderText = "Pohlavie",
                        Name = "Gender"
                    });

                    bindingSource.DataSource = dataTable;
                    DataGridViewShowTableData.DataSource = bindingSource;

                    UpdateStatus($"Dáta zoradené. Počet záznamov: {dataTable.Rows.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri zoraďovaní: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Chyba pri zoraďovaní dát");
            }
        }

        private void ButtonDeleteDuplicateChosenTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currentTable))
                {
                    MessageBox.Show("Najprv načítajte tabuľku.", "Upozornenie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show(
                    "Naozaj chcete vymazať duplicitné záznamy? Túto akciu nie je možné vrátiť späť.",
                    "Potvrdenie vymazania",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    DeleteDuplicatesFromCurrentTable();
                    LoadDataFromTable(currentTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri spustení mazania duplicít: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Chyba pri spustení mazania duplicít.");
            }

        }

        private void DeleteDuplicatesFromCurrentTable()
        {
            try
            {
                UpdateStatus("Mažem duplicitné záznamy...");

                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = $@"
                            DELETE FROM {currentTable} 
                            WHERE Id NOT IN (
                                SELECT MIN(Id) 
                                FROM {currentTable} 
                                GROUP BY BirthID, LastName, FirstName
                            )";

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Vymazaných {rowsAffected} duplicitných záznamov.",
                            "Úspech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateStatus($"Vymazaných {rowsAffected} duplicitných záznamov");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri mazaní duplicít: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Chyba pri mazaní duplicít");
            }
        }

        private void ButtonResetIdNumbersOrder_Click(object sender, EventArgs e)
        {
            ResetIdNumbersOrder();
            LoadDataFromTable(currentTable);
        }

        

        private void ButtonRemoveTablePatients_Click(object sender, EventArgs e)
        {
            RemoveTablePatients();
        }

        private void RemoveTablePatients()
        {
            try
            {
                UpdateStatus("Mažem tabuľku Patients...");

                using (var connection = new SqliteConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "DROP TABLE Patients;";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Tabuľka Patients bola úspešne vymazaná.", "Úspech",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateStatus("Tabuľka Patients bola úspešne vymazaná.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba pri mazaní tabuľky: {ex.Message}", "Chyba",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Chyba pri mazaní tabuľky");
            }
        }

        private void ButtonSortByLastName_Click(object sender, EventArgs e)
        {

        }

        private void NumberOfPatientsInTable()
        {
            currentNumberOfPatients = bindingSource.Count;
            LabelNumberOfPatientsInTable.Text = $"Počet uložených pacientov: '{currentNumberOfPatients}'";
        }

        private void ButtonRemoveSelectedRow_Click(object sender, EventArgs e)
        {
            RemoveSelectedRow removeSelectedRow = new RemoveSelectedRow(DataGridViewShowTableData, ConnectionString, currentTable, statusLabel2);
            removeSelectedRow.RemoveRow();
        }

        private void ButtonEditRow_Click(object sender, EventArgs e)
        {
            EditSelectedRow editSelectedRow = new EditSelectedRow(DataGridViewShowTableData, currentTable, statusLabel2);
            editSelectedRow.EditRow();
        }
    }
}
