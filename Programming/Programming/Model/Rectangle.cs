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
                if (_length < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _length), "length");

                _length = value;
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
                if (_width < 0)
                    throw new ArgumentException(String.Format("{0} is not a positive number", _width), "width");

                _width = value;
            }
        }

        public string Color { get; set; }

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