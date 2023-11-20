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

            itemsControl.ItemsChanged += store_StoreChanged;
            customersControl.CustomersChanged += store_StoreChanged;
            cartsControl.CartsChanged += store_StoreChanged;
            ordersControl.OrderChanged += store_StoreChanged;
        }

        /// <summary>
        /// Обновляет данные в <see cref="cartsControl"></see>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void store_StoreChanged(object sender, EventArgs e)
        {
            cartsControl.RefreshData();
            ordersControl.RefreshData();
            ordersControl.UpdateOrders();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemsControl.ItemsChanged -= store_StoreChanged;
            customersControl.CustomersChanged -= store_StoreChanged;
            cartsControl.CartsChanged -= store_StoreChanged;
            ordersControl.OrderChanged -= store_StoreChanged;
        }
    }
}