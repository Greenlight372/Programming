using ObjectOrientedPractics.Model;
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
            discountsCheckedListBox.DisplayMember = "Info";
        }

        /// <summary>
        /// Событие, срабатывающее при изменении корзины.
        /// </summary>
        public event EventHandler<EventArgs> CartsChanged;

        /// <summary>
        /// Выбор покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
            discountsCheckedListBox.Items.Clear();
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

                discountsCheckedListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Discounts.ToArray());
                for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                {
                    discountsCheckedListBox.SetItemChecked(i, true);
                }

                if (_carts[customerComboBox.SelectedIndex].Items != null)
                {
                    cartListBox.Items.AddRange
                        (_carts[customerComboBox.SelectedIndex].Items.ToArray());

                    money.Text = String.Format("{0:0.00}",
                        _carts[customerComboBox.SelectedIndex].Amount);

                    double dAmount = 0;
                    for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                    {
                        for (int j = 0; j < discountsCheckedListBox.CheckedItems.Count; j++)
                        {
                            if (discountsCheckedListBox.Items[i] == discountsCheckedListBox.CheckedItems[j])
                            {
                                dAmount
                                    += Customers[customerComboBox.SelectedIndex].Discounts[i]
                                    .Calculate(_carts[customerComboBox.SelectedIndex].Items);
                            }
                        }
                    }

                    discountAmount.Text = dAmount.ToString();
                    totalAmount.Text = String.Format("{0:0.00}",
                        (Convert.ToDouble(money.Text) - dAmount));
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
                        _carts[customerComboBox.SelectedIndex].Amount);

                    double dAmount = 0;
                    for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                    {
                        for (int j = 0; j < discountsCheckedListBox.CheckedItems.Count; j++)
                        {
                            if (discountsCheckedListBox.Items[i] == discountsCheckedListBox.CheckedItems[j])
                            {
                                dAmount
                                    += Customers[customerComboBox.SelectedIndex].Discounts[i]
                                    .Calculate(_carts[customerComboBox.SelectedIndex].Items);
                            }
                        }
                    }

                    discountAmount.Text = dAmount.ToString();
                    totalAmount.Text = String.Format("{0:0.00}",
                        (Convert.ToDouble(money.Text) - dAmount));
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
                        _carts[customerComboBox.SelectedIndex].Amount);

                    double dAmount = 0;
                    for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                    {
                        for (int j = 0; j < discountsCheckedListBox.CheckedItems.Count; j++)
                        {
                            if (discountsCheckedListBox.Items[i] == discountsCheckedListBox.CheckedItems[j])
                            {
                                dAmount
                                    += Customers[customerComboBox.SelectedIndex].Discounts[i]
                                    .Calculate(_carts[customerComboBox.SelectedIndex].Items);
                            }
                        }
                    }

                    discountAmount.Text = dAmount.ToString();
                    totalAmount.Text = String.Format("{0:0.00}",
                        (Convert.ToDouble(money.Text) - dAmount));
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
                        _carts[customerComboBox.SelectedIndex].Amount);

                    discountAmount.Text = "0";
                    totalAmount.Text = "0";

                    discountsCheckedListBox.SelectedIndex = -1;
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

                if (Customers[customerComboBox.SelectedIndex].IsPriority == true)
                {
                    Customers[customerComboBox.SelectedIndex].Order.Add(new PriorityOrder
                    (
                        Customers[customerComboBox.SelectedIndex].Address,
                        Customers[customerComboBox.SelectedIndex].Fullname,
                        items,
                        Convert.ToDouble(discountAmount.Text),
                        DateTime.Now,
                        DeliveryTime.NineToEleven
                    ));
                }
                else
                {
                    Customers[customerComboBox.SelectedIndex].Order.Add(new Order
                    (
                        Customers[customerComboBox.SelectedIndex].Address,
                        Customers[customerComboBox.SelectedIndex].Fullname,
                        items,
                        Convert.ToDouble(discountAmount.Text)
                    ));
                }

                Customers[customerComboBox.SelectedIndex].Cart.Items.Clear();
                cartListBox.Items.Clear();
                discountAmount.Text = "0";
                totalAmount.Text = "0";
                money.Text = "0";

                for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
                {
                    for (int j = 0; j < discountsCheckedListBox.CheckedItems.Count; j++)
                    {
                        if (discountsCheckedListBox.Items[i] == discountsCheckedListBox.CheckedItems[j])
                        {
                            Customers[customerComboBox.SelectedIndex].Discounts[i].Apply(items);
                        }
                    }
                }

                for (int i = 0;
                    i < Customers[customerComboBox.SelectedIndex].Discounts.Count; i++)
                {
                    Customers[customerComboBox.SelectedIndex].Discounts[i].Update(items);
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

                discountsCheckedListBox.Items.Clear();
                discountsCheckedListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Discounts.ToArray());

                Customers[customerComboBox.SelectedIndex].Cart
                    = _carts[customerComboBox.SelectedIndex];

                CartsChanged?.Invoke(this, new EventArgs());
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

                discountsCheckedListBox.Items.Clear();
                customerComboBox.Items.Clear();
                customerComboBox.Items.AddRange(Customers.ToArray());
                discountsCheckedListBox.Items.Clear();
            }

            discountAmount.Text = "0";
            totalAmount.Text = "0";
            money.Text = "0";
        }

        /// <summary>
        /// Вычисляет общий размер скидки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double dAmount = 0;
            for (int i = 0; i < discountsCheckedListBox.Items.Count; i++)
            {
                for (int j = 0; j < discountsCheckedListBox.CheckedItems.Count; j++)
                {
                    if (discountsCheckedListBox.Items[i] == discountsCheckedListBox.CheckedItems[j])
                    {
                        dAmount
                            += Customers[customerComboBox.SelectedIndex].Discounts[i]
                            .Calculate(_carts[customerComboBox.SelectedIndex].Items);
                    }
                }
            }

            discountAmount.Text = dAmount.ToString();
            totalAmount.Text = String.Format("{0:0.00}",
                (Convert.ToDouble(money.Text) - dAmount));
        }
    }
}