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
        private Address _address = new Address();
        public Address AddressProperty
        {
            get => _address;
            set
            {
                _address = value;
            }
        }

        public AddressControl()
        {
            InitializeComponent();

            postIndexTextBox.Text = AddressProperty.Index;
            countryTextBox.Text = AddressProperty.Country;
            cityTextBox.Text = AddressProperty.City;
            streetTextBox.Text = AddressProperty.Street;
            buildingTextBox.Text = AddressProperty.Building;
            apartmentTextBox.Text = AddressProperty.Apartment;
        }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.Index = postIndexTextBox.Text;
                postIndexTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                postIndexTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.Country = countryTextBox.Text;
                countryTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                countryTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.City = cityTextBox.Text;
                cityTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                cityTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.Street = streetTextBox.Text;
                streetTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                streetTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                buildingTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressProperty.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                apartmentTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
