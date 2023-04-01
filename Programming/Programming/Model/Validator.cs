using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value)
        {
            if (value < 0)
                throw new ArgumentException("Value is supposed to be positive!");
        }

        public static void AssertOnPositiveValue(double value)
        {
            if (value < 0)
                throw new ArgumentException("Value is supposed to be positive!");
        }

        public static void AssertValueInRange(int value, int min, int max)
        {
            if (value < min || value > max)
                throw new ArgumentException("Value is out of range!");
        }

        public static void AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value > max)
                throw new ArgumentException("Value is out of range!");
        }
    }
}
