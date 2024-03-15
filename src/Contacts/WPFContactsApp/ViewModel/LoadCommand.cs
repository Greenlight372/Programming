using System;
using System.Collections.Generic;
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
    /// загрузку данных из файла.
    /// </summary>
    public class LoadCommand : ICommand
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
        public LoadCommand(MainVM mainVM)
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
        /// Исполняет загрузку данных.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            Contact contact = ContactSerializer.Load();

            _mainVM.Name = contact.Name;
            _mainVM.PhoneNumber = contact.PhoneNumber;
            _mainVM.Email = contact.Email;
        }
    }
}
