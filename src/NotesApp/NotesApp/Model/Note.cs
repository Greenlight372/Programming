using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    /// <summary>
    /// Содержит данные о классе записок.
    /// </summary>
    [Serializable]
    public class Note
    {
        /// <summary>
        /// Получает и задает название записки.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (_name.Length > 100)
                    throw new ArgumentException("Название заметки не должно содержать" +
                    " больше ста символов!", nameof(_name));
            }
        }

        /// <summary>
        /// Название записи.
        /// </summary>
        private string _name;

        /// <summary>
        /// Получает и задает текст записи.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Получает и задает дату создания/последнего изменения записи.
        /// </summary>
        public DateTime CreationData { get; set; }

        /// <summary>
        /// Получвет и задает категорию записи.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Note">.
        /// </summary>
        /// <param name="name">Название записи.</param>
        /// <param name="text">Текст записи.</param>
        /// <param name="category">Категория записи.</param>
        public Note(string name, string text, string category)
        {
            Name = name;
            Text = text;
            Category = category;
            CreationData = DateTime.Now;
        }

        /// <summary>
        /// Создает экземпляр объекта класса <see cref="Note">.
        /// </summary>
        public Note()
        { 
        }
    }
}
