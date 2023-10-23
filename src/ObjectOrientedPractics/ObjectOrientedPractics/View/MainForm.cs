using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса <see cref="Store"></see>.
        /// </summary>
        private Store _store = new Store();
        /// <summary>
        /// Инициализация компонентов.
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
        /// Обновляет данные в <see cref="cartsControl"></see>.
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