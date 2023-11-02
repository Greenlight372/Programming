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
        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            itemsListBox.DisplayMember = "Name";
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            selectedOrderPanel.Enabled = false;
            addressPanel.Enabled = false;
            orderItemsPanel.Enabled = false;
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            _orders.Clear();
            if (Customers != null)
            {
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _orders.AddRange(Customers[i].Order);
                }
            }
        }

        /// <summary>
        /// Обновляет данные о заказах.
        /// </summary>
        public void UpdateOrders()
        {
            if (Customers != null)
            {
                _orders.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _orders.AddRange(Customers[i].Order);
                }

                ordersDataGridView.Rows.Clear();
                for (int i = 0; i < _orders.Count(); i++)
                {
                    ordersDataGridView.Rows.Add
                    (
                        _orders[i].GetId,
                        _orders[i].GetDate,
                        Enum.GetName(_orders[i].Status),
                        _orders[i].GetFullname,
                        _orders[i].Amount,
                        $"{_orders[i].Address.Index}" +
                        $" {_orders[i].Address.Apartment}" +
                        $" {_orders[i].Address.Building}" +
                        $" {_orders[i].Address.Street}" +
                        $" {_orders[i].Address.City}" +
                        $" {_orders[i].Address.Country}"
                    );
                }
            }
        }

        /// <summary>
        /// Выводит информацию о выбранном заказе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_orders.Count() > 0)
            {
                selectedOrderPanel.Enabled = true;
                addressPanel.Enabled = true;
                orderItemsPanel.Enabled = true;

                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_orders[ordersDataGridView.CurrentRow.Index].Items.ToArray());

                idTextBox.Text = _orders[ordersDataGridView.CurrentRow.Index].GetId.ToString();
                createdTextBox.Text = _orders[ordersDataGridView.CurrentRow.Index].GetDate.ToString();
                money.Text = String.Format("{0:0.00}",
                    _orders[ordersDataGridView.CurrentRow.Index].Amount.ToString());
                addressControl.Address = _orders[ordersDataGridView.CurrentRow.Index].Address;
                statusComboBox.Text = _orders[ordersDataGridView.CurrentRow.Index].Status.ToString();
            }
            else
            {
                itemsListBox.Items.Clear();

                idTextBox.Text = "";
                createdTextBox.Text = "";
                money.Text = "0";
                addressControl.Address = new Address();
                statusComboBox.SelectedItem = 0;

                selectedOrderPanel.Enabled = false;
                addressPanel.Enabled = false;
                orderItemsPanel.Enabled = false;
            }
        }

        /// <summary>
        /// Задает статус выбранного заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null && _orders.Count() > 0)
            {
                _orders[ordersDataGridView.CurrentRow.Index].Status
                    = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.SelectedItem.ToString());
                ordersDataGridView[2, ordersDataGridView.CurrentRow.Index].Value
                    = Enum.GetName(_orders[ordersDataGridView.CurrentRow.Index].Status);
            }
        }
    }
}
