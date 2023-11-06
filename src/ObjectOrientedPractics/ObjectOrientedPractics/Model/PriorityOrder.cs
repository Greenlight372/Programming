using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public DateTime DeliveryDate { get; set; }
        
        public DeliveryTime DeliveryTime { get; set; }

        public PriorityOrder(Address address, string fullname, List<Item> items, 
            DateTime deliveryDate, DeliveryTime deliveryTime)
            : base(address, fullname, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder()
        {
        }
    }
}
