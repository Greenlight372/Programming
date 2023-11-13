using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Список товаров для заказа.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Свойство для редактирования и доступа к
        /// Списку объектов класса <see cref="Item"></see>.
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
        /// Экземпляр заказа.
        /// </summary>
        private PriorityOrder _order = new PriorityOrder();

        /// <summary>
        /// Выбранный индекс в списке товаров.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            idTextBox.Text = _order.GetId.ToString();
            createdTextBox.Text = _order.GetDate.ToString();
            statusComboBox.Text = _order.Status.ToString();
            addressControl.Address = _order.Address;
            deliveryTimeComboBox.SelectedIndex = Convert.ToInt32(_order.DeliveryTime);

            orderItemsListBox.DisplayMember = "Name";
            statusComboBox.DataSource = Enum.GetNames(typeof(OrderStatus));
        }

        /// <summary>
        /// Добавляет случайный товар в
        /// список товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            _order.Items.Add(_items[rand.Next(_items.Count())]);

            orderItemsListBox.Items.Clear();
            for (int i = 0; i < _order.Items.Count(); i++)
            {
                orderItemsListBox.Items.Add(_order.Items[i]);
            }

            money.Text = _order.Amount.ToString();
        }

        /// <summary>
        /// Удаляет выбранный товар из списка товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (orderItemsListBox.SelectedIndex != -1)
            {
                _selectedIndex = orderItemsListBox.SelectedIndex;
                _order.Items.RemoveAt(_selectedIndex);

                orderItemsListBox.Items.Clear();
                for (int i = 0; i < _order.Items.Count(); i++)
                {
                    orderItemsListBox.Items.Add(_order.Items[i]);
                }

                if (orderItemsListBox.Items.Count > 0)
                {
                    if (_selectedIndex < orderItemsListBox.Items.Count)
                    {
                        orderItemsListBox.SelectedIndex = _selectedIndex;
                    }
                    else
                    {
                        orderItemsListBox.SelectedIndex = _selectedIndex - 1;
                    }
                }

                money.Text = _order.Amount.ToString();
            }
        }

        /// <summary>
        /// Удаляет весь заказ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (_order.Items.Count() != 0)
            {
                _order.Items.Clear();
                orderItemsListBox.Items.Clear();
                _order = new PriorityOrder();

                idTextBox.Text = _order.GetId.ToString();
                createdTextBox.Text = _order.GetDate.ToString();
                statusComboBox.Text = _order.Status.ToString();
                deliveryTimeComboBox.SelectedIndex = Convert.ToInt32(_order.DeliveryTime);
                addressControl.Address = _order.Address;
                orderItemsListBox.Items.Clear();
                money.Text = "0";
            }
        }

        /// <summary>
        /// Присваивает статус заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)statusComboBox.SelectedIndex;
        }

        /// <summary>
        /// Присваивает время доставки заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.DeliveryTime = (DeliveryTime)deliveryTimeComboBox.SelectedIndex;
        }

        /// <summary>
        /// Присваивает данные об адресе доставки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressControl_Enter(object sender, EventArgs e)
        {
            if (addressControl.GetExceptionThrown == false)
            {
                addressControl.Address = _order.Address;
            }
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            orderItemsListBox.Items.Clear();
            for (int i = 0; i < _order.Items.Count(); i++)
            {
                orderItemsListBox.Items.Add(_order.Items[i]);
            }

            money.Text = _order.Amount.ToString();
        }
    }
}
