using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class Point2D
    {
        private int _x;
        private int _y;
        public Point2D()
        { }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X
        {
            get => _x;
            set
            {
                Validator.AssertOnPositiveValue(value, "X");
                _x = value;
            }
        }
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
