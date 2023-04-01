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
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _length = value;
            }
        }
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }
        public static int AllRectanglesCount { get => _allRectanglesCount; }
        public int Id { get => _id; }

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