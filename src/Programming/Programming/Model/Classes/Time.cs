﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;
        
        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;
        
        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы. Должны быть в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertValueInRange(value, 0, 23, "Hours");
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Minutes");
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды. Должны быть в диапазоне от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(value, 0, 59, "Seconds");
                _seconds = value;
            }
        }
    }
}
