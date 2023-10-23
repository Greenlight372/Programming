using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий заказ покупателя.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Счетчик.
        /// </summary>
        static private int _idCounter = 0;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров для заказа.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int GetId { get => _id; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public DateTime GetDate { get => _date; }

        /// <summary>
        /// Возвращает и заполняет адрес заказа.
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
        /// Возвращает и заполняет список товаров
        /// для заказа.
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
        /// Вычисляет общую стоимость товаров в корзине. 
        /// </summary>
        public double Amount
        {
            get
            {
                double sum = 0.0;
                if (Items == null || Items.Count == 0)
                {
                    return sum;
                }

                for (int i = 0; i < Items.Count; i++)
                {
                    sum += Items[i].Cost;
                }
                return sum;
            }
        }

        /// <summary>
        /// Создает объект класса <see cref="Order"></see>.
        /// </summary>
        public Order()
        {
            _id = _idCounter++;
            _date = DateTime.Now;
            Address = new Address();
            Items = new List<Item>();
        }
    }
}
