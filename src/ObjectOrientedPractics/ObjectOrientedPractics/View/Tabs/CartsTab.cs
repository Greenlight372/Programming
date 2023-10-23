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
        /// Выбранные покупатель.
        /// </summary>
        private Customer _currentCustomer;

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
                cartListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Cart.Items.ToArray());
            }
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                Customers[customerComboBox.SelectedIndex].Cart.Items.Add
                    (Items[itemsListBox.SelectedIndex]);

                cartListBox.Items.Clear();
                cartListBox.Items.AddRange
                    (Customers[customerComboBox.SelectedIndex].Cart.Items.ToArray());

                money.Text = Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString();
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

                money.Text = Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString();
            }
        }

        /// <summary>
        /// Очищает корзину покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            Customers[customerComboBox.SelectedIndex].Cart.Items.Clear();
            cartListBox.Items.Clear();

            money.Text = Customers[customerComboBox.SelectedIndex].Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(Items.ToArray());
            }

            if (Customers != null)
            {
                customerComboBox.Items.Clear();
                customerComboBox.Items.AddRange(Customers.ToArray());
            }
        }
    }
}