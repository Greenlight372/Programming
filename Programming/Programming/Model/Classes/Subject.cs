using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _hours;

        public string SubjectName { get; set; }
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertOnPositiveValue(value, "Hours");
                _hours = value;
            }
        }
        public bool Credit { get; set; }
    }
}
