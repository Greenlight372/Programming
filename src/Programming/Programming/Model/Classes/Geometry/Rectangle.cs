namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольниках.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Количество созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Уникальный идентификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает длину прямоугольника.
        /// Должна быть положительной.
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
        /// Возвращает и задает ширину прямоугольника.
        /// Должна быть положительной.
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
        /// Возвращает количество созданных прямоугольников.
        /// </summary>
        public static int AllRectanglesCount { get => _allRectanglesCount; }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id { get => _id; }

        /// <summary>
        /// Возвращает и задает цвет.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает центральную точку.
        /// </summary>
        public Point2D Center;

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="lengthParam">Длина.</param>
        /// <param name="widthParam">Ширина.</param>
        /// <param name="colorParam">Цвет.</param>
        /// <param name="center">Центральная точка.</param>
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
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _id = _allRectanglesCount;
            _allRectanglesCount += 1;
        }
    }
}