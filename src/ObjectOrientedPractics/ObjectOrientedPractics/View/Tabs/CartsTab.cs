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
        /// Список корзин покупателей.
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
                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                        _carts[i].Items
                            = new List<Item>();
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                        _carts[i].Items
                            = Customers[i].Cart.Items;
                    }
                }

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];
                if (_carts[customerComboBox.SelectedIndex].Items != null)
                {
                    cartListBox.Items.AddRange
                        (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                    money.Text = String.Format("{0:0.00}",
                        _carts[customerComboBox.SelectedIndex].Amount.ToString());
                }
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
                _carts[customerComboBox.SelectedIndex].Items
                    .Add(Items[itemsListBox.SelectedIndex]);

                cartListBox.Items.Clear();
                if (_carts[customerComboBox.SelectedIndex].Items != null)
                {
                    cartListBox.Items.AddRange
                        (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                    money.Text = String.Format("{0:0.00}",
                        _carts[customerComboBox.SelectedIndex].Amount.ToString());
                }

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                    }

                    if (_carts[i].Items == null)
                    {
                        _carts[i].Items = new List<Item>();
                    }
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
                _carts[customerComboBox.SelectedIndex].Items.RemoveAt
                    (cartListBox.SelectedIndex);

                cartListBox.Items.Clear();
                if (_carts[customerComboBox.SelectedIndex].Items != null)
                {
                    cartListBox.Items.AddRange
                        (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                    money.Text = String.Format("{0:0.00}",
                        _carts[customerComboBox.SelectedIndex].Amount.ToString());
                }

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                        _carts[i].Items
                            = new List<Item>();
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                    }

                    if (_carts[i].Items == null)
                    {
                        _carts[i].Items = new List<Item>();
                    }
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
                _carts[customerComboBox.SelectedIndex].Items.Clear();
                if (_carts[customerComboBox.SelectedIndex].Items != null)
                {
                    cartListBox.Items.AddRange
                        (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                    money.Text = String.Format("{0:0.00}",
                        _carts[customerComboBox.SelectedIndex].Amount.ToString());
                }

                _carts.Clear();
                for (int i = 0; i < Customers.Count(); i++)
                {
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                        _carts[i].Items
                            = new List<Item>();
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                    }

                    if (_carts[i].Items == null)
                    {
                        _carts[i].Items = new List<Item>();
                    }
                }

                cartListBox.Items.Clear();

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
                items.AddRange(_carts[customerComboBox.SelectedIndex].Items);

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
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                        _carts[i].Items
                            = new List<Item>();
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                    }

                    if (_carts[i].Items == null)
                    {
                        _carts[i].Items = new List<Item>();
                    }
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
                    if (Customers[i].Cart == null)
                    {
                        _carts.Add(new Cart());
                        _carts[i].Items
                            = new List<Item>();
                    }
                    else
                    {
                        _carts.Add(Customers[i].Cart);
                    }

                    if (_carts[i].Items == null)
                    {
                        _carts[i].Items = new List<Item>();
                    }
                }

                customerComboBox.Items.Clear();
                customerComboBox.Items.AddRange(Customers.ToArray());
            }

            money.Text = "0";
        }
    }
}