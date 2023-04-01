using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTime;

        public string DeparturePoint { get; set; }
        public string Destination { get; set; }
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                _flightTime = value;
                Validator.AssertOnPositiveValue(_flightTime);
            }
        }
    }
}
