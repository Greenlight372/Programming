using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _duration;
        private int _year;
        private double _score;

        public string Title { get; set; }
        public string Genre { get; set; }

        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, "Duration");
                _duration = value;
            }
        }
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(value, 1900, 2023, "Year");
                _year = value;
            }
        }
        public double Score
        {
            get => _score;
            set
            {
                Validator.AssertValueInRange(value, 0, 10, "Score");
                _score = value;
            }
        }

        public Movie(string titleParam, int durationParam, int yearParam, string genreParam, double scoreParam)
        {
            Title = titleParam;
            _duration = durationParam;
            _year = yearParam;
            Genre = genreParam;
            _score = scoreParam;
        }

        public Movie()
        {
        }
    }
}
