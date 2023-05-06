using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песнях.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Количество минут в песне.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд в песне.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает количество минут в песне.
        /// Должно быть в диапазоне от 0 до 59.
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
        /// Возвращает и задает количество секунд в песне.
        /// Должно быть в диапазоне от 0 до 59.
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

        /// <summary>
        /// Возвращает и задает имя композитора песни.
        /// </summary>
        public string Composer { get; set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }
    }
}
