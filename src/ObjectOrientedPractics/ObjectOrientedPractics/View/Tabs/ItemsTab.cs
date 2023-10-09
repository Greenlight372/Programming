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
        private List<Item> _items;
        /// <summary>
        /// Индекс выбранного объекта в списке.
        /// </summary>
        private int _selectedIndex;
        /// <summary>
        /// Значение, указывающее на то, происходит ли редактирование.
        /// </summary>
        private bool _isEdited = false;
        /// <summary>
        /// Экземпляр класса <see cref="Item"></see>.
        /// </summary>
        private Item _itemInstance = new Item(Category.Others, "", "", 0);
        /// <summary>
        /// Свойство для редактирования и доступа к
        /// Списку объектов класса <see cref="Item"></see>.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }
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

            selectedItemLayoutPanel.Enabled = false;

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

            selectedItemLayoutPanel.Enabled = false;
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

                selectedItemLayoutPanel.Enabled = false;
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
                _itemInstance.Cost = Convert.ToInt32(costTextBox.Text);
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
                _itemInstance.Name = descriptionTextBox.Text;
                nameTextBox.BackColor = System.Drawing.Color.White;
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
                _itemInstance.Info = descriptionTextBox.Text;
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
                _itemInstance.Category = (Category)Enum.Parse(typeof(Category),
                    categoryComboBox.SelectedItem.ToString());
            }
        }

        /// <summary>
        /// Позволяет редактировать параметры выбранного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex > -1)
            {
                _selectedIndex = itemsListBox.SelectedIndex;
                _itemInstance = new Item(Category.Others, "", "", 0);
                _isEdited = true;
                selectedItemLayoutPanel.Enabled = _isEdited;
                itemsPanel.Enabled = !_isEdited;
            }
        }

        /// <summary>
        /// Сохраняет внесенные изменения для выбранного товара
        /// и выходит из меню редактирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.BackColor != System.Drawing.Color.Red
                && nameTextBox.BackColor != System.Drawing.Color.Red
                && costTextBox.BackColor != System.Drawing.Color.Red)
            {
                _items[itemsListBox.SelectedIndex].Cost = Convert.ToInt32(costTextBox.Text);
                _items[itemsListBox.SelectedIndex].Name = nameTextBox.Text;
                _items[itemsListBox.SelectedIndex].Info = descriptionTextBox.Text;
                _items[itemsListBox.SelectedIndex].Category
                        = (Category)Enum.Parse(typeof(Category),
                        categoryComboBox.SelectedItem.ToString());
                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_items.ToArray());

                _isEdited = false;
                selectedItemLayoutPanel.Enabled = _isEdited;
                itemsPanel.Enabled = !_isEdited;

                itemsListBox.SelectedIndex = _selectedIndex;

                idTextBox.Text = _items[itemsListBox.SelectedIndex].GetId.ToString();
                costTextBox.Text = _items[itemsListBox.SelectedIndex].Cost.ToString();
                nameTextBox.Text = _items[itemsListBox.SelectedIndex].Name;
                descriptionTextBox.Text = _items[itemsListBox.SelectedIndex].Info;
                categoryComboBox.Text = _items[itemsListBox.SelectedIndex].Category.ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные значения!");
            }
        }

        /// <summary>
        /// Отменяет внесенные изменения для выбранного товара
        /// и выходит из меню редактирования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            _isEdited = false;
            selectedItemLayoutPanel.Enabled = _isEdited;
            itemsPanel.Enabled = !_isEdited;

            itemsListBox.SelectedIndex = _selectedIndex;

            idTextBox.Text = _items[itemsListBox.SelectedIndex].GetId.ToString();
            costTextBox.Text = _items[itemsListBox.SelectedIndex].Cost.ToString();
            nameTextBox.Text = _items[itemsListBox.SelectedIndex].Name;
            descriptionTextBox.Text = _items[itemsListBox.SelectedIndex].Info;
            categoryComboBox.Text = _items[itemsListBox.SelectedIndex].Category.ToString();
        }
    }
}
