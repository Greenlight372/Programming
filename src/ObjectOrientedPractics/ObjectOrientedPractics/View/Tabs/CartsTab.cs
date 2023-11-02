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
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private List<Cart> _carts = new List<Cart>();

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            itemsListBox.DisplayMember = "Name";
            customerComboBox.DisplayMember = "Fullname";
            cartListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Выбор покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
            if (customerComboBox.SelectedItem != null)
            {
                if (Customers[customerComboBox.SelectedIndex].Cart.Items == null)
                {
                    Customers[customerComboBox.SelectedIndex].Cart.Items = new List<Item>();
                }

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
                cartListBox.Items.AddRange
                    (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                money.Text = String.Format("{0:0.00}",
                    Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString());
            }
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1 && customerComboBox.SelectedIndex != -1)
            {
                Customers[customerComboBox.SelectedIndex].Cart.Items.Add(Items[itemsListBox.SelectedIndex]);

                cartListBox.Items.Clear();
                cartListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Cart.Items.ToArray());

                money.Text = String.Format("{0:0.00}",
                    Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString());

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
            }
        }

        /// <summary>
        /// Удаляет выбранный в корзине товар из нее.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (cartListBox.SelectedIndex != -1)
            {
                Customers[customerComboBox.SelectedIndex].Cart.Items.RemoveAt
                    (cartListBox.SelectedIndex);

                cartListBox.Items.Clear();
                cartListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Cart.Items.ToArray());

                money.Text = String.Format("{0:0.00}",
                    Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString());

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
            }
        }

        /// <summary>
        /// Очищает корзину покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedItem != null)
            {
                Customers[customerComboBox.SelectedIndex].Cart.Items.Clear();
                cartListBox.Items.Clear();

                money.Text = String.Format("{0:0.00}",
                    Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString());

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
            }
        }

        /// <summary>
        /// Создает заказ покупателя и очищает
        /// содержимое корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            if (customerComboBox.SelectedIndex != -1
                && Customers[customerComboBox.SelectedIndex].Cart.Items.Count() != 0)
            {
                List<Item> items = new List<Item>();
                items.AddRange(Customers[customerComboBox.SelectedIndex].Cart.Items);

                Customers[customerComboBox.SelectedIndex].Order.Add(new Order
                (
                    Customers[customerComboBox.SelectedIndex].Address,
                    Customers[customerComboBox.SelectedIndex].Fullname,
                    items
                ));

                Customers[customerComboBox.SelectedIndex].Cart.Items.Clear();
                cartListBox.Items.Clear();
                money.Text = "0";

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
            }
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            customerComboBox.SelectedIndex = -1;
            if (Items != null)
            {
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(Items.ToArray());
            }

            if (Customers != null)
            {
                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    _carts.Add(Customers[i].Cart);
                }

                customerComboBox.Items.Clear();
                customerComboBox.Items.AddRange(Customers.ToArray());
            }

            money.Text = "0";
        }
    }
}