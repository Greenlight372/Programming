using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ������ <see cref="Store"></see>.
        /// </summary>
        private Store _store = new Store();
        /// <summary>
        /// ������������� �����������.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            itemsControl.Items = _store.Items;
            customersControl.Customers = _store.Customers;
        }
    }
}