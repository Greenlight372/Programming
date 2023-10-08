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
        /// <summary>
        /// Список объектов класса <see cref="Item"></see>.
        /// </summary>
        private List<Item> _items = new List<Item>();
        /// <summary>
        /// Индекс выбранного объекта в списке.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;
            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            idTextBox.Enabled = false;
            costTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            categoryComboBox.Enabled = false;

            itemsListBox.DisplayMember = "Name";
            categoryComboBox.DisplayMember = "";
        }

        /// <summary>
        /// Выводит информацию о выбранном объекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTextBox.Text = _items[itemsListBox.SelectedIndex].GetId.ToString();
            costTextBox.Text = _items[itemsListBox.SelectedIndex].Cost.ToString();
            nameTextBox.Text = _items[itemsListBox.SelectedIndex].Name;
            descriptionTextBox.Text = _items[itemsListBox.SelectedIndex].Info;
            categoryComboBox.Text = _items[itemsListBox.SelectedIndex].Category.ToString();

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = true;
            costTextBox.Enabled = true;
            nameTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            categoryComboBox.Enabled = true;
        }

        /// <summary>
        /// Добавляет новый объект в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item(Category.Others, "Название", "Описание.", 100));
            itemsListBox.Items.Clear();
            itemsListBox.Items.AddRange(_items.ToArray());

            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryComboBox.Text = "";

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;

            idTextBox.Enabled = false;
            costTextBox.Enabled = false;
            nameTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            categoryComboBox.Enabled = false;
        }

        /// <summary>
        /// Удаляет выбранный объект из списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                categoryComboBox.Text = "";

                costTextBox.BackColor = System.Drawing.Color.White;
                nameTextBox.BackColor = System.Drawing.Color.White;
                descriptionTextBox.BackColor = System.Drawing.Color.White;

                idTextBox.Enabled = false;
                costTextBox.Enabled = false;
                nameTextBox.Enabled = false;
                descriptionTextBox.Enabled = false;
                categoryComboBox.Enabled = false;
            }
        }

        /// <summary>
        /// Вносит изменения в цену выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Вносит изменения в название выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Вносит изменения в описание выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Вносит изменения в категорию выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex > -1)
            {
                _items[itemsListBox.SelectedIndex].Category
                    = (Category)Enum.Parse(typeof(Category),
                    categoryComboBox.SelectedItem.ToString());
            }
        }
    }
}
