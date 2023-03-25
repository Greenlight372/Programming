using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
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
                if (_duration < 0)
                    throw new ArgumentException($"{0} is not a positive number", nameof(Duration));
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
                if (_year < 1900 || _year > 2023)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Year));
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
                if (_score < 0 || _score > 10)
                    throw new ArgumentException($"{0} is a number out of range", nameof(Score));
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
