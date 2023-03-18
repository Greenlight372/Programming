using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private string _subjectName;
        private int _hours;
        private bool _credit;

        public string SubjectName { get; set; }
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (_hours < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _hours), "hours");

                _hours = value;
            }
        }
        public bool Credit { get; set; }
    }
}
