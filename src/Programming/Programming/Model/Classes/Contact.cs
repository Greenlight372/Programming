using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактах.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию. Должно состоять только из букв.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона.
        /// </summary>
        public double PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает адрес электронной почты.
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// Проверяет строку на наличие символов, отличных от букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetterOrDigit(c) || c != ' ')
                    throw new ArgumentException($"Неверный символ {c}.");
            }
        }
    }
}
