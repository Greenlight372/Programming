using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о дисциплинах в образовательном учреждении.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Сколько часов отводится на дисциплину.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Задает и возвращает название дисциплины.
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// Задает и возвращает время, отведенное на дисциплину в часах.
        /// Должно быть положительным.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertOnPositiveValue(value, "Hours");
                _hours = value;
            }
        }

        /// <summary>
        /// Задает и возвращает оценку за дисциплину.
        /// </summary>
        public bool Credit { get; set; }
    }
}
