namespace DaproWindowsFormsApp
{
    partial class AddPatientForm
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
            this.LabelBirthID = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.ComboBoxInsurance = new System.Windows.Forms.ComboBox();
            this.ComboBoxCountry = new System.Windows.Forms.ComboBox();
            this.ComboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPatientsAge = new System.Windows.Forms.Label();
            this.LabelInsurance = new System.Windows.Forms.Label();
            this.ButtonSavePatientToDatabase = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelBirthID
            // 
            this.LabelBirthID.AutoSize = true;
            this.LabelBirthID.BackColor = System.Drawing.Color.Tan;
            this.LabelBirthID.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.LabelBirthID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelBirthID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelBirthID.Location = new System.Drawing.Point(48, 14);
            this.LabelBirthID.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.LabelBirthID.Name = "LabelBirthID";
            this.LabelBirthID.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.LabelBirthID.Size = new System.Drawing.Size(146, 40);
            this.LabelBirthID.TabIndex = 0;
            this.LabelBirthID.Text = "Rodné číslo";
            this.LabelBirthID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.BackColor = System.Drawing.Color.Tan;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.LabelLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelLastName.Location = new System.Drawing.Point(48, 64);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.LabelLastName.Size = new System.Drawing.Size(136, 40);
            this.LabelLastName.TabIndex = 1;
            this.LabelLastName.Text = "Priezvisko";
            this.LabelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.BackColor = System.Drawing.Color.Tan;
            this.LabelFirstName.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.LabelFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelFirstName.Location = new System.Drawing.Point(268, 64);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.LabelFirstName.Size = new System.Drawing.Size(99, 40);
            this.LabelFirstName.TabIndex = 2;
            this.LabelFirstName.Text = "Meno";
            this.LabelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxInsurance
            // 
            this.ComboBoxInsurance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBoxInsurance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ComboBoxInsurance.FormattingEnabled = true;
            this.ComboBoxInsurance.Items.AddRange(new object[] {
            "",
            "24",
            "25",
            "27"});
            this.ComboBoxInsurance.Location = new System.Drawing.Point(148, 445);
            this.ComboBoxInsurance.Name = "ComboBoxInsurance";
            this.ComboBoxInsurance.Size = new System.Drawing.Size(219, 30);
            this.ComboBoxInsurance.TabIndex = 4;
            // 
            // ComboBoxCountry
            // 
            this.ComboBoxCountry.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBoxCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ComboBoxCountry.FormattingEnabled = true;
            this.ComboBoxCountry.Items.AddRange(new object[] {
            "",
            "CZ",
            "AT",
            "DE",
            "UA",
            "CH",
            "BE",
            "GB",
            "FR",
            "DK",
            "NL",
            "HU",
            "PL",
            "USA",
            "LUX"});
            this.ComboBoxCountry.Location = new System.Drawing.Point(148, 498);
            this.ComboBoxCountry.Name = "ComboBoxCountry";
            this.ComboBoxCountry.Size = new System.Drawing.Size(219, 30);
            this.ComboBoxCountry.TabIndex = 5;
            // 
            // ComboBoxGender
            // 
            this.ComboBoxGender.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ComboBoxGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.ComboBoxGender.FormattingEnabled = true;
            this.ComboBoxGender.Items.AddRange(new object[] {
            "",
            "M",
            "F"});
            this.ComboBoxGender.Location = new System.Drawing.Point(148, 548);
            this.ComboBoxGender.Name = "ComboBoxGender";
            this.ComboBoxGender.Size = new System.Drawing.Size(219, 30);
            this.ComboBoxGender.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textBox1.Location = new System.Drawing.Point(148, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 34);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textBox2.Location = new System.Drawing.Point(148, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 34);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.textBox3.Location = new System.Drawing.Point(148, 381);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(425, 34);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(11, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.label1.Size = new System.Drawing.Size(146, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rodné číslo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(21, 315);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.label2.Size = new System.Drawing.Size(136, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = "Priezvisko";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(58, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.label3.Size = new System.Drawing.Size(99, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Meno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelPatientsAge
            // 
            this.LabelPatientsAge.AutoSize = true;
            this.LabelPatientsAge.BackColor = System.Drawing.Color.Tan;
            this.LabelPatientsAge.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.LabelPatientsAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelPatientsAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelPatientsAge.Location = new System.Drawing.Point(48, 114);
            this.LabelPatientsAge.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.LabelPatientsAge.Name = "LabelPatientsAge";
            this.LabelPatientsAge.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.LabelPatientsAge.Size = new System.Drawing.Size(159, 40);
            this.LabelPatientsAge.TabIndex = 13;
            this.LabelPatientsAge.Text = "Vek pacienta";
            this.LabelPatientsAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelInsurance
            // 
            this.LabelInsurance.AutoSize = true;
            this.LabelInsurance.BackColor = System.Drawing.Color.Tan;
            this.LabelInsurance.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 13F, System.Drawing.FontStyle.Bold);
            this.LabelInsurance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelInsurance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelInsurance.Location = new System.Drawing.Point(48, 164);
            this.LabelInsurance.Margin = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.LabelInsurance.Name = "LabelInsurance";
            this.LabelInsurance.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.LabelInsurance.Size = new System.Drawing.Size(177, 40);
            this.LabelInsurance.TabIndex = 14;
            this.LabelInsurance.Text = "LabelInsurance";
            this.LabelInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonSavePatientToDatabase
            // 
            this.ButtonSavePatientToDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSavePatientToDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.ButtonSavePatientToDatabase.Location = new System.Drawing.Point(148, 609);
            this.ButtonSavePatientToDatabase.Name = "ButtonSavePatientToDatabase";
            this.ButtonSavePatientToDatabase.Size = new System.Drawing.Size(425, 93);
            this.ButtonSavePatientToDatabase.TabIndex = 15;
            this.ButtonSavePatientToDatabase.Text = "Uložiť pacienta";
            this.ButtonSavePatientToDatabase.UseVisualStyleBackColor = true;
            this.ButtonSavePatientToDatabase.Click += new System.EventHandler(this.ButtonSavePatientToDatabase_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label4.Location = new System.Drawing.Point(58, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Poistenie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label5.Location = new System.Drawing.Point(76, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Krajina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label6.Location = new System.Drawing.Point(63, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pohlavie";
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(691, 743);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonSavePatientToDatabase);
            this.Controls.Add(this.LabelInsurance);
            this.Controls.Add(this.LabelPatientsAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ComboBoxGender);
            this.Controls.Add(this.ComboBoxCountry);
            this.Controls.Add(this.ComboBoxInsurance);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelBirthID);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBirthID;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.ComboBox ComboBoxInsurance;
        private System.Windows.Forms.ComboBox ComboBoxCountry;
        private System.Windows.Forms.ComboBox ComboBoxGender;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelPatientsAge;
        private System.Windows.Forms.Label LabelInsurance;
        private System.Windows.Forms.Button ButtonSavePatientToDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}