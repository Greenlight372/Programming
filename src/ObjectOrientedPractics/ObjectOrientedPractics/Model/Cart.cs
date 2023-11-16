using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий корзину товаров покупателя.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items;

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
        /// Создает объект класса <see cref="Cart"></see>.
        /// </summary>
        public Cart(List<Item> items)
        {
            _items = items;
        }

        /// <inheritdoc cref="Cart.Cart" />
        public Cart()
        {
        }

        /// <inheritdoc />
        public object Clone()
        {
            return new Cart(this.Items);
        }
    }
}
