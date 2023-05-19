namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// ������ ������ � ���������������.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// �����.
        /// </summary>
        private double _length;

        /// <summary>
        /// ������.
        /// </summary>
        private double _width;

        /// <summary>
        /// ���������� ��������� ���������������.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// ���������� ������������� ��������������.
        /// </summary>
        private int _id;

        /// <summary>
        /// ���������� � ������ ����� ��������������.
        /// ������ ���� �������������.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {
                Validator.AssertOnPositiveValue(value, "Length");
                _length = value;
            }
        }

        /// <summary>
        /// ���������� � ������ ������ ��������������.
        /// ������ ���� �������������.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(value, "Width");
                _width = value;
            }
        }

        /// <summary>
        /// ���������� ���������� ��������� ���������������.
        /// </summary>
        public static int AllRectanglesCount { get => _allRectanglesCount; }

        /// <summary>
        /// ���������� ���������� ������������� ��������������.
        /// </summary>
        public int Id { get => _id; }

        /// <summary>
        /// ���������� � ������ ����.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// ���������� � ������ ����������� �����.
        /// </summary>
        public Point2D Center;

        /// <summary>
        /// ������� ��������� ������ <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="lengthParam">�����.</param>
        /// <param name="widthParam">������.</param>
        /// <param name="colorParam">����.</param>
        /// <param name="center">����������� �����.</param>
        public Rectangle(
            double lengthParam, double widthParam, string colorParam, Point2D center)
        {
            _length = lengthParam;
            _width = widthParam;
            Color = colorParam;
            Center = center;
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }

        /// <summary>
        /// ������� ��������� ������ <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
    }
}