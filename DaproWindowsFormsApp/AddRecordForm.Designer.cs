namespace DaproWindowsFormsApp
{
    partial class AddRecordForm
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
            this.ListBoxHolidayPreview = new System.Windows.Forms.ListBox();
            this.ButtonHolidayPreview = new System.Windows.Forms.Button();
            this.ComboBoxHolidayPreview = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListBoxHolidayPreview
            // 
            this.ListBoxHolidayPreview.FormattingEnabled = true;
            this.ListBoxHolidayPreview.ItemHeight = 24;
            this.ListBoxHolidayPreview.Location = new System.Drawing.Point(734, 18);
            this.ListBoxHolidayPreview.Name = "ListBoxHolidayPreviewAddRecordForm";
            this.ListBoxHolidayPreview.Size = new System.Drawing.Size(400, 796);
            this.ListBoxHolidayPreview.TabIndex = 0;
            this.ListBoxHolidayPreview.SelectedIndexChanged += new System.EventHandler(this.ListBoxHolidayPreviewAddRecordForm_SelectedIndexChanged);
            // 
            // ButtonHolidayPreview
            // 
            this.ButtonHolidayPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHolidayPreview.Location = new System.Drawing.Point(213, 713);
            this.ButtonHolidayPreview.Name = "ButtonHolidayPreview";
            this.ButtonHolidayPreview.Size = new System.Drawing.Size(283, 53);
            this.ButtonHolidayPreview.TabIndex = 1;
            this.ButtonHolidayPreview.Text = "ButtonHolidayPreviewAddRecordForm";
            this.ButtonHolidayPreview.UseVisualStyleBackColor = true;
            this.ButtonHolidayPreview.Click += new System.EventHandler(this.ButtonHolidayPreviewAddRecordForm_Click);
            // 
            // ComboBoxHolidayPreviewAddRecordForm
            // 
            this.ComboBoxHolidayPreview.FormattingEnabled = true;
            this.ComboBoxHolidayPreview.Items.AddRange(new object[] {
            "",
            "SK",
            "CZ",
            "AT",
            "BE",
            "DK",
            "EE",
            "FI",
            "FR",
            "DE",
            "GR",
            "IE",
            "IT",
            "LT",
            "LU",
            "ME",
            "NL",
            "NO",
            "PL",
            "PT",
            "RO",
            "RS",
            "GB",
            "US"});
            this.ComboBoxHolidayPreview.Location = new System.Drawing.Point(169, 98);
            this.ComboBoxHolidayPreview.Name = "ComboBoxHolidayPreviewAddRecordForm";
            this.ComboBoxHolidayPreview.Size = new System.Drawing.Size(121, 32);
            this.ComboBoxHolidayPreview.SelectedIndexChanged += new System.EventHandler(this.ComboBoxHolidayPreviewAddRecordForm_SelectedIndexChanged);
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.ComboBoxHolidayPreview);
            this.Controls.Add(this.ButtonHolidayPreview);
            this.Controls.Add(this.ListBoxHolidayPreview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddRecordForm";
            this.Text = "AddRecordForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxHolidayPreview;
        private System.Windows.Forms.Button ButtonHolidayPreview;
        private System.Windows.Forms.ComboBox ComboBoxHolidayPreview;
    }
}