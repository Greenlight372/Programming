using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using Windows.Devices.Geolocation;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, описывающий процентную скидку.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Категория товаров, к которой
        /// применяется скидка.
        /// </summary>
        private Category _category;

        /// <summary>
        /// Процент скидки.
        /// </summary>
        private int _discount;

        /// <summary>
        /// Суммарная стоимость товаров.
        /// </summary>
        private double _sum;

        /// <summary>
        /// Информация о скидке.
        /// </summary>
        public string Info { get => $"{_category} - {_discount}%"; }

        /// <summary>
        /// Производит рассчет скидки для
        /// списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Скидка.</returns>
        public double Calculate(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                if (item.Category == _category)
                {
                    sum += item.Cost;
                }
            }

            sum = sum * _discount / 100;

            return sum;
        }

        /// <summary>
        /// Применяет скидку для товаров
        /// и списывает накопленные проценты.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Скидка.</returns>
        public double Apply(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                if (item.Category == _category)
                {
                    sum += item.Cost;
                }
            }

            if (sum > 0)
            {
                sum -= sum * _discount / 100;
                _discount = 0;
            }

            return sum;
        }

        /// <summary>
        /// Обновляет информацию о скидке.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == _category)
                {
                    _sum += item.Cost;
                }
            }

            if (_sum >= 1000 && _discount < 10)
            {
                _sum -= 1000;
                _discount += 1;
            }
        }

        /// <summary>
        /// Создает экземпляр процентной скидки.
        /// </summary>
        /// <param name="category">Категория товаров, для
        /// которой применяется скидка.</param>
        public PercentDiscount(Category category)
        {
            _category = category;
            _discount = 1;
            _sum = 0;
        }
    }
}
