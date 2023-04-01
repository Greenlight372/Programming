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
        private double _phoneNumber;
        private string _eMail;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                AssertStringContainsOnlyLetters(_name);
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                AssertStringContainsOnlyLetters(_surname);
            }
        }
        public double PhoneNumber { get; set; }
        public string EMail { get; set; }

        private void AssertStringContainsOnlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c) || c != ' ')
                    throw new ArgumentException($"Invalid character {0}.", nameof(c));
            }
        }
    }
}
