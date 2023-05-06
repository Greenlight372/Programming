using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Предоставляет метод для создания экземпляра класса <see cref="Rectangle"/>.
    /// </summary>
    static public class RectangleFactory
    {
        /// <summary>
        /// Создает экземпляра класса <see cref="Rectangle"/> с случайными параметрами.
        /// </summary>
        /// <param name="panel">Панель, на которой будет отрисован
        /// объект класса <see cref="Rectangle"/>.</param>
        /// <returns>Экземпляра класса <see cref="Rectangle"/>.</returns>
        static public Rectangle Randomize(Panel panel)
        {
            Random rand = new Random();

            Rectangle rectangle = new Rectangle
            (
                rand.Next(10, 100),
                rand.Next(10, 100),
                "White",
                new Point2D(rand.Next(15, panel.Width - 15), rand.Next(15, panel.Height - 15))
            );

            return rectangle;
        }
    }
}
