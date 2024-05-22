using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.Model.Services
{
    /// <summary>
    /// Привязывает команды между элементами
    /// ViewModel и пользовательского интерфейса.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Делегат исполнения.
        /// </summary>
        private Action<object> execute;

        /// <summary>
        /// Делегат валидации выполнения.
        /// </summary>
        private Func<object, bool> canExecute;

        /// <summary>
        /// Обрабатывает событие изменения
        /// возможности исполнения.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Конструктор RelayCommand.
        /// </summary>
        /// <param name="execute"></param>
        /// <param name="canExecute"></param>
        public RelayCommand(Action<object> execute, 
            Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        /// <summary>
        /// Проверяет, может ли быть
        /// выполнена команда.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>Возможность выполнения.</returns>
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        /// <summary>
        /// Выполнение команды.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
