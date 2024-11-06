
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
            this.ButtonPatientsOpenFolder = new System.Windows.Forms.Button();
            this.chosenDataFileGridView = new System.Windows.Forms.DataGridView();
            this.ButtonToPageShowData = new System.Windows.Forms.Button();
            this.ComboBoxInsurance = new System.Windows.Forms.ComboBox();
            this.ComboBoxCountry = new System.Windows.Forms.ComboBox();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.ButtonSavePatients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNavigateToAddPatientForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ButtonDiagnosesOpenFolder = new System.Windows.Forms.Button();
            this.ButtonHealthcareOpenFolder = new System.Windows.Forms.Button();
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
            // ButtonPatientsOpenFolder
            // 
            this.ButtonPatientsOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPatientsOpenFolder.Location = new System.Drawing.Point(912, 12);
            this.ButtonPatientsOpenFolder.Name = "ButtonPatientsOpenFolder";
            this.ButtonPatientsOpenFolder.Size = new System.Drawing.Size(131, 59);
            this.ButtonPatientsOpenFolder.TabIndex = 1;
            this.ButtonPatientsOpenFolder.Tag = "";
            this.ButtonPatientsOpenFolder.Text = "Hľadať dátový súbor pacientov";
            this.ButtonPatientsOpenFolder.UseVisualStyleBackColor = true;
            this.ButtonPatientsOpenFolder.Click += new System.EventHandler(this.ButtonPatientsOpenFolder_Click);
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
            this.ButtonToPageShowData.Location = new System.Drawing.Point(1692, 306);
            this.ButtonToPageShowData.Name = "ButtonToPageShowData";
            this.ButtonToPageShowData.Size = new System.Drawing.Size(191, 52);
            this.ButtonToPageShowData.TabIndex = 4;
            this.ButtonToPageShowData.Text = "Databáza →";
            this.ButtonToPageShowData.UseVisualStyleBackColor = true;
            this.ButtonToPageShowData.Click += new System.EventHandler(this.ButtonToPageShowData_Click);
            // 
            // ComboBoxInsurance
            // 
            this.ComboBoxInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ComboBoxInsurance.FormattingEnabled = true;
            this.ComboBoxInsurance.ItemHeight = 20;
            this.ComboBoxInsurance.Items.AddRange(new object[] {
            "",
            "24",
            "25",
            "27"});
            this.ComboBoxInsurance.Location = new System.Drawing.Point(1193, 79);
            this.ComboBoxInsurance.Name = "ComboBoxInsurance";
            this.ComboBoxInsurance.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxInsurance.TabIndex = 8;
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
            "DE",
            "CH",
            "FR",
            "BE",
            "NL",
            "FI",
            "GB",
            "USA"});
            this.ComboBoxCountry.Location = new System.Drawing.Point(1193, 113);
            this.ComboBoxCountry.Name = "ComboBoxCountry";
            this.ComboBoxCountry.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxCountry.TabIndex = 9;
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
            this.ComboBoxGender.Location = new System.Drawing.Point(1193, 147);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(150, 28);
            this.ComboBoxGender.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(1095, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Poisťovňa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(1095, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pohlavie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(1095, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Krajina";
            // 
            // ButtonNavigateToAddPatientForm
            // 
            this.ButtonNavigateToAddPatientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.ButtonNavigateToAddPatientForm.Location = new System.Drawing.Point(1692, 70);
            this.ButtonNavigateToAddPatientForm.Name = "ButtonNavigateToAddPatientForm";
            this.ButtonNavigateToAddPatientForm.Size = new System.Drawing.Size(191, 53);
            this.ButtonNavigateToAddPatientForm.TabIndex = 15;
            this.ButtonNavigateToAddPatientForm.Text = "Nový pacient →";
            this.ButtonNavigateToAddPatientForm.UseVisualStyleBackColor = true;
            this.ButtonNavigateToAddPatientForm.Click += new System.EventHandler(this.ButtonNavigateToAddPatientForm_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(1692, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 53);
            this.button2.TabIndex = 16;
            this.button2.Text = "Záznamy →";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.ButtonSettings.Location = new System.Drawing.Point(1692, 367);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(191, 53);
            this.ButtonSettings.TabIndex = 17;
            this.ButtonSettings.Text = "Nastavenia →";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(1692, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 53);
            this.button4.TabIndex = 18;
            this.button4.Text = "Nastavenia →";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1692, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 53);
            this.button5.TabIndex = 19;
            this.button5.Text = "Nastavenia →";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button6.Location = new System.Drawing.Point(912, 426);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 73);
            this.button6.TabIndex = 20;
            this.button6.Text = "Export do VBSV";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button7.Location = new System.Drawing.Point(912, 505);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 73);
            this.button7.TabIndex = 21;
            this.button7.Text = "Export do CSV";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // ButtonDiagnosesOpenFolder
            // 
            this.ButtonDiagnosesOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDiagnosesOpenFolder.Location = new System.Drawing.Point(912, 97);
            this.ButtonDiagnosesOpenFolder.Name = "ButtonDiagnosesOpenFolder";
            this.ButtonDiagnosesOpenFolder.Size = new System.Drawing.Size(131, 59);
            this.ButtonDiagnosesOpenFolder.TabIndex = 22;
            this.ButtonDiagnosesOpenFolder.Tag = "";
            this.ButtonDiagnosesOpenFolder.Text = "Hľadať dátový súbor diagnóz";
            this.ButtonDiagnosesOpenFolder.UseVisualStyleBackColor = true;
            this.ButtonDiagnosesOpenFolder.Click += new System.EventHandler(this.ButtonDiagnosesOpenFolder_Click);
            // 
            // ButtonHealthcareOpenFolder
            // 
            this.ButtonHealthcareOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonHealthcareOpenFolder.Location = new System.Drawing.Point(912, 188);
            this.ButtonHealthcareOpenFolder.Name = "ButtonHealthcareOpenFolder";
            this.ButtonHealthcareOpenFolder.Size = new System.Drawing.Size(131, 59);
            this.ButtonHealthcareOpenFolder.TabIndex = 23;
            this.ButtonHealthcareOpenFolder.Tag = "";
            this.ButtonHealthcareOpenFolder.Text = "Hľadať dátový súbor výkonov";
            this.ButtonHealthcareOpenFolder.UseVisualStyleBackColor = true;
            // 
            // DataViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1884, 951);
            this.Controls.Add(this.ButtonHealthcareOpenFolder);
            this.Controls.Add(this.ButtonDiagnosesOpenFolder);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonNavigateToAddPatientForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSavePatients);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.ComboBoxCountry);
            this.Controls.Add(this.ComboBoxInsurance);
            this.Controls.Add(this.ButtonToPageShowData);
            this.Controls.Add(this.chosenDataFileGridView);
            this.Controls.Add(this.ButtonPatientsOpenFolder);
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
        private System.Windows.Forms.Button ButtonPatientsOpenFolder;
        private System.Windows.Forms.DataGridView chosenDataFileGridView;
        private System.Windows.Forms.Button ButtonToPageShowData;
        private System.Windows.Forms.ComboBox ComboBoxInsurance;
        private System.Windows.Forms.ComboBox ComboBoxCountry;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.Button ButtonSavePatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonNavigateToAddPatientForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button ButtonDiagnosesOpenFolder;
        private System.Windows.Forms.Button ButtonHealthcareOpenFolder;
    }
}

