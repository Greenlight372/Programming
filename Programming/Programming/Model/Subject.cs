using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Subject
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
                    throw new ArgumentException($"{0} is not a positive number", nameof(Hours));

                _hours = value;
            }
        }
        public bool Credit { get; set; }
    }
}
