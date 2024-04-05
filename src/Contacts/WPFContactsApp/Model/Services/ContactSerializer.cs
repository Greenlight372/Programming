using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Text.Json;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Serialization;

namespace View.Model.Services
{
    /// <summary>
    /// Служебный класс для сохранения
    /// и загрузки данных из текстового файла.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь до папки с текстовым файлом.
        /// </summary>
        private static string _directoryPath = 
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        /// <summary>
        /// Путь до текстового файла.
        /// </summary>
        private static string _filePath = 
            System.IO.Path.Combine(_directoryPath, "Contacts.json");
        
        /// <summary>
        /// Создает папку и файл при их отсутствии.
        /// </summary>
        public static void CreateFolder()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }

            if (!File.Exists(_filePath))
            {
                using (FileStream stream = new FileStream(_filePath, FileMode.Create))
                {
                    stream.Write(Encoding.Default.GetBytes("[]"),
                        0, Encoding.Default.GetBytes("[]").Length);
                }
            }
        }
        
        /// <summary>
        /// Сохраняет данные объекта.
        /// </summary>
        /// <param name="contact">
        /// Экземпляр контактной информации
        /// для сохранения.
        /// </param>
        public static async void Save(ObservableCollection<Contact> contacts)
        {
            string json = JsonSerializer.Serialize(contacts);
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                stream.Write(
                    Encoding.Default.GetBytes(json),
                    0, Encoding.Default.GetBytes(json).Length);
            }
        }

        /// <summary>
        /// Загружает данные объекта.
        /// </summary>
        /// <returns>Контактные данные.</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static ObservableCollection<Contact> Load()
        {
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    return JsonSerializer.Deserialize<ObservableCollection<Contact>>(stream);
                }
                catch
                {
                    throw new 
                        DirectoryNotFoundException("Файл в данной директории отсутствует.");
                }
            }
        }
    }
}
