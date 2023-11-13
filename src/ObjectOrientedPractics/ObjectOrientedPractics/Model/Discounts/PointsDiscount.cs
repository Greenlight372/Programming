using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс, описывающий накопительную скидку.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Баллы
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает количество баллов.
        /// </summary>
        public int GetPoints { get => _points; }

        /// <summary>
        /// Информация о скидке.
        /// </summary>
        public string Info { get => $"Накопительная - {GetPoints} баллов"; }

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
                sum += item.Cost;
            }

            if (_points >= sum * 0.3)
            {
                sum = sum * 0.3;
            }
            else
            {
                sum = _points;
            }

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
                sum += item.Cost;
            }

            if (_points >= Convert.ToInt32(sum * 0.3))
            {
                sum -= Convert.ToInt32(sum * 0.3);
                _points -= Convert.ToInt32(sum * 0.3);
            }
            else
            {
                sum -= _points;
                _points = 0;
            }

            return sum;
        }

        /// <summary>
        /// Обновляет информацию о скидке.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }

            _points += Convert.ToInt32(Math.Ceiling(sum * 0.1));
        }

        /// <summary>
        /// Создает экземпляр накопительной скидки.
        /// </summary>
        public PointsDiscount()
        {
            _points = 0;
        }
    }
}
