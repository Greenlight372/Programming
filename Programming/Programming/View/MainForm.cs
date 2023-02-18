using Programming.Model;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);

            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEnum = EnumsListBox.SelectedItem.ToString();
            switch (selectedEnum)
            {
                case "Color":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Programming.Model.Color));
                    break;
                case "EducationForm":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case "Genre":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case "Manufacturer":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacturer));
                    break;
                case "Season":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case "Weekday":
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    break;
            }
        }

        private void WeekdayButton_Click(object sender, EventArgs e)
        {
            object parsedValue;
            int parseID = 0;

            if (Enum.TryParse(typeof(Weekday), WeekdayTextBox.Text, out parsedValue) == false)
            {
                WeekdayParsingResult.Text = "Нет такого дня недели!";
            }
            else
            {
                int counter = 0;
                foreach (string value in Enum.GetNames(typeof(Weekday)))
                {
                    counter = counter + 1;
                    if (parsedValue.ToString() == value)
                        parseID = counter;
                }
                string result = "Это день недели! (" + parsedValue + " - " + parseID + ")";
                WeekdayParsingResult.Text = result;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string currentSeason = SeasonComboBox.Text;
            switch (currentSeason)
            {
                case "Spring":
                    SeasonHandle.BackColor = System.Drawing.Color.Green;
                    break;
                case "Summer":
                    SeasonHandle.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("Summer's my favorite season.");
                    break;
                case "Autumn":
                    SeasonHandle.BackColor = System.Drawing.Color.Orange;
                    break;
                case "Winter":
                    SeasonHandle.BackColor = System.Drawing.Color.White;
                    MessageBox.Show("So cold... Why is it so cold?..");
                    break;
            }
        }
    }
}