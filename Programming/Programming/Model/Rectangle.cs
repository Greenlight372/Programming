namespace Programming.Model
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                if (_length < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _length), "length");
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                if (_width < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _width), "width");
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Rectangle(double lengthParam, double widthParam, string colorParam)
        {
            _length = lengthParam;
            _width = widthParam;
            _color = colorParam;
        }

        public Rectangle()
        {
        }
    }
}