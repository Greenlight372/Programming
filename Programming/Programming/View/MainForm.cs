using Programming.Model;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Programming.Model.Rectangle[] _rectangle = new Programming.Model.Rectangle[5];
        private Programming.Model.Rectangle _currentRectangle = new Programming.Model.Rectangle();

        private Programming.Model.Movie[] _movie = new Programming.Model.Movie[5];
        private Programming.Model.Movie _currentMovie = new Programming.Model.Movie();

        Random rand = new Random();

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
            RectangleListBox.SetSelected(0, true);

            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));

            for (int i = 0; i < 5; i++)
            {
                _rectangle[i] = new Programming.Model.Rectangle(rand.Next(0, 100), rand.Next(0, 100), "White");
                _movie[i] = new Programming.Model.Movie("Sample Title", 30 + rand.Next(0, 120), 1900 + rand.Next(0, 123), "Sample Genre", rand.Next(0, 10));
            }
        }

        /// <summary>
        /// Выбор нумерации.
        /// </summary>
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
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Парсинг дня недели.
        /// </summary>
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
                    counter += 1;
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

        /// <summary>
        /// Времена года.
        /// </summary>
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangle[RectangleListBox.SelectedIndex];

            //LengthTextBox.Text = _currentRectangle.Length.ToString();
            //WidthTextBox.Text = _currentRectangle.Width.ToString();
            //ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = double.Parse(LengthTextBox.Text);
                Classes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                Classes.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = double.Parse(WidthTextBox.Text);
                Classes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                Classes.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Programming.Model.Rectangle[] _rectangleArray)
        {
            int temp = 0;

            for (int i = 0; i < _rectangleArray.Length; i++)
            {
                if (_rectangleArray[i].Width > _rectangleArray[temp].Width)
                    temp = i;
            }

            return temp;
        }

        private int FindMovieWithMaxScore(Programming.Model.Movie[] _movieArray)
        {
            int temp = 0;

            for (int i = 0; i < _movieArray.Length; i++)
            {
                if (_movieArray[i].Score > _movieArray[temp].Score)
                    temp = i;
            }

            return temp;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangle);
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxScore(_movie);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TitleTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
                Classes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                Classes.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Year = int.Parse(YearTextBox.Text);
                Classes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                Classes.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void ScoreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Score = double.Parse(ScoreTextBox.Text);
                Classes.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                Classes.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movie[MoviesListBox.SelectedIndex];

            TitleTextBox.Text = _currentMovie.Title;
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            ScoreTextBox.Text = _currentMovie.Score.ToString();
        }
    }
}