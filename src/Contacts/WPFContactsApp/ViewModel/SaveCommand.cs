using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, реализующий
    /// сохранение данных в
    /// текстовый файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Экземпляр основного окна.
        /// </summary>
        private MainVM _mainVM;

        /// <summary>
        /// Обработчик событий.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="mainVM">Экземпляр главного окна.</param>
        public SaveCommand(MainVM mainVM)
        {
            _mainVM = mainVM;
        }

        /// <summary>
        /// Флаг, указывающий на готовность
        /// класса.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Исполняет запись данных.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            ContactSerializer.CreateFolder();

            ObservableCollection<Contact> contacts = _mainVM.Contacts;

            ContactSerializer.Save(contacts);
        }
    }
}