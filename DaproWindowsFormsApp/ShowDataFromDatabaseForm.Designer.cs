namespace DaproWindowsFormsApp
{
    partial class ShowDataFromDatabaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDataFromDatabaseForm));
            this.ButtonDataFromPatientsTable = new System.Windows.Forms.Button();
            this.DataGridViewShowTableData = new System.Windows.Forms.DataGridView();
            this.ButtonSortByBirthID = new System.Windows.Forms.Button();
            this.LabelSortingButtons = new System.Windows.Forms.Label();
            this.ButtonSortByLastName = new System.Windows.Forms.Button();
            this.ButtonSortByFirstName = new System.Windows.Forms.Button();
            this.ButtonSortByInsurance = new System.Windows.Forms.Button();
            this.ButtonSortByCountry = new System.Windows.Forms.Button();
            this.ButtonDeleteDuplicateChosenTable = new System.Windows.Forms.Button();
            this.ButtonResetIdNumbersOrder = new System.Windows.Forms.Button();
            this.LabelSetTheTableData = new System.Windows.Forms.Label();
            this.ButtonRemoveTablePatients = new System.Windows.Forms.Button();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ButtonBackToPreviousPage = new System.Windows.Forms.Button();
            this.ButtonSortByGender = new System.Windows.Forms.Button();
            this.LabelNumberOfPatientsInTable = new System.Windows.Forms.Label();
            this.ButtonRemoveSelectedRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShowTableData)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDataFromPatientsTable
            // 
            this.ButtonDataFromPatientsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonDataFromPatientsTable.Location = new System.Drawing.Point(1086, 47);
            this.ButtonDataFromPatientsTable.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDataFromPatientsTable.Name = "ButtonDataFromPatientsTable";
            this.ButtonDataFromPatientsTable.Size = new System.Drawing.Size(205, 63);
            this.ButtonDataFromPatientsTable.TabIndex = 0;
            this.ButtonDataFromPatientsTable.Text = "Databáza pacientov";
            this.ButtonDataFromPatientsTable.UseVisualStyleBackColor = true;
            this.ButtonDataFromPatientsTable.Click += new System.EventHandler(this.ButtonDataFromPatientsTable_Click);
            // 
            // DataGridViewShowTableData
            // 
            this.DataGridViewShowTableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewShowTableData.Location = new System.Drawing.Point(77, 2);
            this.DataGridViewShowTableData.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewShowTableData.Name = "DataGridViewShowTableData";
            this.DataGridViewShowTableData.Size = new System.Drawing.Size(1001, 936);
            this.DataGridViewShowTableData.TabIndex = 1;
            // 
            // ButtonSortByBirthID
            // 
            this.ButtonSortByBirthID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByBirthID.Location = new System.Drawing.Point(1091, 162);
            this.ButtonSortByBirthID.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByBirthID.Name = "ButtonSortByBirthID";
            this.ButtonSortByBirthID.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByBirthID.TabIndex = 2;
            this.ButtonSortByBirthID.Text = "rodného čísla";
            this.ButtonSortByBirthID.UseVisualStyleBackColor = true;
            this.ButtonSortByBirthID.Click += new System.EventHandler(this.ButtonSortByBirthID_Click);
            // 
            // LabelSortingButtons
            // 
            this.LabelSortingButtons.AutoSize = true;
            this.LabelSortingButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelSortingButtons.Location = new System.Drawing.Point(1119, 132);
            this.LabelSortingButtons.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSortingButtons.Name = "LabelSortingButtons";
            this.LabelSortingButtons.Size = new System.Drawing.Size(138, 20);
            this.LabelSortingButtons.TabIndex = 3;
            this.LabelSortingButtons.Text = "Usporiadať podľa";
            // 
            // ButtonSortByLastName
            // 
            this.ButtonSortByLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByLastName.Location = new System.Drawing.Point(1091, 248);
            this.ButtonSortByLastName.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByLastName.Name = "ButtonSortByLastName";
            this.ButtonSortByLastName.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByLastName.TabIndex = 4;
            this.ButtonSortByLastName.Text = "priezviska";
            this.ButtonSortByLastName.UseVisualStyleBackColor = true;
            this.ButtonSortByLastName.Click += new System.EventHandler(this.ButtonSortByLastName_Click);
            // 
            // ButtonSortByFirstName
            // 
            this.ButtonSortByFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByFirstName.Location = new System.Drawing.Point(1091, 334);
            this.ButtonSortByFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByFirstName.Name = "ButtonSortByFirstName";
            this.ButtonSortByFirstName.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByFirstName.TabIndex = 5;
            this.ButtonSortByFirstName.Text = "krstného mena";
            this.ButtonSortByFirstName.UseVisualStyleBackColor = true;
            // 
            // ButtonSortByInsurance
            // 
            this.ButtonSortByInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByInsurance.Location = new System.Drawing.Point(1091, 421);
            this.ButtonSortByInsurance.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByInsurance.Name = "ButtonSortByInsurance";
            this.ButtonSortByInsurance.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByInsurance.TabIndex = 6;
            this.ButtonSortByInsurance.Text = "poisťovne";
            this.ButtonSortByInsurance.UseVisualStyleBackColor = true;
            // 
            // ButtonSortByCountry
            // 
            this.ButtonSortByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByCountry.Location = new System.Drawing.Point(1091, 507);
            this.ButtonSortByCountry.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByCountry.Name = "ButtonSortByCountry";
            this.ButtonSortByCountry.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByCountry.TabIndex = 7;
            this.ButtonSortByCountry.Text = "krajiny";
            this.ButtonSortByCountry.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteDuplicateChosenTable
            // 
            this.ButtonDeleteDuplicateChosenTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonDeleteDuplicateChosenTable.Location = new System.Drawing.Point(1347, 162);
            this.ButtonDeleteDuplicateChosenTable.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteDuplicateChosenTable.Name = "ButtonDeleteDuplicateChosenTable";
            this.ButtonDeleteDuplicateChosenTable.Size = new System.Drawing.Size(200, 80);
            this.ButtonDeleteDuplicateChosenTable.TabIndex = 8;
            this.ButtonDeleteDuplicateChosenTable.Text = "Zmazať duplicitné záznamy";
            this.ButtonDeleteDuplicateChosenTable.UseVisualStyleBackColor = true;
            this.ButtonDeleteDuplicateChosenTable.Click += new System.EventHandler(this.ButtonDeleteDuplicateChosenTable_Click);
            // 
            // ButtonResetIdNumbersOrder
            // 
            this.ButtonResetIdNumbersOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonResetIdNumbersOrder.Location = new System.Drawing.Point(1347, 248);
            this.ButtonResetIdNumbersOrder.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonResetIdNumbersOrder.Name = "ButtonResetIdNumbersOrder";
            this.ButtonResetIdNumbersOrder.Size = new System.Drawing.Size(200, 80);
            this.ButtonResetIdNumbersOrder.TabIndex = 9;
            this.ButtonResetIdNumbersOrder.Text = "Zreserovať poradie";
            this.ButtonResetIdNumbersOrder.UseVisualStyleBackColor = true;
            this.ButtonResetIdNumbersOrder.Click += new System.EventHandler(this.ButtonResetIdNumbersOrder_Click);
            // 
            // LabelSetTheTableData
            // 
            this.LabelSetTheTableData.AutoSize = true;
            this.LabelSetTheTableData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelSetTheTableData.Location = new System.Drawing.Point(1377, 132);
            this.LabelSetTheTableData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSetTheTableData.Name = "LabelSetTheTableData";
            this.LabelSetTheTableData.Size = new System.Drawing.Size(100, 20);
            this.LabelSetTheTableData.TabIndex = 10;
            this.LabelSetTheTableData.Text = "Upraviť dáta";
            // 
            // ButtonRemoveTablePatients
            // 
            this.ButtonRemoveTablePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonRemoveTablePatients.Location = new System.Drawing.Point(1347, 334);
            this.ButtonRemoveTablePatients.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveTablePatients.Name = "ButtonRemoveTablePatients";
            this.ButtonRemoveTablePatients.Size = new System.Drawing.Size(200, 80);
            this.ButtonRemoveTablePatients.TabIndex = 12;
            this.ButtonRemoveTablePatients.Text = "Zmazať celú tabuľku Patients";
            this.ButtonRemoveTablePatients.UseVisualStyleBackColor = true;
            this.ButtonRemoveTablePatients.Click += new System.EventHandler(this.ButtonRemoveTablePatients_Click);
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(170, 23);
            this.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2";
            // 
            // ButtonBackToPreviousPage
            // 
            this.ButtonBackToPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonBackToPreviousPage.Location = new System.Drawing.Point(1663, 13);
            this.ButtonBackToPreviousPage.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonBackToPreviousPage.Name = "ButtonBackToPreviousPage";
            this.ButtonBackToPreviousPage.Size = new System.Drawing.Size(130, 50);
            this.ButtonBackToPreviousPage.TabIndex = 13;
            this.ButtonBackToPreviousPage.Text = "← Späť";
            this.ButtonBackToPreviousPage.UseVisualStyleBackColor = true;
            this.ButtonBackToPreviousPage.Click += new System.EventHandler(this.ButtonBackToPreviousPage_Click);
            // 
            // ButtonSortByGender
            // 
            this.ButtonSortByGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSortByGender.Location = new System.Drawing.Point(1091, 595);
            this.ButtonSortByGender.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSortByGender.Name = "ButtonSortByGender";
            this.ButtonSortByGender.Size = new System.Drawing.Size(200, 80);
            this.ButtonSortByGender.TabIndex = 14;
            this.ButtonSortByGender.Text = "pohlavia";
            this.ButtonSortByGender.UseVisualStyleBackColor = true;
            // 
            // LabelNumberOfPatientsInTable
            // 
            this.LabelNumberOfPatientsInTable.AutoSize = true;
            this.LabelNumberOfPatientsInTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelNumberOfPatientsInTable.Location = new System.Drawing.Point(1087, 693);
            this.LabelNumberOfPatientsInTable.Name = "LabelNumberOfPatientsInTable";
            this.LabelNumberOfPatientsInTable.Size = new System.Drawing.Size(0, 20);
            this.LabelNumberOfPatientsInTable.TabIndex = 15;
            // 
            // ButtonRemoveSelectedRow
            // 
            this.ButtonRemoveSelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonRemoveSelectedRow.Location = new System.Drawing.Point(1347, 422);
            this.ButtonRemoveSelectedRow.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemoveSelectedRow.Name = "ButtonRemoveSelectedRow";
            this.ButtonRemoveSelectedRow.Size = new System.Drawing.Size(200, 80);
            this.ButtonRemoveSelectedRow.TabIndex = 16;
            this.ButtonRemoveSelectedRow.Text = "Zmazať vybraný riadok";
            this.ButtonRemoveSelectedRow.UseVisualStyleBackColor = true;
            this.ButtonRemoveSelectedRow.Click += new System.EventHandler(this.ButtonRemoveSelectedRow_Click);
            // 
            // ShowDataFromDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1884, 951);
            this.Controls.Add(this.ButtonRemoveSelectedRow);
            this.Controls.Add(this.LabelNumberOfPatientsInTable);
            this.Controls.Add(this.ButtonSortByGender);
            this.Controls.Add(this.ButtonBackToPreviousPage);
            this.Controls.Add(this.ButtonRemoveTablePatients);
            this.Controls.Add(this.LabelSetTheTableData);
            this.Controls.Add(this.ButtonResetIdNumbersOrder);
            this.Controls.Add(this.ButtonDeleteDuplicateChosenTable);
            this.Controls.Add(this.ButtonSortByCountry);
            this.Controls.Add(this.ButtonSortByInsurance);
            this.Controls.Add(this.ButtonSortByFirstName);
            this.Controls.Add(this.ButtonSortByLastName);
            this.Controls.Add(this.LabelSortingButtons);
            this.Controls.Add(this.ButtonSortByBirthID);
            this.Controls.Add(this.DataGridViewShowTableData);
            this.Controls.Add(this.ButtonDataFromPatientsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowDataFromDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowDataFromDatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewShowTableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDataFromPatientsTable;
        private System.Windows.Forms.DataGridView DataGridViewShowTableData;
        private System.Windows.Forms.Button ButtonSortByBirthID;
        private System.Windows.Forms.Label LabelSortingButtons;
        private System.Windows.Forms.Button ButtonSortByLastName;
        private System.Windows.Forms.Button ButtonSortByFirstName;
        private System.Windows.Forms.Button ButtonSortByInsurance;
        private System.Windows.Forms.Button ButtonSortByCountry;
        private System.Windows.Forms.Button ButtonDeleteDuplicateChosenTable;
        private System.Windows.Forms.Button ButtonResetIdNumbersOrder;
        private System.Windows.Forms.Label LabelSetTheTableData;
        private System.Windows.Forms.Button ButtonRemoveTablePatients;
        private System.Windows.Forms.ToolStripLabel ToolStripStatusLabel2;
        private System.Windows.Forms.Button ButtonBackToPreviousPage;
        private System.Windows.Forms.Button ButtonSortByGender;
        private System.Windows.Forms.Label LabelNumberOfPatientsInTable;
        private System.Windows.Forms.Button ButtonRemoveSelectedRow;
    }
}