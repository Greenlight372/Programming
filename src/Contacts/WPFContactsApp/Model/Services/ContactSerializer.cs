using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Text.Json;

namespace View.Model.Services
{
    static public class ContactSerializer
    {
        private static string _directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string _filePath = System.IO.Path.Combine(_directoryPath, "Contacts.json");
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
                    stream.Write(Encoding.Default.GetBytes("[]"), 0, Encoding.Default.GetBytes("[]").Length);
                }
            }
        }
        
        public static async void Save(Contact contact)
        {
            string json = JsonSerializer.Serialize(contact);
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                stream.Write(Encoding.Default.GetBytes(json), 0, Encoding.Default.GetBytes(json).Length);
            }
        }

        static public Contact Load()
        {
            using (FileStream stream = new FileStream(_filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    return JsonSerializer.Deserialize<Contact>(stream);
                }
                catch
                {
                    throw new DirectoryNotFoundException("Файл в данной директории отсутствует.");
                }
            }
        }
    }
}
