using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
    {
        private string _title;
        private int _duration;
        private int _year;
        private string _genre;
        private double _score;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
            }
        }

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
                    throw new ArgumentException(String.Format("{0} is not a positive number", _duration), "duration");
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
                if (_year < 1900)
                    throw new ArgumentException(String.Format("{0} is a number out of range", _year), "year");
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
                    throw new ArgumentException(String.Format("{0} is a number out of range", _score), "score");
            }
        }

        public Movie(string titleParam, int durationParam, int yearParam, string genreParam, double scoreParam)
        {
            _title = titleParam;
            _duration = durationParam;
            _year = yearParam;
            _genre = genreParam;
            _score = scoreParam;
        }

        public Movie()
        {
        }
    }
}
