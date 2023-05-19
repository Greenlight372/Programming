using NotesApp.Model;
using System.Security.Cryptography.X509Certificates;

namespace NotesApp.View
{
    public partial class MainForm : Form
    {
        private List<Note> _notes = new List<Note>();

        public Note CurrentNote;

        private enum _enuma
        {
            enumaNadin,
            enumaNdva,
            enumaNtri
        };

        public MainForm()
        {
            InitializeComponent();

            NoteCategoryComboBox.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _notes.Add(new Note("Новая заметка", "", ""));

            for (int i = 0; i < _notes.Count; i++)
            {
                if (_notes[_notes.Count - 1].Name == _notes[i].Name)
                {
                    char lastChar = _notes[i].Name[_notes[i].Name.Length - 1];

                    //_notes[_notes.Count - 1].Name = _notes[i].Name + $" {lastNum}";
                }
            }

            NoteListBox.Items.Add
            (
                $"{_notes[_notes.Count - 1].Name}"
            );
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedIndex != -1)
            {
                string name = _notes[NoteListBox.SelectedIndex].Name;
                string text = _notes[NoteListBox.SelectedIndex].Text;
                string category = _notes[NoteListBox.SelectedIndex].Category;
                DateTime creationData = _notes[NoteListBox.SelectedIndex].CreationData;

                NoteNameTextBox.Text = name;
                NoteTextTextBox.Text = text;
                NoteCreationDataTextBox.Text = creationData.ToString();
                NoteCategoryComboBox.Text = category;
            }
        }
    }
}