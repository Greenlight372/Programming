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
            cartsControl.Items = _store.Items;
            cartsControl.Customers = _store.Customers;
            ordersControl.Customers = _store.Customers;
        }
        /// <summary>
        /// ��������� ������ � <see cref="cartsControl"></see>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shopTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartsControl.RefreshData();
            ordersControl.UpdateOrders();
        }
    }
}