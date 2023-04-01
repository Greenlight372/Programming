using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                _hours = value;
                Validator.AssertValueInRange(_hours, 0, 23);
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                _minutes = value;
                Validator.AssertValueInRange(_minutes, 0, 60);
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                _seconds = value;
                Validator.AssertValueInRange(_seconds, 0, 60);
            }
        }
    }
}
