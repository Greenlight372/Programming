using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        private string _name;
        private string _phoneNumber;
        private string _email;
        private Contact _contact = new Contact();

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _contact.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                _contact.PhoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                _contact.Email = value;
                OnPropertyChanged("Email");
            }
        }

        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged(this,new PropertyChangedEventArgs(prop));
        }
        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }
        public MainVM()
        {
            SaveCommand = new SaveCommand(parameter =>
            {
                ContactSerializer.Save(Contact);
            });
            LoadCommand = new LoadCommand(parameter =>
            {
                _contact = ContactSerializer.Load();
            });
        }
    }
}
