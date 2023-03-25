namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;

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
                    throw new ArgumentException($"{0} is not a positive number", nameof(Length));
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
                    throw new ArgumentException($"{0} is not a positive number", nameof(Width));
            }
        }

        public string Color { get; set; }

        public Rectangle(double lengthParam, double widthParam, string colorParam)
        {
            _length = lengthParam;
            _width = widthParam;
            Color = colorParam;
        }

        public Rectangle()
        {
        }
    }
}