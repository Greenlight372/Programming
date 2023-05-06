using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Хранит данные о точках в двухмерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Положение по оси OX.
        /// </summary>
        private int _x;

        /// <summary>
        /// Положение по оси OY.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        { }

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Положение по оси OX. Должно быть положительным.</param>
        /// <param name="y">Положение по оси OY. Должно быть положительным.</param>
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и задает положение по оси OX.
        /// Должно быть положительным.
        /// </summary>
        public int X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает положение по оси OY.
        /// Должно быть положительным.
        /// </summary>
        public int Y
        {
            get => _y;
            set
            {
                Validator.AssertOnPositiveValue(value, "Y");
                _y = value;
            }
        }
    }
}
