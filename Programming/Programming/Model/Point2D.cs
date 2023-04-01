using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        private int _x;
        private int _y;
        public Point2D()
        { }
        public Point2D(int x, int y)
        {
            SetX(x);
            SetY(y);
        }
        public int GetX
        {
            get { return _x; }
        }
        public int GetY
        {
            get { return _y; }
        }
        private void SetX(int value)
        {
            _x = value;
            Validator.AssertOnPositiveValue(_x);
        }
        private void SetY(int value)
        {
            _y = value;
            Validator.AssertOnPositiveValue(_y);
        }
    }
}
