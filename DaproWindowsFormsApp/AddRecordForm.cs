
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\AddRecordForm.cs
// supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2"
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace DaproWindowsFormsApp
{
    public partial class AddRecordForm : Form
    {
        private readonly HolidayCalculator calculator;
        private readonly bool isWorkDay;
        private readonly int workDays;
        private List<DateTime> holidays;

        public AddRecordForm()
        {
            InitializeComponent();
            calculator = new HolidayCalculator();

            // Determine if today is a working day in Slovakia
            isWorkDay = calculator.IsWorkingDay(DateTime.Today, "SK");

            // Calculate the number of working days in 2024 in Slovakia
            workDays = calculator.GetWorkingDaysBetweenDates(
                new DateTime(2024, 1, 1),
                new DateTime(2024, 12, 31),
                "SK"
            );

            // Get holidays for Slovakia in 2024
            holidays = (List<DateTime>)calculator.GetHolidaysForYear(2024, "SK");
        }

        private void ListBoxHolidayPreviewAddRecordForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isWorkDay)
            {
                if (holidays != null && holidays.Count > 0)
                {
                    MessageBox.Show("Metóda ListBoxHolidayPreviewAddRecordForm_SelectedIndexChanged funguje");

                    ListBoxHolidayPreview.Items.Clear();
                    foreach (var holiday in holidays)
                    {
                        ListBoxHolidayPreview.Items.Add(holiday.ToString("yyyy-MM-dd"));
                    }
                }
                else
                {
                    MessageBox.Show("Nie sú dostupné sviatky.");
                }
            }
        }

        private void ComboBoxHolidayPreviewAddRecordForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                string countryCode = comboBox.SelectedItem.ToString();
                MessageBox.Show($"Zvolený kód krajiny: {countryCode}");

                // Get holidays based on selected country code
                holidays = (List<DateTime>)calculator.GetHolidaysForYear(2024, countryCode);

                // Display updated holidays in ListBox
                ListBoxHolidayPreview.Items.Clear();
                foreach (var holiday in holidays)
                {
                    ListBoxHolidayPreview.Items.Add(holiday.ToString("dd.MM.yyyy"));
                }
            }
            else
            {
                MessageBox.Show("ComboBox je prázdny alebo je zvolený žiadny kód krajiny.");
            }
        }

        private void ButtonHolidayPreviewAddRecordForm_Click(object sender, EventArgs e)
        {
            if (holidays != null && holidays.Count > 0)
            {
                ListBoxHolidayPreview.Items.Clear();
                foreach (var holiday in holidays)
                {
                    ListBoxHolidayPreview.Items.Add(holiday.ToString("yyyy-MM-dd"));
                }
            }
            else
            {
                MessageBox.Show("Nie sú dostupné sviatky na zobrazenie.");
            }
        }
    }
}
