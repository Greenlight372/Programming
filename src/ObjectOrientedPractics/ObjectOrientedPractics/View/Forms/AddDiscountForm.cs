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
        public Category Category { get => (Category)categoryComboBox.SelectedIndex; }
        public bool IsAborted { get; set; } = true;
        public AddDiscountForm()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetNames(typeof(Category));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
