using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о кольцах.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private int _internalRadius;
        
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private int _externalRadius;

        /// <summary>
        /// Площадь.
        /// </summary>
        /// <returns>Площадь.</returns>
        private double Area()
        {
            double externalArea = Math.PI * (_externalRadius ^ 2);
            double internalArea = Math.PI * (_internalRadius ^ 2);
            return externalArea - internalArea;
        }

        /// <summary>
        /// Возвращает площадь.
        /// </summary>
        public double GetArea { get => Area(); }

        /// <summary>
        /// Возвращает и задает центральную точку.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задает внутренний радиус.
        /// Должен быть положительным и не превышать
        /// внешний радиус.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public int InternalRadius
        {
            get => _internalRadius;
            set
            {
                _internalRadius = value;
                Validator.AssertOnPositiveValue(_internalRadius);
                if (_internalRadius > _externalRadius)
                    throw new ArgumentException("Внутренний радиус не может быть больше внешнего радиуса!");
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус.
        /// Должен быть положительным и не меньше чем
        /// внутренний радиус.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public int ExternalRadius
        {
            get => _externalRadius;
            set
            {
                _externalRadius = value;
                Validator.AssertOnPositiveValue(_externalRadius);
                if (_internalRadius > _externalRadius)
                    throw new ArgumentException("Внешний радиус не должен быть меньше внутреннего радиуса!");
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        { }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="internalRadius">Внутренний радиус.</param>
        /// <param name="externalRadius">Внешний радиус.</param>
        /// <param name="center">Центральная точка.</param>
        public Ring(int internalRadius, int externalRadius, Point2D center)
        {
            _internalRadius = internalRadius;
            _externalRadius = externalRadius;
            Center = center;
        }
    }
}
