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
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new();
        private int _selectedIndex;
        public ItemsTab()
        {
            InitializeComponent();
            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = false;
            costTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;

            itemsListBox.DisplayMember = "Name";
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTextBox.Text = _items[itemsListBox.SelectedIndex].GetId.ToString();
            costTextBox.Text = _items[itemsListBox.SelectedIndex].Cost.ToString();
            nameTextBox.Text = _items[itemsListBox.SelectedIndex].Name;
            descriptionTextBox.Text = _items[itemsListBox.SelectedIndex].Info;

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = true;
            costTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item("Название", "Описание.", 100));
            itemsListBox.Items.Clear();
            itemsListBox.Items.AddRange(_items.ToArray());

            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex > -1)
            {
                _items.RemoveAt(itemsListBox.SelectedIndex);
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_items.ToArray());

                idTextBox.Text = "";
                costTextBox.Text = "";
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";

                costTextBox.BackColor = System.Drawing.Color.White;
                nameTextBox.BackColor = System.Drawing.Color.White;
                descriptionTextBox.BackColor = System.Drawing.Color.White;

                idTextBox.Enabled = false;
                costTextBox.Enabled = false;
                nameTextBox.Enabled = false;
                descriptionTextBox.Enabled = false;
            }
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _items[itemsListBox.SelectedIndex].Cost 
                    = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                costTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedIndex = itemsListBox.SelectedIndex;
                _items[itemsListBox.SelectedIndex].Name = nameTextBox.Text;
                nameTextBox.BackColor = System.Drawing.Color.White;
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_items.ToArray());
                itemsListBox.SelectedIndex = _selectedIndex;
            }
            catch
            {
                nameTextBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _items[itemsListBox.SelectedIndex].Info = descriptionTextBox.Text;
                descriptionTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                descriptionTextBox.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
