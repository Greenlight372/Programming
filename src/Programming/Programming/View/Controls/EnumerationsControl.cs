using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Хранит данные об элементе пользовательского управления EnumerationsControl.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Перечисление перечислений.
        /// </summary>
        private object[] _enumsList = new object[]
        {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Manufacturer),
            typeof(Season),
            typeof(Weekday)
        };

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);

            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
            EnumsListBox.DataSource = Enum.GetValues(typeof(EnumOfEnums));
        }

        /// <summary>
        /// Вывод элементов выбранного перечисления.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = EnumsListBox.SelectedIndex;
            var enumValues = Enum.GetValues((Type)_enumsList[selectedItem]);
            ValuesListBox.Items.Clear();
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
            ValueTextBox.Clear();
        }

        /// <summary>
        /// Вывод индекса выбранного элемента из перечисления.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
