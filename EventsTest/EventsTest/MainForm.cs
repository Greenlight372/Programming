using EventsTest.Model;

namespace EventsTest
{
    public partial class MainForm : Form
    {
        private Contact _contact;
        public MainForm()
        {
            InitializeComponent();

            _contact = new Contact("Иванов И. И.", "+7-953-922-59-00", "Ул. Красноармейская, 201");

            fullnameTextBox.Text = _contact.Fullname;
            phoneNumberTextBox.Text = _contact.PhoneNumber;
            addressTextBox.Text = _contact.Address;

            SecondaryForm form2 = new SecondaryForm();
            form2.Contact = _contact;
            form2.Contact.FullnameChanged += form2.FullNameChanged;
            form2.Contact.PhoneNumberChanged += form2.PhoneNumberChanged;
            form2.Contact.AddressChanged += form2.AddressChanged;
            form2.Show();

            SecondaryForm form3 = new SecondaryForm();
            form3.Contact = _contact;
            form3.Contact.FullnameChanged += form3.FullNameChanged;
            form3.Contact.PhoneNumberChanged += form3.PhoneNumberChanged;
            form3.Contact.AddressChanged += form3.AddressChanged;
            form3.Show();

            Contact.FullnameChanged += FullNameChanged;
            Contact.PhoneNumberChanged += PhoneNumberChanged;
            Contact.AddressChanged += AddressChanged;
        }

        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = value;
            }
        }

        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Fullname = fullnameTextBox.Text;
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.PhoneNumber = phoneNumberTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Address = addressTextBox.Text;
        }

        public void FullNameChanged(object sender, EventArgs e)
        {
            fullnameTextBox.Text = Contact.Fullname;
        }

        public void PhoneNumberChanged(object sender, EventArgs e)
        {
            phoneNumberTextBox.Text = Contact.PhoneNumber;
        }

        public void AddressChanged(object sender, EventArgs e)
        {
            addressTextBox.Text = Contact.Address;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}