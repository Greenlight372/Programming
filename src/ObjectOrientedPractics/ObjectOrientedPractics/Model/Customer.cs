using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий покупателя.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Счетчик.
        /// </summary>
        static private int _idCounter = 0;
        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        readonly int _id;
        /// <summary>
        /// Фамилия имя отчество покупателя.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Получает уникальный идентификатор покупателя.
        /// </summary>
        public int GetId { get => _id; }

        /// <summary>
        /// Получает и заполняет ФИО покупателя.
        /// </summary>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Получает и заполняет адрес доставки для покупателя.
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Customer"></see>.
        /// </summary>
        /// <param name="fullname">ФИО покупателя.</param>
        /// <param name="address">Адрес доставки покупателя.</param>
        public Customer(string fullname, string address)
        {
            _id = _idCounter++;
            Fullname = fullname;
            Address = address;
        }
    }
}
