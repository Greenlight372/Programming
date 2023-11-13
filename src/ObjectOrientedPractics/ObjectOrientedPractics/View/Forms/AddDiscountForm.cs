using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Категория товара, для которой применяется скидка.
        /// </summary>
        public Category Category { get => (Category)categoryComboBox.SelectedIndex; }

        /// <summary>
        /// Указывает, было ли прекращено нахождение на форме.
        /// </summary>
        public bool IsAborted { get; set; } = true;

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetNames(typeof(Category));
        }

        /// <summary>
        /// Закрывает форму без создания скидки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Закрывает форму и создает скидку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
            {
                IsAborted = false;
                Close();
            }
        }
    }
}
