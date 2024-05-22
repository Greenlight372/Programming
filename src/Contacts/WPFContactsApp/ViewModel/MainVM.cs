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
using System.Windows;
using System.Collections;
using System.Windows.Controls;

namespace View.ViewModel
{
    /// <summary>
    /// Реализует логику главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция экземпляров
        /// контактной информации.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Выбранный экземпляр
        /// контактной информации.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Указывает доступ
        /// к редактированию.
        /// </summary>
        private bool _isReadOnly = true;

        /// <summary>
        /// Указывает на то,
        /// включен ли элемент управления.
        /// </summary>
        private bool _isEnabled = true;

        /// <summary>
        /// Указывает на видимость
        /// элемента управления.
        /// </summary>
        private bool _visibility = false;

        /// <summary>
        /// Возвращает доступ
        /// к редактированию.
        /// </summary>
        public bool IsReadOnly { get => _isReadOnly; }

        /// <summary>
        /// Возвращает флаг, указывающий
        /// на то, включены ли элементы
        /// управления.
        /// </summary>
        public bool IsEnabled { get => _isEnabled; }

        /// <summary>
        /// Возвращает видимость
        /// элементов управления.
        /// </summary>
        public bool Visibility { get => _visibility; }

        /// <summary>
        /// Выполняется при добавлении.
        /// </summary>
        private RelayCommand _addCommand;

        /// <summary>
        /// Обрабатывает добавление
        /// контактной информации.
        /// </summary>
        public RelayCommand AddCommand
        {
            get
            {
                return _addCommand ??
                  (_addCommand = new RelayCommand(obj =>
                  {
                      Contact contact = new Contact(
                          "Dummy Dummy Dummy", "+79995554400", "dummyMail@Mail.Dum");
                      Contacts.Insert(0, contact);
                      SelectedContact = contact;
                  }));
            }
        }

        /// <summary>
        /// Позволяет редактировать
        /// выбранную контактную информацию.
        /// </summary>
        private RelayCommand _editCommand;

        /// <summary>
        /// Обрабатывает редактирование
        /// контактной информации.
        /// </summary>
        public RelayCommand EditCommand
        {
            get
            {
                return _editCommand ??
                  (_editCommand = new RelayCommand(obj =>
                  {
                      if (SelectedContact != null)
                      {
                          _isReadOnly = false;
                          _isEnabled = false;
                          _visibility = true;
                          OnPropertyChanged(nameof(IsReadOnly));
                          OnPropertyChanged(nameof(IsEnabled));
                          OnPropertyChanged(nameof(Visibility));
                      }
                  }));
            }
        }

        /// <summary>
        /// Удаляет выбранную контактную
        /// информацию.
        /// </summary>
        private RelayCommand _removeCommand;

        /// <summary>
        /// Обрабатывает удаление выбранной
        /// контактной информации.
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                  (_removeCommand = new RelayCommand(obj =>
                  {
                      Contacts.Remove(SelectedContact);
                      OnPropertyChanged(nameof(SelectedContact));
                  }));
            }
        }

        /// <summary>
        /// Подтверждает внесенные
        /// изменения.
        /// </summary>
        private RelayCommand _applyCommand;

        /// <summary>
        /// Обрабатывает подтверждение
        /// внесенных изменений.
        /// </summary>
        public RelayCommand ApplyCommand
        {
            get
            {
                return _applyCommand ??
                  (_applyCommand = new RelayCommand(obj =>
                  {
                      _isReadOnly = true;
                      _isEnabled = true;
                      _visibility = false;
                      SaveCommand.Execute(true);
                      OnPropertyChanged(nameof(IsReadOnly));
                      OnPropertyChanged(nameof(IsEnabled));
                      OnPropertyChanged(nameof(Visibility));
                  }));
            }
        }

        /// <summary>
        /// Возвращает или задает экземпляр
        /// контактной информации.
        /// </summary>
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
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
            LoadCommand.Execute(true);
        }
    }
}