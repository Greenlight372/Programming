using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;
using System.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using Contacts.Model;
using Contacts.Model.Services;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Реализует логику главного окна.
    /// </summary>
    public partial class MainVM : ObservableObject
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
        [ObservableProperty]
        private Contact? _selectedContact;

        /// <summary>
        /// Указывает доступ
        /// к редактированию.
        /// </summary>
        [ObservableProperty]
        private bool _isReadOnly = true;

        /// <summary>
        /// Указывает на то,
        /// включен ли элемент управления.
        /// </summary>
        [ObservableProperty]
        private bool _isEnabled = true;

        /// <summary>
        /// Указывает на видимость
        /// элемента управления.
        /// </summary>
        [ObservableProperty]
        private bool _visibility = false;

        /// <summary>
        /// Выполняется при добавлении.
        /// </summary>
        private void _addCommand()
        {
            Contact contact = new Contact(
                "Dummy Dummy Dummy", "+79995554400", "dummyMail@Mail.Dum");
            Contacts.Insert(0, contact);
            SelectedContact = contact;
        }

        /// <summary>
        /// Обрабатывает добавление
        /// контактной информации.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Позволяет редактировать
        /// выбранную контактную информацию.
        /// </summary>
        private void _editCommand()
        {
            if (SelectedContact != null)
            {
                IsReadOnly = false;
                IsEnabled = false;
                Visibility = true;
            }
        }

        /// <summary>
        /// Обрабатывает редактирование
        /// контактной информации.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Удаляет выбранную контактную
        /// информацию.
        /// </summary>
        private void _removeCommand()
        {
            if (SelectedContact != null)
            {
                Contacts.Remove(SelectedContact);
            }
        }

        /// <summary>
        /// Обрабатывает удаление выбранной
        /// контактной информации.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Подтверждает внесенные
        /// изменения.
        /// </summary>
        private void _applyCommand()
        {
            IsReadOnly = true;
            IsEnabled = true;
            Visibility = false;
            SaveCommand.Execute(true);
        }

        /// <summary>
        /// Обрабатывает подтверждение
        /// внесенных изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        private void _save() => ContactSerializer.Save(Contacts);

        /// <summary>
        /// Записывает контакт в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        private void _load() => Contacts = ContactSerializer.Load();

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public MainVM()
        {
            SaveCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_save);
            LoadCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_load);
            ApplyCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_applyCommand);
            RemoveCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_removeCommand);
            AddCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_addCommand);
            EditCommand = new CommunityToolkit.Mvvm.Input.RelayCommand(_editCommand);
            LoadCommand.Execute(true);
        }
    }
}