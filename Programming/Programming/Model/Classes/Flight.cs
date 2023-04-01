using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private int _flightTime;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTime
        {
            get => _flightTime;
            set
            {
                Validator.AssertOnPositiveValue(value, "FlightTime");
                _flightTime = value;
            }
        }
    }
}
