using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp.Model
{
    public class Note
    {
        public string Name { get; set; }

        private string text;

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                if (text.Length > 100)
                    throw new ArgumentException("Текст заметки не должен содержать" +
                    " больше ста символов!", nameof(text));
            }
        }

        public DateTime CreationData { get; }

        public string Category { get; set; }

        public Note(string name, string text, string category)
        {
            Name = name;
            Text = text;
            Category = category;
            CreationData = DateTime.Now;
        }

        public Note()
        { 
        }
    }
}
