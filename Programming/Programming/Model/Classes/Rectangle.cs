namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private static int _allRectanglesCount;
        private int _id;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                Validator.AssertOnPositiveValue(_length);
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
                Validator.AssertOnPositiveValue(_width);
            }
        }
        public static int AllRectanglesCount { get { return _allRectanglesCount; } }
        public int Id { get { return _id; } }

        public string Color { get; set; }
        public Point2D Center;

        public Rectangle(double lengthParam, double widthParam, string colorParam, Point2D center)
        {
            _length = lengthParam;
            _width = widthParam;
            Color = colorParam;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
    }
}