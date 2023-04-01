using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName = "")
        {
            if (value < 0)
                throw new ArgumentException($"Value is supposed to be positive! {propertyName}");
        }

        public static void AssertOnPositiveValue(double value, string propertyName = "")
        {
            if (value < 0)
                throw new ArgumentException($"Value is supposed to be positive! {propertyName}");
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Value is out of range! {propertyName}");
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Value is out of range! {propertyName}");
        }
    }
}
