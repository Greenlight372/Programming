using EventsTest.Model;

namespace EventsTest
{
    public partial class SecondaryForm : Form
    {
        private Contact _contact;
        public SecondaryForm()
        {
            InitializeComponent();
        }

        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                fullnameTextBox.Text = _contact.Fullname;
                phoneNumberTextBox.Text = _contact.PhoneNumber;
                addressTextBox.Text = _contact.Address;
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
            Contact.FullnameChanged -= FullNameChanged;
            Contact.PhoneNumberChanged -= PhoneNumberChanged;
            Contact.AddressChanged -= AddressChanged;

            Close();
        }
    }
}