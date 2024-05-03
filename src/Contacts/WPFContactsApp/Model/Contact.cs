using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace View.Model
{
    /// <summary>
    /// Класс, описывающий контактную информацию.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
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
        /// Электронная почта
        /// контакта.
        /// </summary>
        private string _email;
        /// <summary>
        /// Получает или задает
        /// имя контакта.
        /// </summary>
        public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        /// <summary>
        /// Получает или задает
        /// номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        /// <summary>
        /// Получает или задает
        /// электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        if (Name.Length > 100)
                        {
                            error = $"Field {nameof(Name)} shouldn't" +
                                $" contain more than 100 symbols.";
                        }
                        break;
                    case nameof(PhoneNumber):
                        //Regex regex = new Regex("^[0-9\\-\\+\\(\\)]$");
                        if (PhoneNumber.Length > 100)
                        {
                            error = $"Field {nameof(PhoneNumber)} shouldn't" +
                                $" contain more than 100 symbols.";
                        }
                        break;
                    case nameof(Email):
                        if (Email.Length > 100)
                        {
                            error = $"Field {nameof(Email)} shouldn't" +
                                $" contain more than 100 symbols.";
                        }
                        else if (!Email.Contains("@"))
                        {
                            error = $"Field {nameof(PhoneNumber)} should" +
                                $" contain the following symbol: @.";
                        }
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get;
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
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        /// <summary>
        /// Конструктор контакта.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Адрес электронной почты.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }
    }
}
