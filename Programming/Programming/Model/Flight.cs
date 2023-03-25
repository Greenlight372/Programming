using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
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
                if (_flightTime < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _flightTime), "flightTime");

                _flightTime = value;
            }
        }
    }
}
