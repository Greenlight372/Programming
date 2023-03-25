﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
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
                if (_hours < 0 || _hours > 23)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Hours));

                _hours = value;
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
                if (_minutes < 0 || _minutes > 60)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Minutes));

                _minutes = value;
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
                if (_seconds < 0 || _seconds > 60)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Seconds));

                _seconds = value;
            }
        }
    }
}
