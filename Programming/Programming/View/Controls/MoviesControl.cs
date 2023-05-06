using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Controls
{
    /// <summary>
    /// Хранит данные об элементе пользовательского управления MoviesControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив объектов класса <see cref="Movie"/>.
        /// </summary>
        private Movie[] _movie = new Movie[5];

        /// <summary>
        /// Выбранный объект из массива <see cref="_movie"/>.
        /// </summary>
        private Movie _currentMovie = new Model.Classes.Movie();

        /// <summary>
        /// Инициализация компонентов. Заполнение массива <see cref="_movie"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
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

        /// <summary>
        /// Ищет фильм с наивысшей оценкой из массива.
        /// </summary>
        /// <param name="movieArray">Массив объектов класса <see cref="Movie"/>.</param>
        /// <returns>Уникальный идентификатор фильма с наивысшей оценкой.</returns>
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

        /// <summary>
        /// Вызывает поиск фильма с наивысшей оценкой.
        /// </summary>
        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxScore(_movie);
        }

        /// <summary>
        /// Изменение названия выбранного фильма.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = TitleTextBox.Text;
        }

        /// <summary>
        /// Изменение продолжительности выбранного фильма.
        /// </summary>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.BackColor = AppColors.White;
                _currentMovie.Duration = int.Parse(DurationTextBox.Text);
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Изменения года выхода выбранного фильма.
        /// </summary>
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.BackColor = AppColors.White;
                _currentMovie.Year = int.Parse(YearTextBox.Text);
            }
            catch
            {
                YearTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Изменение жанра выбранного фильма.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        /// <summary>
        /// Изменение оценки выбранного фильма.
        /// </summary>
        private void ScoreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ScoreTextBox.BackColor = AppColors.White;
                _currentMovie.Score = double.Parse(ScoreTextBox.Text);
            }
            catch
            {
                ScoreTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Выводит информацию о выбранном фильме
        /// из массива <see cref="_movie"/>.
        /// </summary>
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
