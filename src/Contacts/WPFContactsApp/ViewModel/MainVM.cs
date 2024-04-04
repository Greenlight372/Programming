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
using System.Collections.ObjectModel;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;

        public ObservableCollection<Contact> Contacts { get; set; }
        private Contact _selectedContact;

        private bool _isControlElementReadOnly = true;
        private bool _isControlElementEnabled = true;
        private bool _isControlElementVisible = false;
        public bool IsControlElementReadOnly { get => _isControlElementReadOnly; }
        public bool IsControlElementEnabled { get => _isControlElementEnabled; }
        public bool IsControlElementVisible { get => _isControlElementVisible; }

        /// <summary>
        /// Предоставляет доступ к имени контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                SelectedContact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Предоставляет доступ к номеру телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                SelectedContact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Предоставляет доступ к электронной почте контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                SelectedContact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Contact contact = new Contact();
                      Contacts.Insert(0, contact);
                      SelectedContact = contact;
                  }));
            }
        }

        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand(obj =>
                  {
                      _isControlElementReadOnly = false;
                      _isControlElementEnabled = false;
                      _isControlElementVisible = true;
                      OnPropertyChanged(nameof(IsControlElementReadOnly));
                      OnPropertyChanged(nameof(IsControlElementEnabled));
                      OnPropertyChanged(nameof(IsControlElementVisible));
                  }));
            }
        }

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Зажигает событие изменения свойства.
        /// </summary>
        /// <param name="prop"></param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged(this,new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Записывает контакт в файл.
        /// </summary>
        public ICommand SaveCommand { get; set; }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        public ICommand LoadCommand { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>
            {
                new Contact("Dummy Dummy #1", "+70000000000", "dummail@dum.my"),
                new Contact("Dummy Dummy #2", "+70000000000", "dummail@dum.my"),
                new Contact("Dummy Dummy #3", "+70000000000", "dummail@dum.my")
            };
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
        }
    }
}
