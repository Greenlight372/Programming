using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public List<Customer> Customers { get; set; }

        private List<Order> _orders = new List<Order>();

        public OrdersTab()
        {
            InitializeComponent();
        }

        public void UpdateOrders()
        {
            _orders.Clear();
            for (int i = 0; i < Customers.Count(); i++)
            {
                if (Customers[i].Order != null)
                {
                    _orders.AddRange(Customers[i].Order);
                }
            }

            ordersDataGridView.Rows.Clear();
            for (int i = 0; i < _orders.Count(); i++)
            {
                ordersDataGridView.Rows.Add
                    (
                        _orders[i].GetId,
                        _orders[i].GetDate,
                        " ",
                        _orders[i].GetFullname,
                        _orders[i].Amount(),
                        $"{_orders[i].Address.Apartment}" +
                        $" {_orders[i].Address.Building}" +
                        $" {_orders[i].Address.Street}" +
                        $" {_orders[i].Address.City}" +
                        $" {_orders[i].Address.Country}"
                    );
            }
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            if (Customers != null)
            {
            }
        }
    }
}
