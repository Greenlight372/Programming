using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает заказ приоритетного обслуживания.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Дата доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }
        
        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see href="PriorityOrder">
        /// </see>.
        /// </summary>
        /// <param name="address">Адрес покупателя.</param>
        /// <param name="fullname">ФИО покупателя.</param>
        /// <param name="items">Товары в заказе.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        /// <param name="deliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(Address address, string fullname, List<Item> items, 
            DateTime deliveryDate, DeliveryTime deliveryTime)
            : base(address, fullname, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Выделаяет память для экземпляра класса
        /// <see cref="PriorityOrder"></see>.
        /// </summary>
        public PriorityOrder()
        {
        }
    }
}
