using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий магазин.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список предметов.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Получает и заполняет список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }
        /// <summary>
        /// Получает и заполняет список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }
        /// <summary>
        /// Конструктор по умолчанию класса <see cref="Store"></see>.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
