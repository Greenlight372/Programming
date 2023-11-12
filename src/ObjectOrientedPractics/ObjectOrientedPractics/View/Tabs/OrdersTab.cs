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
        /// Выбранный экземпляр заказа.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Выбранный экземпляр заказа с
        /// приоритетным обслуживанием.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

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

                _selectedOrder = _orders[ordersDataGridView.CurrentRow.Index];

                var orderType = _orders[ordersDataGridView.CurrentRow.Index].GetType();
                if (orderType == typeof(PriorityOrder))
                {
                    _selectedPriorityOrder = (PriorityOrder)_orders[ordersDataGridView.CurrentRow.Index];
                    deliveryTimeComboBox.SelectedIndex = Convert.ToInt32(_selectedPriorityOrder.DeliveryTime);
                    itemsListBox.Items.Clear();
                    itemsListBox.Items.AddRange(_selectedPriorityOrder.Items.ToArray());
                    priorityOptionsPanel.Visible = true;
                    priorityOptionsPanel.Enabled = true;
                }
                else
                {
                    _selectedPriorityOrder = null;
                    itemsListBox.Items.Clear();
                    itemsListBox.Items.AddRange(_selectedOrder.Items.ToArray());
                    priorityOptionsPanel.Visible = false;
                    priorityOptionsPanel.Enabled = false;
                }

                idTextBox.Text = _selectedOrder.GetId.ToString();
                createdTextBox.Text = _selectedOrder.GetDate.ToString();
                money.Text = String.Format("{0:0.00}",
                    _selectedOrder.Amount.ToString());
                addressControl.Address = _selectedOrder.Address;
                statusComboBox.Text = _selectedOrder.Status.ToString();
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
                priorityOptionsPanel.Visible = false;
                priorityOptionsPanel.Enabled = false;
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
                var orderType = _orders[ordersDataGridView.CurrentRow.Index].GetType();
                if (orderType == typeof(PriorityOrder))
                {
                    _selectedPriorityOrder.Status
                        = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.SelectedItem.ToString());
                    _orders[ordersDataGridView.CurrentRow.Index] = _selectedPriorityOrder;
                }
                else
                {
                    _selectedOrder.Status
                        = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusComboBox.SelectedItem.ToString());
                    _orders[ordersDataGridView.CurrentRow.Index] = _selectedOrder;
                }

                ordersDataGridView[2, ordersDataGridView.CurrentRow.Index].Value
                    = Enum.GetName(_orders[ordersDataGridView.CurrentRow.Index].Status);
            }
        }

        /// <summary>
        /// Задает время заказа для заказа
        /// с приоритетным обслуживанием.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.CurrentRow != null && _orders.Count() > 0)
            {
                _selectedPriorityOrder.DeliveryTime = (DeliveryTime)deliveryTimeComboBox.SelectedIndex;
                _orders[ordersDataGridView.CurrentRow.Index] = _selectedPriorityOrder;
            }
        }
    }
}
