using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTest.Model
{
    public class Contact
    {
        public event EventHandler<EventArgs> FullnameChanged;
        public event EventHandler<EventArgs> PhoneNumberChanged;
        public event EventHandler<EventArgs> AddressChanged;

        private string _fullname;
        private string _phoneNumber;
        private string _address;

        public string Fullname
        {
            get => _fullname;
            set
            {
                string oldFullname = _fullname;
                _fullname = value;
                if (_fullname != oldFullname)
                {
                    FullnameChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                string oldPhoneNumber = _phoneNumber;
                _phoneNumber = value;
                if (_phoneNumber != oldPhoneNumber)
                {
                    PhoneNumberChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                string oldAddress = _address;
                _address = value;
                if (_address != oldAddress)
                {
                    AddressChanged?.Invoke(this, new EventArgs());
                }
            }
        }

        public Contact(string fullname, string phoneNumber, string address)
        {
            _fullname = fullname;
            _phoneNumber = phoneNumber;
            _address = address;
        }
    }
}
