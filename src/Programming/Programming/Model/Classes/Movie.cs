using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильмах.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Оценка фильма.
        /// </summary>
        private double _score;

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма.
        /// Должна быть положительной.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выхода фильма.
        /// Должен быть в диапазоне от 1900 до 2023.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, 1900, 2023, "Year");
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает оценку фильма.
        /// Должна входить в диапазон от 0 до 10.
        /// </summary>
        public double Score
        {
            get => _score;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Score");
                _score = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="titleParam">Название.</param>
        /// <param name="durationParam">Продолжительность. Должна быть положительной.</param>
        /// <param name="yearParam">Год выхода. Должен входить в диапазон от 1900 до 2023.</param>
        /// <param name="genreParam">Жанр.</param>
        /// <param name="scoreParam">Оценка. Должна входить в диапазон от 0 до 10.</param>
        public Movie(string titleParam, int durationParam, int yearParam, string genreParam, double scoreParam)
        {
            Title = titleParam;
            _duration = durationParam;
            _year = yearParam;
            Genre = genreParam;
            _score = scoreParam;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {
        }
    }
}
