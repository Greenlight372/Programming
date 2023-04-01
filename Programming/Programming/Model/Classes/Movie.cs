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
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
                Validator.AssertOnPositiveValue(_duration);
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                Validator.AssertValueInRange(_year, 1900, 2023);
            }
        }
        public double Score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                Validator.AssertValueInRange(_score, 0, 10);
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
