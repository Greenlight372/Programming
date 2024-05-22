using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Contacts.Model.Services
{
    /// <summary>
    /// Служебный класс для сохранения
    /// и загрузки данных из текстового файла.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь до файла.
        /// </summary>
        private static string _filePath =
            System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Сontacts.json");

        /// <summary>
        /// Сохраняет данные объекта.
        /// </summary>
        /// <param name="contacts">
        /// Экземпляр контактной информации
        /// для сохранения.
        /// </param>
        public static async void Save(ObservableCollection<Contact> contacts)
        {
            using (StreamWriter stream = new StreamWriter(_filePath))
            {
                stream.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Загружает данные объекта.
        /// </summary>
        /// <returns>Контактные данные.</returns>
        public static ObservableCollection<Contact> Load()
        {
            var contacts = new ObservableCollection<Contact>();
            try
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    contacts =
                        JsonConvert.DeserializeObject<ObservableCollection<Contact>>(reader.ReadToEnd());
                }

                if (contacts == null) contacts = new ObservableCollection<Contact>();
            }
            catch
            {
                return contacts;
            }
            return contacts;
        }
    }
}
