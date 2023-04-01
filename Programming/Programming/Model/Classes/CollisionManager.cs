using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            int dX = Math.Abs(rectangle1.Center.GetX - rectangle2.Center.GetX);
            int dY = Math.Abs(rectangle1.Center.GetY - rectangle2.Center.GetY);

            double widthDiff = Math.Abs(rectangle1.Width - rectangle2.Width) / 2;
            double lengthDiff = Math.Abs(rectangle1.Length - rectangle2.Length) / 2;

            if (dX < widthDiff && dY < lengthDiff)
                return true;

            return false;
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            int dX = Math.Abs(ring1.Center.GetX - ring2.Center.GetX);
            int dY = Math.Abs(ring1.Center.GetY - ring2.Center.GetY);
            double hypotenuse = Math.Sqrt(dX ^ 2 + dY);

            if (hypotenuse < ring1.ExternalRadius + ring2.ExternalRadius)
                return true;

            return false;
        }
    }
}
