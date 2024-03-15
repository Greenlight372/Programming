using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace View.Model.Services
{
    static public class ContactSerializer
    {
        static private JsonSerializer _serializer = new JsonSerializer();
        static private string _filePath = "C:\\tmp\\contacts.json";
            //= $"C:\\Users\\{Environment.UserName.ToString()}\\{Environment.SpecialFolder.MyDocuments.ToString()}\\contacts.json";
        static public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
            }
        }
        static private StreamWriter _streamWriter = new StreamWriter(FilePath);
        
        static public void Save(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(FilePath, json);
        }
        static public Contact Load()
        {
            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Contact>(json);
        }
    }
}
