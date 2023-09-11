using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс для валидации значений.
    /// </summary>
    static public class ValueValidator
    {
        /// <summary>
        /// Проводит валидацию строки.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная допустимая длина строки.</param>
        /// <param name="propertyName">Название проверяемого свойства.</param>
        /// <exception cref="ArgumentException"></exception>
        static public void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов.");
        }
    }
}
