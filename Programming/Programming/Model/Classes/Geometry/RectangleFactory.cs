using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    static public class RectangleFactory
    {
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
