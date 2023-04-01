using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private int _internalRadius;
        private int _externalRadius;
        private double Area()
        {
            double externalArea = Math.PI * (_externalRadius ^ 2);
            double internalArea = Math.PI * (_internalRadius ^ 2);
            return externalArea - internalArea;
        }
        public double GetArea { get => Area(); }
        public Point2D Center { get; set; }
        public int InternalRadius
        {
            get => _internalRadius;
            set
            {
                _internalRadius = value;
                Validator.AssertOnPositiveValue(_internalRadius);
                if (_internalRadius > _externalRadius)
                    throw new ArgumentException("Internal radius mustn't be greater than external radius!");
            }
        }
        public int ExternalRadius
        {
            get => _externalRadius;
            set
            {
                _externalRadius = value;
                Validator.AssertOnPositiveValue(_externalRadius);
                if (_internalRadius > _externalRadius)
                    throw new ArgumentException("External radius mustn't be lower than internal radius!");
            }
        }
        public Ring()
        { }
        public Ring(int internalRadius, int externalRadius, Point2D center)
        {
            _internalRadius = internalRadius;
            _externalRadius = externalRadius;
            Center = center;
        }
    }
}
