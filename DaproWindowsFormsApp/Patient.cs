
// C:\Users\rudol\source\repos\DaproWindowsFormsApp\DaproWindowsFormsApp\Patient.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaproWindowsFormsApp
{
    public class Patient : IEquatable<Patient>
    {
        public int Id { get; set; }

        private string _birthID;
        public string BirthID
        {
            get => _birthID;
            set
            {
                // Validácia rodného čísla - dĺžka 9 alebo 10 znakov
                if (!string.IsNullOrWhiteSpace(value) &&
                    value.Length != 9 && value.Length != 10)
                {
                    throw new ArgumentException("Rodné číslo musí mať 9 alebo 10 znakov.");
                }
                _birthID = value;
            }
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Insurance { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }

        // Implementácia IEquatable<Patient>
        public bool Equals(Patient other)
        {
            // Ak je other null, nie sú rovnaké
            if (other is null) return false;

            // Porovnanie všetkých kľúčových polí
            return
                this.BirthID == other.BirthID &&
                this.LastName == other.LastName &&
                this.FirstName == other.FirstName &&
                this.Insurance == other.Insurance &&
                this.Country == other.Country &&
                this.Gender == other.Gender;
        }

        // Override štandardnej Equals metódy
        public override bool Equals(object obj)
        {
            // Použitie hore definovanej Equals metódy
            return Equals(obj as Patient);
        }

        // Implementácia GetHashCode pre správnu prácu so zoznamami a hashovacími štruktúrami
        public override int GetHashCode()
        {
            // Kombinovanie hash kódov relevantných polí
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (BirthID != null ? BirthID.GetHashCode() : 0);
                hash = hash * 23 + (LastName != null ? LastName.GetHashCode() : 0);
                hash = hash * 23 + (FirstName != null ? FirstName.GetHashCode() : 0);
                hash = hash * 23 + (Insurance != null ? Insurance.GetHashCode() : 0);
                hash = hash * 23 + (Country != null ? Country.GetHashCode() : 0);
                hash = hash * 23 + (Gender != null ? Gender.GetHashCode() : 0);
                return hash;
            }
        }

        public static bool operator ==(Patient left, Patient right)
        {
            // Ak sú oba null, sú rovnaké
            if (left is null && right is null) return true;

            // Ak je jeden null, nie sú rovnaké
            if (left is null || right is null) return false;

            // Zavolanie Equals metódy
            return left.Equals(right);
        }

        public static bool operator !=(Patient left, Patient right)
        {
            return !(left == right);
        }

        // Override ToString pre lepšiu debuggabilitu
        public override string ToString() =>
            $"Patient: {Id} - {FirstName} {LastName} (RČ: {BirthID})";
    }
}
