
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\DataProcessor.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DaproWindowsFormsApp
{
    public class DataProcessor
    {
        public static List<Patient> LoadPatientsFromFile(string filePath)
        {
            var patients = new List<Patient>();

            foreach (var line in File.ReadLines(filePath))
            {
                var columns = line.Split('|');

                // Skontrolujeme, či má riadok dostatok stĺpcov
                if (columns.Length > 7)
                {
                    Console.WriteLine("Nesprávny formát riadku, preskakujem riadok.");
                    continue;
                }

                var birthId = columns[2];  // Tretia hodnota je BirthID

                // Rozdelíme celé meno na priezvisko a meno
                var fullName = columns[3].Trim();
                var nameParts = fullName.Split(' ');

                if (nameParts.Length < 2)
                {
                    Console.WriteLine("Nesprávny formát mena, preskakujem riadok.");
                    continue;
                }

                var lastName = nameParts[0];
                var firstName = nameParts[1];
                var insurance = columns[4];
                var country = columns[5];
                var gender = columns[6];

                // Vytvoríme objekt pacienta a pridáme do zoznamu
                var patient = new Patient
                {
                    BirthID = birthId,
                    LastName = lastName,
                    FirstName = firstName,
                    Insurance = insurance,
                    Country = country,
                    Gender = gender
                };

                patients.Add(patient);
            }

            return patients;
        }
    }
}
