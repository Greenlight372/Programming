using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Forms;
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
        private List<Customer> _customers;
        /// <summary>
        /// Индекс выбранного объекта в списке.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Значение, указывающее на то, происходит ли редактирование.
        /// </summary>
        private bool _isEdited = false;
        /// <summary>
        /// Экземпляр класса <see cref="Customer"></see>.
        /// </summary>
        private Customer _customerInstance = new Customer();
        /// <summary>
        /// Свойство для редактирования и доступа к
        /// списку объектов класса <see cref="Customer"></see>.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Определяет, выкинуто ли исключения в программе.
        /// </summary>
        private bool _isExceptionThrown = false;
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            fullnameTextBox.BackColor = System.Drawing.Color.White;

            selectedCustomerBackgroundPanel.Enabled = _isEdited;

            customersListBox.DisplayMember = "Fullname";

            addressControl.Address = new Address();

            discountsListBox.DisplayMember = "Info";
        }

        /// <summary>
        /// Событие, срабатывающее при изменении покупателей.
        /// </summary>
        public event EventHandler<EventArgs> CustomersChanged;

        /// <summary>
        /// Выводит информацию о выбранном объекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex > -1)
            {
                idTextBox.Text = _customers[customersListBox.SelectedIndex].GetId.ToString();
                fullnameTextBox.Text = _customers[customersListBox.SelectedIndex].Fullname;
                addressControl.Address = new Address
                    (
                        _customers[customersListBox.SelectedIndex].Address.Index,
                        _customers[customersListBox.SelectedIndex].Address.Country,
                        _customers[customersListBox.SelectedIndex].Address.City,
                        _customers[customersListBox.SelectedIndex].Address.Street,
                        _customers[customersListBox.SelectedIndex].Address.Building,
                        _customers[customersListBox.SelectedIndex].Address.Apartment
                    );
                isPriorityCheckBox.Checked = _customers[customersListBox.SelectedIndex].IsPriority;

                fullnameTextBox.BackColor = System.Drawing.Color.White;

                discountsListBox.Items.Clear();
                foreach
                    (IDiscount discount in _customers[customersListBox.SelectedIndex].Discounts)
                {
                    discountsListBox.Items.Add(discount);
                }
            }
        }

        /// <summary>
        /// Добавляет новый объект в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer("Иванов И. И."));
            customersListBox.Items.Clear();
            customersListBox.Items.AddRange(_customers.ToArray());

            idTextBox.Text = "";
            fullnameTextBox.Text = "";
            addressControl.Address = new Address();
            isPriorityCheckBox.Checked = false;
            discountsListBox.Items.Clear();

            fullnameTextBox.BackColor = System.Drawing.Color.White;

            CustomersChanged?.Invoke(this, new EventArgs());
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
                addressControl.Address = new Address();
                isPriorityCheckBox.Checked = false;
                discountsListBox.Items.Clear();

                fullnameTextBox.BackColor = System.Drawing.Color.White;

                CustomersChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Вносит изменения в ФИО выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEdited == true)
            {
                try
                {
                    _customerInstance.Fullname = fullnameTextBox.Text;
                    fullnameTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    fullnameTextBox.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        /// <summary>
        /// Позволяет редактировать параметры выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex != -1)
            {
                _selectedIndex = customersListBox.SelectedIndex;
                _customerInstance = new Customer();
                _customerInstance.Discounts.Clear();
                foreach (IDiscount discount in _customers[_selectedIndex].Discounts)
                {
                    _customerInstance.Discounts.Add(discount);
                }
                _isEdited = true;

                addressControl.Enabled = _isEdited;
                idTextBox.Enabled = _isEdited;
                selectedCustomerBackgroundPanel.Enabled = _isEdited;
                itemsPanel.Enabled = !_isEdited;
            }
        }

        /// <summary>
        /// Сохраняет внесенные изменения для выбранного покупателя
        /// и выходит из меню редактирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (_isExceptionThrown == false
                && fullnameTextBox.BackColor != System.Drawing.Color.Red)
            {
                _isEdited = false;

                if (_customerInstance.Fullname != null)
                    _customers[_selectedIndex].Fullname
                        = _customerInstance.Fullname;

                _customers[_selectedIndex].IsPriority = _customerInstance.IsPriority;
                _customers[_selectedIndex].Discounts = _customerInstance.Discounts;
                _customers[_selectedIndex].Address
                    = new Address
                    (
                         addressControl.Address.Index,
                         addressControl.Address.Country,
                         addressControl.Address.City,
                         addressControl.Address.Street,
                         addressControl.Address.Building,
                         addressControl.Address.Apartment
                    );
                addressControl.Address = _customers[customersListBox.SelectedIndex].Address;

                customersListBox.Items.Clear();
                customersListBox.Items.AddRange(_customers.ToArray());

                customersListBox.SelectedIndex = _selectedIndex;

                addressControl.Enabled = _isEdited;
                idTextBox.Enabled = _isEdited;
                selectedCustomerBackgroundPanel.Enabled = _isEdited;
                itemsPanel.Enabled = !_isEdited;

                discountsListBox.Items.Clear();
                discountsListBox.Items.AddRange(_customers[_selectedIndex].Discounts.ToArray());

                CustomersChanged?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Введены неверные значения!");
            }
        }

        /// <summary>
        /// Отменяет внесенные изменения для выбранного
        /// покупателя и выходит из меню редактирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _isEdited = false;

            _isExceptionThrown = false;

            addressControl.Address
                = new Address
                (
                    _customers[_selectedIndex].Address.Index,
                    _customers[_selectedIndex].Address.Country,
                    _customers[_selectedIndex].Address.City,
                    _customers[_selectedIndex].Address.Street,
                    _customers[_selectedIndex].Address.Building,
                    _customers[_selectedIndex].Address.Apartment
                );
            isPriorityCheckBox.Checked = _customers[_selectedIndex].IsPriority;
            fullnameTextBox.Text = _customers[_selectedIndex].Fullname;
            idTextBox.Text
                = _customers[_selectedIndex].GetId.ToString();

            customersListBox.Items.Clear();
            customersListBox.Items.AddRange(_customers.ToArray());

            customersListBox.SelectedIndex = _selectedIndex;

            addressControl.Enabled = _isEdited;
            idTextBox.Enabled = _isEdited;
            selectedCustomerBackgroundPanel.Enabled = _isEdited;
            itemsPanel.Enabled = !_isEdited;

            discountsListBox.Items.Clear();
            discountsListBox.Items.AddRange(_customers[_selectedIndex].Discounts.ToArray());
        }

        /// <summary>
        /// Проверяет наличие исключений на пользовательском
        /// элементе управления <see cref="addressControl"></see>
        /// после выхода из него.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressControl_Leave(object sender, EventArgs e)
        {
            _isExceptionThrown = addressControl.GetExceptionThrown;
        }

        /// <summary>
        /// Проверяет наличие исключений на пользовательском
        /// элементе управления <see cref="addressControl"></see>
        /// после его активации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressControl_Enter(object sender, EventArgs e)
        {
            _isExceptionThrown = addressControl.GetExceptionThrown;
        }

        /// <summary>
        /// Определяет, является ли покупатель приоритетным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void isPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex != -1)
            {
                _customerInstance.IsPriority = isPriorityCheckBox.Checked;
            }
        }

        /// <summary>
        /// Добавляет процентную скидку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm form = new AddDiscountForm();
            form.ShowDialog();
            if (form.IsAborted == false)
            {
                _customerInstance.Discounts.Add
                    (new PercentDiscount(form.Category));

                discountsListBox.Items.Clear();
                foreach
                    (IDiscount discount in _customerInstance.Discounts)
                {
                    discountsListBox.Items.Add(discount);
                }
            }
        }

        /// <summary>
        /// Удаляет выбранную скидку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if (discountsListBox.SelectedIndex > 0)
            {
                _customerInstance.Discounts.RemoveAt(discountsListBox.SelectedIndex);
                discountsListBox.Items.Clear();
                foreach
                    (IDiscount discount in _customerInstance.Discounts)
                {
                    discountsListBox.Items.Add(discount);
                }
            }
        }
    }
}