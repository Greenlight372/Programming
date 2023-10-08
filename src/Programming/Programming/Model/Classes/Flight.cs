using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о полетах самолетов.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета.
        /// </summary>
        private int _flightTime;

        /// <summary>
        /// Возвращает и задает место отправки.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задает время полета.
        /// Должно быть положительным.
        /// </summary>
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
