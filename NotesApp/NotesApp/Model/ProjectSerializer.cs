using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Environment;

namespace NotesApp.Model
{
    /// <summary>
    /// Содержит методы для сериализации и десериализации
    /// объектов класса <see cref="Note">.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Записывает данные массива в файл.
        /// </summary>
        /// <param name="notes">Исходный массив записей.</param>
        /// <param name="filename">Расположение файла.</param>
        /// <exception cref="FileNotFoundException"></exception>
        public static void SaveToFile(List<Note> notes, string filename = "")
        {
            string activeFilename = Environment.GetFolderPath(SpecialFolder.ApplicationData)
             + $"\\Dimitri\\NotesApp\\NotesData.json";

            if (filename != "")
            {
                activeFilename = filename;
            }

            try
            {
                string jsonString = JsonSerializer.Serialize<List<Note>>(notes);
                File.WriteAllText(activeFilename, jsonString);
            }
            catch
            {
                throw new FileNotFoundException("Указанного пути не существует!"
                    , nameof(activeFilename));
            }
        }

        /// <summary>
        /// Считывает записанные данные из файла.
        /// </summary>
        /// <param name="filename">Расположение файла.</param>
        /// <returns>Массив записей.</returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static List<Note> LoadFromFile(string filename = "")
        {
            string activeFilename = Environment.GetFolderPath(SpecialFolder.ApplicationData)
             + $"\\Dimitri\\NotesApp\\NotesData.json";

            if (filename != "")
            {
                activeFilename = filename;
            }

            try
            {
                string jsonString = File.ReadAllText(activeFilename);
                List<Note> notes = JsonSerializer.Deserialize<List<Note>>(jsonString);
                
                return notes;
            }
            catch
            {
                throw new FileNotFoundException("Указанного пути не существует!"
                    , nameof(activeFilename));

                List<Note> notes = new List<Note>();

                return notes;
            }
        }
    }
}