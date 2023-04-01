using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }
        public double PhoneNumber { get; set; }
        public string EMail { get; set; }

        private void AssertStringContainsOnlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c) || c != ' ')
                    throw new ArgumentException($"Invalid character {c}.");
            }
        }
    }
}
