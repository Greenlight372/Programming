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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Объект класса <see cref="Address"></see>.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Определяет, выкинуто ли исключения в программе.
        /// </summary>
        private bool _isExceptionThrown = false;

        /// <summary>
        /// Возвращает значение, определяющее,
        /// выкинуто ли исключение в программе.
        /// </summary>
        public bool GetExceptionThrown
        {
            get => _isExceptionThrown;
        }

        /// <summary>
        /// Определяет, являются ли поля доступными
        /// только для чтения.
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Задает и возвращает значение объекта
        /// класса <see cref="Address"></see>.
        /// </summary>
        public Address Address
        {
            get => _address;
            set
            {
                _address = value;

                postIndexTextBox.Text = Address.Index;
                countryTextBox.Text = Address.Country;
                cityTextBox.Text = Address.City;
                streetTextBox.Text = Address.Street;
                buildingTextBox.Text = Address.Building;
                apartmentTextBox.Text = Address.Apartment;
            }
        }

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();

            postIndexTextBox.Text = "000000";
            countryTextBox.Text = "";
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            buildingTextBox.Text = "";
            apartmentTextBox.Text = "";
        }

        /// <summary>
        /// Вносит изменения в почтовый индекс выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Index = postIndexTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (countryTextBox.BackColor != System.Drawing.Color.Red
                    && cityTextBox.BackColor != System.Drawing.Color.Red
                    && streetTextBox.BackColor != System.Drawing.Color.Red
                    && buildingTextBox.BackColor != System.Drawing.Color.Red
                    && apartmentTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                postIndexTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Вносит изменения в страну выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Country = countryTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (postIndexTextBox.BackColor != System.Drawing.Color.Red
                    && cityTextBox.BackColor != System.Drawing.Color.Red
                    && streetTextBox.BackColor != System.Drawing.Color.Red
                    && buildingTextBox.BackColor != System.Drawing.Color.Red
                    && apartmentTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                countryTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Вносит изменения в город выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.City = cityTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (postIndexTextBox.BackColor != System.Drawing.Color.Red
                    && countryTextBox.BackColor != System.Drawing.Color.Red
                    && streetTextBox.BackColor != System.Drawing.Color.Red
                    && buildingTextBox.BackColor != System.Drawing.Color.Red
                    && apartmentTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                cityTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Вносит изменения в улицу выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Street = streetTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (postIndexTextBox.BackColor != System.Drawing.Color.Red
                    && countryTextBox.BackColor != System.Drawing.Color.Red
                    && cityTextBox.BackColor != System.Drawing.Color.Red
                    && buildingTextBox.BackColor != System.Drawing.Color.Red
                    && apartmentTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                streetTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Вносит изменения в 
        /// жилое здание выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Building = buildingTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (postIndexTextBox.BackColor != System.Drawing.Color.Red
                    && countryTextBox.BackColor != System.Drawing.Color.Red
                    && cityTextBox.BackColor != System.Drawing.Color.Red
                    && streetTextBox.BackColor != System.Drawing.Color.Red
                    && apartmentTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                buildingTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Вносит изменения в квартиру выбранного покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Address.Apartment = apartmentTextBox.Text;
                if (IsReadOnly == false)
                {
                    cityTextBox.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                }

                if (postIndexTextBox.BackColor != System.Drawing.Color.Red
                     && countryTextBox.BackColor != System.Drawing.Color.Red
                     && cityTextBox.BackColor != System.Drawing.Color.Red
                     && streetTextBox.BackColor != System.Drawing.Color.Red
                     && buildingTextBox.BackColor != System.Drawing.Color.Red)
                {
                    _isExceptionThrown = false;
                }
            }
            catch
            {
                _isExceptionThrown = true;
                apartmentTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// Запрещает или разрешает редактировать
        /// содержимое полей при загрузке элемента
        /// управления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressControl_Load(object sender, EventArgs e)
        {
            postIndexTextBox.ReadOnly = IsReadOnly;
            countryTextBox.ReadOnly = IsReadOnly;
            cityTextBox.ReadOnly = IsReadOnly;
            streetTextBox.ReadOnly = IsReadOnly;
            buildingTextBox.ReadOnly = IsReadOnly;
            apartmentTextBox.ReadOnly = IsReadOnly;

            if (IsReadOnly == true)
            {
                postIndexTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                countryTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                cityTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                streetTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                buildingTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
                apartmentTextBox.BackColor = System.Drawing.Color.FromArgb(255, 240, 240, 240);
            }
            else
            {
                postIndexTextBox.BackColor = System.Drawing.Color.White;
                countryTextBox.BackColor = System.Drawing.Color.White;
                cityTextBox.BackColor = System.Drawing.Color.White;
                streetTextBox.BackColor = System.Drawing.Color.White;
                buildingTextBox.BackColor = System.Drawing.Color.White;
                apartmentTextBox.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
