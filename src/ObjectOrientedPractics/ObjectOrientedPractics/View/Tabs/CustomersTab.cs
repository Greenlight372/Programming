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
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список объектов класса <see cref="Customer"></see>.
        /// </summary>
        private List<Customer> _customers = new();
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
            addressTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = false;
            fullnameTextBox.Enabled = false;
            addressTextBox.Enabled = false;

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
            addressTextBox.Text = _customers[customersListBox.SelectedIndex].Address;

            fullnameTextBox.BackColor = System.Drawing.Color.White;
            addressTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = true;
            fullnameTextBox.Enabled = true;
            addressTextBox.Enabled = true;
        }

        /// <summary>
        /// Добавляет новый объект в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer("Иванов И. И.", "Ул. Тверская, дом 89, кв. 199"));
            customersListBox.Items.Clear();
            customersListBox.Items.AddRange(_customers.ToArray());

            idTextBox.Text = "";
            fullnameTextBox.Text = "";
            addressTextBox.Text = "";

            fullnameTextBox.BackColor = System.Drawing.Color.White;
            addressTextBox.BackColor = System.Drawing.Color.White;
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
                addressTextBox.Text = "";

                fullnameTextBox.BackColor = System.Drawing.Color.White;
                addressTextBox.BackColor = System.Drawing.Color.White;

                idTextBox.Enabled = false;
                fullnameTextBox.Enabled = false;
                addressTextBox.Enabled = false;
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

        /// <summary>
        /// Вносит изменения в адрес выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _customers[customersListBox.SelectedIndex].Address = addressTextBox.Text;
                addressTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                addressTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
