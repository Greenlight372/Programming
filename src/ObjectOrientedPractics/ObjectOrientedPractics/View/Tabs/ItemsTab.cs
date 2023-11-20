using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
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
        /// Ссылается на метод, по которому
        /// должна происходить сортировка
        /// списка товаров.
        /// </summary>
        private Func<Item, Item, bool> _sortingWay = DataTools.SortByName; 
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
        private Item _itemInstance = new Item();

        private List<Item> _displayedItems = new List<Item>();
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
            orderComboBox.SelectedIndex = 0;

            selectedItemLayoutPanel.Enabled = false;

            itemsListBox.DisplayMember = "Name";
            categoryComboBox.DisplayMember = "";
        }

        /// <summary>
        /// Определяет, является ли запрос
        /// частью названий товаров.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool CompareSubstring(Item item)
        {
            if (findTextBox.Text == "")
            {
                return true;
            }
            else
            {
                return item.Name.Contains(findTextBox.Text);
            }
        }

        /// <summary>
        /// Событие, срабатывающее при изменении
        /// товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Выводит информацию о выбранном объекте.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex > -1)
            {
                idTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].GetId.ToString();
                costTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Cost.ToString();
                nameTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Name;
                descriptionTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Info;
                categoryComboBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Category.ToString();

                costTextBox.BackColor = System.Drawing.Color.White;
                nameTextBox.BackColor = System.Drawing.Color.White;
                descriptionTextBox.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Добавляет новый объект в список.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item("Название", "Описание.", 100));

            if (_items.Count > 1)
            {
                int uniqueNameCounter = 1;

                while (uniqueNameCounter != 0)
                {
                    uniqueNameCounter = 0;
                    for (int i = 0; i < _items.Count - 1; i++)
                    {
                        if (_items[_items.Count - 1].Name == _items[i].Name)
                        {
                            uniqueNameCounter += 1;
                            _items[_items.Count - 1].Name = _items[i].Name + " 2";
                        }
                    }
                }
            }
            _displayedItems = DataTools.Filtering(_items, CompareSubstring);
            _displayedItems = DataTools.Sort(_displayedItems, _sortingWay);

            itemsListBox.Items.Clear();
            itemsListBox.Items.AddRange(_displayedItems.ToArray());

            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryComboBox.Text = "";

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;

            selectedItemLayoutPanel.Enabled = false;
            ItemsChanged?.Invoke(this, new EventArgs());
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
                _items.RemoveAt(_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex]));
                _displayedItems = DataTools.Filtering(_items, CompareSubstring);
                _displayedItems = DataTools.Sort(_displayedItems, _sortingWay);

                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_displayedItems.ToArray());

                idTextBox.Text = "";
                costTextBox.Text = "";
                nameTextBox.Text = "";
                descriptionTextBox.Text = "";
                categoryComboBox.Text = "";

                costTextBox.BackColor = System.Drawing.Color.White;
                nameTextBox.BackColor = System.Drawing.Color.White;
                descriptionTextBox.BackColor = System.Drawing.Color.White;

                selectedItemLayoutPanel.Enabled = false;

                ItemsChanged?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Вносит изменения в цену выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEdited == true)
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
        }

        /// <summary>
        /// Вносит изменения в название выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEdited == true)
            {
                try
                {
                    _itemInstance.Name = nameTextBox.Text.TrimEnd();
                    nameTextBox.BackColor = System.Drawing.Color.White;

                    for (int i = 0; i < _items.Count; i++)
                    {
                        if (_itemInstance.Name == _items[i].Name && i != _selectedIndex)
                        {
                            nameTextBox.BackColor = System.Drawing.Color.Red;
                        }
                    }
                }
                catch
                {
                    nameTextBox.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        /// <summary>
        /// Вносит изменения в описание выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isEdited == true)
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
        }

        /// <summary>
        /// Вносит изменения в категорию выбранного объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_isEdited == true)
            {
                if (_selectedIndex > -1)
                {
                    _itemInstance.Category = (Category)Enum.Parse(typeof(Category),
                        categoryComboBox.SelectedItem.ToString());
                }
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
                _selectedIndex = _items.IndexOf(_displayedItems[itemsListBox.SelectedIndex]);
                _itemInstance = new Item();
                _itemInstance.Cost = _items[_selectedIndex].Cost;
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
                if (_itemInstance.Cost != null)
                    _items[_selectedIndex].Cost = _itemInstance.Cost;

                if (_itemInstance.Name != null)
                    _items[_selectedIndex].Name = _itemInstance.Name;

                if (_itemInstance.Info != null)
                    _items[_selectedIndex].Info = _itemInstance.Info;

                if (_itemInstance.Category != null)
                    _items[_selectedIndex].Category = _itemInstance.Category;

                Item editedItem = _items[_selectedIndex];

                _displayedItems = DataTools.Filtering(_items, CompareSubstring);
                _displayedItems = DataTools.Sort(_displayedItems, _sortingWay);

                itemsListBox.Items.Clear();
                itemsListBox.Items.AddRange(_displayedItems.ToArray());

                _isEdited = false;
                selectedItemLayoutPanel.Enabled = _isEdited;
                itemsPanel.Enabled = !_isEdited;

                itemsListBox.SelectedIndex = _displayedItems.IndexOf(editedItem);

                idTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].GetId.ToString();
                costTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Cost.ToString();
                nameTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Name;
                descriptionTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Info;
                categoryComboBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Category.ToString();

                ItemsChanged?.Invoke(this, new EventArgs());
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
            Item editedItem = _items[_selectedIndex];
            _isEdited = false;
            selectedItemLayoutPanel.Enabled = _isEdited;
            itemsPanel.Enabled = !_isEdited;

            itemsListBox.SelectedIndex = _displayedItems.IndexOf(editedItem);

            idTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].GetId.ToString();
            costTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Cost.ToString();
            nameTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Name;
            descriptionTextBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Info;
            categoryComboBox.Text = _items[_items.IndexOf(_displayedItems[itemsListBox.SelectedIndex])].Category.ToString();

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Проверяет наличие подстроки в названиях товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            _displayedItems = DataTools.Filtering(_items, CompareSubstring);
            _displayedItems = DataTools.Sort(_displayedItems, _sortingWay);

            itemsListBox.Items.Clear();
            itemsListBox.Items.AddRange(_displayedItems.ToArray());

            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryComboBox.Text = "";

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Определяет тип сортировки списка товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (orderComboBox.SelectedIndex)
            {
                case 0:
                    _sortingWay = DataTools.SortByName;
                    break;
                case 1:
                    _sortingWay = DataTools.SortByAscending;
                    break;
                case 2:
                    _sortingWay = DataTools.SortByDescending;
                    break;
            }

            _displayedItems = DataTools.Filtering(_items, CompareSubstring);
            _displayedItems = DataTools.Sort(_displayedItems, _sortingWay);

            itemsListBox.Items.Clear();
            itemsListBox.Items.AddRange(_displayedItems.ToArray());

            idTextBox.Text = "";
            costTextBox.Text = "";
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            categoryComboBox.Text = "";

            costTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.BackColor = System.Drawing.Color.White;
            descriptionTextBox.BackColor = System.Drawing.Color.White;
        }
    }
}
