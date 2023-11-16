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
    public partial class InterfaceTab : UserControl
    {
        public InterfaceTab()
        {
            InitializeComponent();

            var address = new Address("123456", "Russia", "Moscow", "-", "-", "-");
            var addressCopy = (Address)address.Clone();

            var item = new Item("Item 1", "Info.", 300);
            var item2 = new Item("Item 2", "Info.", 550);

            boolLabel.Text = address.Equals(addressCopy).ToString();
            iCompLabel.Text = item.CompareTo(item2).ToString();
        }

        private void InterfaceTab_Load(object sender, EventArgs e)
        {

        }
    }
}
