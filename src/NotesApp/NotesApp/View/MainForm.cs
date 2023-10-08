using NotesApp.Model;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace NotesApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список объектов класса <see cref="Note"/>.
        /// </summary>
        private List<Note> _notes = new List<Note>();
        /// <summary>
        /// Выбранный объект класса <see cref="Note"/>.
        /// </summary>
        public Note CurrentNote = new Note();
        /// <summary>
        /// Булевое значение, разрешающее редактировать поля выбранного
        /// объекта класса <see cref="Note"/>.
        /// </summary>
        private bool _isEditable = false;

        /// <summary>
        /// Перечисление категорий заметок.
        /// </summary>
        private enum _noteCategories
        {
            Дом,
            Работа,
            Спорт,
            Финансы
        };

        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            NoteCategoryComboBox.DataSource = Enum.GetNames(typeof(_noteCategories));

            NoteNameTextBox.Enabled = _isEditable;
            NoteTextTextBox.Enabled = _isEditable;
            NoteCategoryComboBox.Enabled = _isEditable;
            ApplyChangesPictureBox.Enabled = _isEditable;
            CancelChangesPictureBox.Enabled = _isEditable;

            ApplyChangesPictureBox.Visible = _isEditable;
            CancelChangesPictureBox.Visible = _isEditable;

            NoteNameTextBox.BackColor = Color.White;
            NoteTextTextBox.BackColor = Color.White;
            NoteCreationDataTextBox.BackColor = Color.White;
            NoteCategoryComboBox.BackColor = Color.White;

            NoteCreationDataTextBox.Enabled = false;

            _notes = ProjectSerializer.LoadFromFile();

            if (_notes.Count != null)
            {
                var notesOrdered = _notes.OrderByDescending(Note => Note.CreationData);

                List<Note> newNotes = new List<Note>();

                foreach (Note note in notesOrdered)
                {
                    newNotes.Add(note);
                    NoteListBox.Items.Add
                    (
                        $"{note.Name}"
                    );
                }

                _notes = newNotes;
            }
            else
                _notes = new List<Note>();
        }

        /// <summary>
        /// Добавляет объект класса <see cref="Note"/> в список объектов.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            _notes.Add(new Note("New Note", "", "Дом"));

            var notesOrdered = _notes.OrderByDescending(Note => Note.CreationData);

            List<Note> newNotes = new List<Note>();

            NoteListBox.Items.Clear();
            foreach (Note note in notesOrdered)
            {
                newNotes.Add(note);
                NoteListBox.Items.Add
                (
                    $"{note.Name}"
                );
            }

            _notes = newNotes;
            ProjectSerializer.SaveToFile(_notes);
        }

        /// <summary>
        /// Удаляет выбранный объект класса <see cref="Note"/> из списка объектов.
        /// </summary>
        private void RemoveNotePictureBox_Click(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex != -1)
            {
                _notes.Remove(_notes[NoteListBox.SelectedIndex]);
                NoteNameTextBox.Text = "";
                NoteTextTextBox.Text = "";
                NoteCreationDataTextBox.Text = "";
                NoteListBox.Items.RemoveAt(NoteListBox.SelectedIndex);

                var notesOrdered = _notes.OrderByDescending(Note => Note.CreationData);

                List<Note> newNotes = new List<Note>();

                NoteListBox.Items.Clear();
                foreach (Note note in notesOrdered)
                {
                    newNotes.Add(note);
                    NoteListBox.Items.Add
                    (
                        $"{note.Name}"
                    );
                }

                _notes = newNotes;
                ProjectSerializer.SaveToFile(_notes);
            }
        }

        /// <summary>
        /// Вносит данные полей выбранного объекта класса <see cref="Note"/>.
        /// </summary>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex != -1 && _isEditable == false)
            {
                string name = _notes[NoteListBox.SelectedIndex].Name;
                string text = _notes[NoteListBox.SelectedIndex].Text;
                string category = _notes[NoteListBox.SelectedIndex].Category;
                DateTime creationData = _notes[NoteListBox.SelectedIndex].CreationData;

                NoteNameTextBox.Text = name;
                NoteTextTextBox.Text = text;
                NoteCreationDataTextBox.Text = creationData.ToString();
                NoteCategoryComboBox.Text = category;

                NoteNameTextBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Позволяет редактировать поля выбранного 
        /// объекта класса <see cref="Note"/>.
        /// </summary>
        private void EditNotePictureBox_Click(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex != -1 && _isEditable == false)
            {
                _isEditable = !_isEditable;

                NoteListBox.Enabled = !_isEditable;
                AddNotePictureBox.Enabled = !_isEditable;
                RemoveNotePictureBox.Enabled = !_isEditable;
                EditNotePictureBox.Enabled = !_isEditable; ;

                AddNotePictureBox.Visible = !_isEditable;
                RemoveNotePictureBox.Visible = !_isEditable;
                EditNotePictureBox.Visible = !_isEditable;

                ApplyChangesPictureBox.Enabled = _isEditable;
                CancelChangesPictureBox.Enabled = _isEditable;
                NoteNameTextBox.Enabled = _isEditable;
                NoteTextTextBox.Enabled = _isEditable;
                NoteCategoryComboBox.Enabled = _isEditable;

                ApplyChangesPictureBox.Visible = _isEditable;
                CancelChangesPictureBox.Visible = _isEditable;

                CurrentNote.Name = NoteNameTextBox.Text.ToString();
            }
        }

        /// <summary>
        /// Изменение названия выбранного объекта 
        /// класса <see cref="Note"/>.
        /// </summary>
        private void NoteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex != -1 && _isEditable == true)
            {
                try
                {
                    NoteNameTextBox.BackColor = Color.White;

                    _notes[NoteListBox.SelectedIndex].Name = NoteNameTextBox.Text;
                    NoteListBox.Items[NoteListBox.SelectedIndex]
                    = $"{_notes[NoteListBox.SelectedIndex].Name}";

                    _notes[NoteListBox.SelectedIndex].CreationData = DateTime.Now;
                    NoteCreationDataTextBox.Text
                    = _notes[NoteListBox.SelectedIndex].CreationData.ToString();

                    ApplyChangesPictureBox.Visible = true;
                    ApplyChangesPictureBox.Enabled = true;
                }
                catch (ArgumentException)
                {
                    ApplyChangesPictureBox.Visible = false;
                    ApplyChangesPictureBox.Enabled = false;

                    NoteNameTextBox.BackColor = Color.FromArgb(255, 255, 127, 127);
                }
            }
        }

        /// <summary>
        /// Подтверждает последние изменения полей 
        /// выбранного объекта класса <see cref="Note"/>.
        /// </summary>
        private void ApplyChangesPictureBox_Click(object sender, EventArgs e)
        {
            _isEditable = !_isEditable;

            NoteListBox.Enabled = !_isEditable;
            AddNotePictureBox.Enabled = !_isEditable;
            RemoveNotePictureBox.Enabled = !_isEditable;
            EditNotePictureBox.Enabled = !_isEditable; ;

            AddNotePictureBox.Visible = !_isEditable;
            RemoveNotePictureBox.Visible = !_isEditable;
            EditNotePictureBox.Visible = !_isEditable;

            ApplyChangesPictureBox.Enabled = _isEditable;
            CancelChangesPictureBox.Enabled = _isEditable;
            NoteNameTextBox.Enabled = _isEditable;
            NoteTextTextBox.Enabled = _isEditable;
            NoteCategoryComboBox.Enabled = _isEditable;

            ApplyChangesPictureBox.Visible = _isEditable;
            CancelChangesPictureBox.Visible = _isEditable;

            _notes[NoteListBox.SelectedIndex].Text = NoteTextTextBox.Text;
            _notes[NoteListBox.SelectedIndex].Category
                = NoteCategoryComboBox.SelectedItem.ToString();

            _notes[NoteListBox.SelectedIndex].CreationData = DateTime.Now;
            NoteCreationDataTextBox.Text
            = _notes[NoteListBox.SelectedIndex].CreationData.ToString();

            if (NoteNameTextBox.BackColor == Color.FromArgb(255, 255, 127, 127))
            {
                string name = CurrentNote.Name;
                NoteNameTextBox.Text = name;
                _notes[NoteListBox.SelectedIndex].Name = name;
                NoteListBox.Items[NoteListBox.SelectedIndex]
                = $"{_notes[NoteListBox.SelectedIndex].Name}";
            }

            var notesOrdered = _notes.OrderByDescending(Note => Note.CreationData);

            List<Note> newNotes = new List<Note>();

            NoteListBox.Items.Clear();
            foreach (Note note in notesOrdered)
            {
                newNotes.Add(note);
                NoteListBox.Items.Add
                (
                    $"{note.Name}"
                );
            }

            _notes = newNotes;
            ProjectSerializer.SaveToFile(_notes);
        }

        /// <summary>
        /// Отменяет последние изменения полей 
        /// выбранного объекта класса <see cref="Note"/>.
        /// </summary>
        private void CancelChangesPictureBox_Click(object sender, EventArgs e)
        {
            _isEditable = !_isEditable;

            NoteListBox.Enabled = !_isEditable;
            AddNotePictureBox.Enabled = !_isEditable;
            RemoveNotePictureBox.Enabled = !_isEditable;
            EditNotePictureBox.Enabled = !_isEditable;

            AddNotePictureBox.Visible = !_isEditable;
            RemoveNotePictureBox.Visible = !_isEditable;
            EditNotePictureBox.Visible = !_isEditable;

            ApplyChangesPictureBox.Enabled = _isEditable;
            CancelChangesPictureBox.Enabled = _isEditable;
            NoteNameTextBox.Enabled = _isEditable;
            NoteTextTextBox.Enabled = _isEditable;
            NoteCategoryComboBox.Enabled = _isEditable;

            ApplyChangesPictureBox.Visible = _isEditable;
            CancelChangesPictureBox.Visible = _isEditable;

            string name = CurrentNote.Name;
            NoteNameTextBox.Text = name;
            _notes[NoteListBox.SelectedIndex].Name = name;
            NoteListBox.Items[NoteListBox.SelectedIndex]
                 = $"{CurrentNote.Name}";
        }
    }
}