
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\DataViewerForm.Designer.cs
namespace DaproWindowsFormsApp
{
    partial class DataViewerForm
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
            this.textBoxDataFile = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.chosenDataFileGridView = new System.Windows.Forms.DataGridView();
            this.ButtonToPageShowData = new System.Windows.Forms.Button();
            this.ComboBoxInsurance = new System.Windows.Forms.ComboBox();
            this.ComboBoxCountry = new System.Windows.Forms.ComboBox();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.ButtonSavePatients = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chosenDataFileGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDataFile
            // 
            this.textBoxDataFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDataFile.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDataFile.Location = new System.Drawing.Point(1095, 12);
            this.textBoxDataFile.Multiline = true;
            this.textBoxDataFile.Name = "textBoxDataFile";
            this.textBoxDataFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDataFile.Size = new System.Drawing.Size(496, 51);
            this.textBoxDataFile.TabIndex = 0;
            this.textBoxDataFile.Text = "dátový súbor";
            this.textBoxDataFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDataFile.TextChanged += new System.EventHandler(this.TextBoxDataFile_TextChanged);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenFolder.Location = new System.Drawing.Point(912, 12);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(131, 51);
            this.buttonOpenFolder.TabIndex = 1;
            this.buttonOpenFolder.Tag = "";
            this.buttonOpenFolder.Text = "Hľadať dátový súbor";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // chosenDataFileGridView
            // 
            this.chosenDataFileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenDataFileGridView.Location = new System.Drawing.Point(12, 12);
            this.chosenDataFileGridView.Name = "chosenDataFileGridView";
            this.chosenDataFileGridView.Size = new System.Drawing.Size(875, 784);
            this.chosenDataFileGridView.TabIndex = 2;
            // 
            // ButtonToPageShowData
            // 
            this.ButtonToPageShowData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.ButtonToPageShowData.Location = new System.Drawing.Point(1620, 12);
            this.ButtonToPageShowData.Name = "ButtonToPageShowData";
            this.ButtonToPageShowData.Size = new System.Drawing.Size(130, 50);
            this.ButtonToPageShowData.TabIndex = 4;
            this.ButtonToPageShowData.Text = "← Databáza";
            this.ButtonToPageShowData.UseVisualStyleBackColor = true;
            this.ButtonToPageShowData.Click += new System.EventHandler(this.ButtonToPageShowData_Click);
            // 
            // ComboBoxInsurance
            // 
            this.ComboBoxInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ComboBoxInsurance.FormattingEnabled = true;
            this.ComboBoxInsurance.ItemHeight = 20;
            this.ComboBoxInsurance.Items.AddRange(new object[] {
            "24",
            "25",
            "27"});
            this.ComboBoxInsurance.Location = new System.Drawing.Point(1224, 182);
            this.ComboBoxInsurance.Name = "ComboBoxInsurance";
            this.ComboBoxInsurance.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxInsurance.TabIndex = 8;
            this.ComboBoxInsurance.Text = "Poisťovňa";
            this.ComboBoxInsurance.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInsurance_SelectedIndexChanged);
            // 
            // ComboBoxCountry
            // 
            this.ComboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ComboBoxCountry.FormattingEnabled = true;
            this.ComboBoxCountry.ItemHeight = 20;
            this.ComboBoxCountry.Items.AddRange(new object[] {
            "",
            "CZ",
            "UA",
            "AT",
            "DE"});
            this.ComboBoxCountry.Location = new System.Drawing.Point(1068, 129);
            this.ComboBoxCountry.Name = "ComboBoxCountry";
            this.ComboBoxCountry.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxCountry.TabIndex = 9;
            this.ComboBoxCountry.Text = "Krajina";
            this.ComboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCountry_SelectedIndexChanged);
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.ItemHeight = 20;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.ComboBoxGender.Location = new System.Drawing.Point(1224, 129);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxGender.TabIndex = 10;
            this.ComboBoxGender.Text = "Pohlavie";
            this.ComboBoxGender.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGender_SelectedIndexChanged);
            // 
            // ButtonSavePatients
            // 
            this.ButtonSavePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ButtonSavePatients.Location = new System.Drawing.Point(912, 347);
            this.ButtonSavePatients.Name = "ButtonSavePatients";
            this.ButtonSavePatients.Size = new System.Drawing.Size(150, 73);
            this.ButtonSavePatients.TabIndex = 11;
            this.ButtonSavePatients.Text = "Uložiť pacientov";
            this.ButtonSavePatients.UseVisualStyleBackColor = true;
            this.ButtonSavePatients.Click += new System.EventHandler(this.ButtonSavePatients_Click);
            // 
            // DataViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1884, 951);
            this.Controls.Add(this.ButtonSavePatients);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.ComboBoxCountry);
            this.Controls.Add(this.ComboBoxInsurance);
            this.Controls.Add(this.ButtonToPageShowData);
            this.Controls.Add(this.chosenDataFileGridView);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textBoxDataFile);
            this.Name = "DataViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.chosenDataFileGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDataFile;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.DataGridView chosenDataFileGridView;
        private System.Windows.Forms.Button ButtonToPageShowData;
        private System.Windows.Forms.ComboBox ComboBoxInsurance;
        private System.Windows.Forms.ComboBox ComboBoxCountry;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Button ButtonSavePatients;
    }
}

