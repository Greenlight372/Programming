using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
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
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Customer"></see>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Индекс выбранного объекта в списке.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            fullnameTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = false;
            fullnameTextBox.Enabled = false;
            customerAddressControl.Enabled = false;

            customersListBox.DisplayMember = "Fullname";
        }

        /// <summary>
        /// Выводит информацию о выбранном объекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTextBox.Text = _customers[customersListBox.SelectedIndex].GetId.ToString();
            fullnameTextBox.Text = _customers[customersListBox.SelectedIndex].Fullname;
            customerAddressControl.AddressProperty = _customers[customersListBox.SelectedIndex].CustomerAddress;

            fullnameTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = true;
            fullnameTextBox.Enabled = true;
            customerAddressControl.Enabled = true;
        }

        /// <summary>
        /// Добавляет новый объект в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer("Иванов И. И.", new Address("001234", "Aussie", "Sydnry", "Grove Street, Home", "123", "123")));
            customersListBox.Items.Clear();
            customersListBox.Items.AddRange(_customers.ToArray());

            idTextBox.Text = "";
            fullnameTextBox.Text = "";
            customerAddressControl.AddressProperty = new Address();

            fullnameTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = false;
            fullnameTextBox.Enabled = false;
            customerAddressControl.Enabled = false;
        }

        /// <summary>
        /// Удаляет выбранный объект из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex > -1)
            {
                _customers.RemoveAt(customersListBox.SelectedIndex);
                customersListBox.Items.Clear();
                customersListBox.Items.AddRange(_customers.ToArray());

                idTextBox.Text = "";
                fullnameTextBox.Text = "";
                customerAddressControl.AddressProperty = new Address();

                fullnameTextBox.BackColor = System.Drawing.Color.White;

                idTextBox.Enabled = false;
                fullnameTextBox.Enabled = false;
                customerAddressControl.Enabled = false;
            }
        }

        /// <summary>
        /// Вносит изменения в ФИО выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedIndex = customersListBox.SelectedIndex;
                _customers[customersListBox.SelectedIndex].Fullname = fullnameTextBox.Text;
                fullnameTextBox.BackColor = System.Drawing.Color.White;
                customersListBox.Items.Clear();
                customersListBox.Items.AddRange(_customers.ToArray());
                customersListBox.SelectedIndex = _selectedIndex;
            }
            catch
            {
                fullnameTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
