using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
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
        private Address _address = new Address();

        /// <summary>
        /// Корзина с товарами покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _order;

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
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Получает и заполняет корзину покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Получает и заполняет список заказов покупателя.
        /// </summary>
        public List<Order> Order
        {
            get => _order;
            set
            {
                _order = value;
            }
        }

        /// <summary>
        /// Определяет, является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Customer"></see>.
        /// </summary>
        /// <param name="fullname">ФИО покупателя.</param>
        /// <param name="address">Адрес доставки покупателя.</param>
        public Customer(string fullname)
        {
            _id = _idCounter++;
            Fullname = fullname;
            Cart = new Cart();
            Order = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Выделяет память под объекта класса <see cref="Customer"></see>.
        /// </summary>
        public Customer()
        {
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }
    }
}
