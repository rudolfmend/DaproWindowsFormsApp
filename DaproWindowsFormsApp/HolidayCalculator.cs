
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\HolidayCalculator.cs
using System;
using System.Collections.Generic;
using PublicHoliday;

namespace DaproWindowsFormsApp
{
    public interface IHolidayCalculator
    {
        bool IsWorkingDay(DateTime date, string countryCode);
        DateTime GetNextWorkingDay(DateTime date, string countryCode);
        IList<DateTime> GetHolidaysForYear(int year, string countryCode);
        int GetWorkingDaysBetweenDates(DateTime startDate, DateTime endDate, string countryCode);
    }

    public class HolidayCalculator : IHolidayCalculator
    {
        private readonly Dictionary<string, IPublicHolidays> _holidayCalculators;

        public HolidayCalculator()
        {
            _holidayCalculators = new Dictionary<string, IPublicHolidays>
            {
                { "AT", new AustriaPublicHoliday() },
                { "BE", new BelgiumPublicHoliday() },
                { "CZ", new CzechRepublicPublicHoliday() },
                { "DK", new DenmarkPublicHoliday() },
                { "EE", new EstoniaPublicHoliday() },
                { "FI", new FinlandPublicHoliday() },
                { "FR", new FrancePublicHoliday() },
                { "DE", new GermanPublicHoliday() },
                { "GR", new GreecePublicHoliday() },
                { "IE", new IrelandPublicHoliday() },
                { "IT", new ItalyPublicHoliday() },
                { "LT", new LithuaniaPublicHoliday() },
                { "LU", new LuxembourgPublicHoliday() },
                { "ME", new MontenegroPublicHoliday() },
                { "NL", new DutchPublicHoliday() },
                { "NO", new NorwayPublicHoliday() },
                { "PL", new PolandPublicHoliday() },
                { "PT", new PortugalPublicHoliday() },
                { "RO", new RomanianPublicHoliday() },
                { "RS", new SerbianPublicHoliday() },
                { "SK", new SlovakiaPublicHoliday() },
                { "GB", new UKBankHoliday() },
                { "US", new USAPublicHoliday() }
            };
        }

        public bool IsWorkingDay(DateTime date, string countryCode)
        {
            ValidateCountryCode(countryCode);

            var calculator = _holidayCalculators[countryCode.ToUpper()];
            return !calculator.IsPublicHoliday(date) && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }

        public DateTime GetNextWorkingDay(DateTime date, string countryCode)
        {
            ValidateCountryCode(countryCode);

            var calculator = _holidayCalculators[countryCode.ToUpper()];
            return calculator.NextWorkingDay(date);
        }

        public IList<DateTime> GetHolidaysForYear(int year, string countryCode)
        {
            ValidateCountryCode(countryCode);

            var calculator = _holidayCalculators[countryCode.ToUpper()];
            return calculator.PublicHolidays(year);
        }

        public int GetWorkingDaysBetweenDates(DateTime startDate, DateTime endDate, string countryCode)
        {
            ValidateCountryCode(countryCode);

            if (startDate > endDate)
                throw new ArgumentException("Start date must be before or equal to end date");

            int workingDays = 0;
            var currentDate = startDate.Date;

            while (currentDate <= endDate)
            {
                if (IsWorkingDay(currentDate, countryCode))
                    workingDays++;

                currentDate = currentDate.AddDays(1);
            }

            return workingDays;
        }

        private void ValidateCountryCode(string countryCode)
        {
            if (string.IsNullOrWhiteSpace(countryCode))
                throw new ArgumentException("Country code cannot be null or empty");

            if (!_holidayCalculators.ContainsKey(countryCode.ToUpper()))
                throw new ArgumentException($"Unsupported country code: {countryCode}. Supported codes are: {string.Join(", ", _holidayCalculators.Keys)}");
        }
    }

    public class HolidayInfo
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public bool IsWorkingDay { get; set; }

        public override string ToString()
        {
            return $"{Date:yyyy-MM-dd} - {Name} ({CountryCode})";
        }
    }
}
