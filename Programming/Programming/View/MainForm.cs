using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using Programming.Model.Enums;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private object[] _enumsList = new object[]
        {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Manufacturer),
            typeof(Season),
            typeof(Weekday)
        };

        private Model.Classes.Geometry.Rectangle[] _rectangle = new Model.Classes.Geometry.Rectangle[5];
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();

        private Movie[] _movie = new Movie[5];
        private Movie _currentMovie = new Model.Classes.Movie();

        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SetSelected(0, true);
            RectangleListBox.SetSelected(0, true);

            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
            EnumsListBox.DataSource = Enum.GetValues(typeof(EnumOfEnums));
            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                _rectangle[i] = new Model.Classes.Geometry.Rectangle
                (
                    rand.Next(0, 100),
                    rand.Next(0, 100),
                    "White",
                    new Model.Classes.Geometry.Point2D(rand.Next(0, 100), rand.Next(0, 100))
                );
                _movie[i] = new Model.Classes.Movie
                (
                    "Sample Title",
                    30 + rand.Next(0, 120),
                    1900 + rand.Next(0, 123),
                    "Sample Genre",
                    rand.Next(0, 10)
                );
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = EnumsListBox.SelectedIndex;
            var enumValues = Enum.GetValues((Type)_enumsList[selectedItem]);
            ValuesListBox.Items.Clear();
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
            ValueTextBox.Clear();
        }

        private void WeekdayButton_Click(object sender, EventArgs e)
        {
            object parsedValue;
            int parseID = 0;

            if (Enum.TryParse(typeof(Weekday), WeekdayTextBox.Text, out parsedValue) == false)
            {
                WeekdayParsingResult.Text = "There's no such weekday!";
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
                string result = "It's a weekday! (" + parsedValue + " - " + parseID + ")";
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

        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangle[RectangleListBox.SelectedIndex];

            if (_currentRectangle != null)
            {
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color;
                CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
                CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = double.Parse(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Geometry.Rectangle[] rectangleArray)
        {
            int temp = 0;

            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i].Width > rectangleArray[temp].Width)
                    temp = i;
            }

            return temp;
        }

        private int FindMovieWithMaxScore(Movie[] movieArray)
        {
            int temp = 0;

            for (int i = 0; i < movieArray.Length; i++)
            {
                if (movieArray[i].Score > movieArray[temp].Score)
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
                DurationTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = int.Parse(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
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
                ScoreTextBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Score = double.Parse(ScoreTextBox.Text);
            }
            catch
            {
                ScoreTextBox.BackColor = System.Drawing.Color.LightPink;
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