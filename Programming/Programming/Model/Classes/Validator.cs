using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для валидации данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что целое число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя объекта, подлежащего проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string propertyName = "")
        {
            if (value < 0)
                throw new ArgumentException($"Значение должно быть положительным! {propertyName}");
        }

        /// <summary>
        /// Проверяет, что вещественное число является положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя объекта, подлежащего проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string propertyName = "")
        {
            if (value < 0)
                throw new ArgumentException($"Значение должно быть положительным! {propertyName}");
        }

        /// <summary>
        /// Проверяет целое число на вхождение в диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне.</param>
        /// <param name="max">Максимальное значение в диапазоне.</param>
        /// <param name="propertyName">Имя объекта, подлежащего проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Значение вне диапазона! {propertyName}");
        }

        /// <summary>
        /// Проверяет вещественное число на вхождение в диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне.</param>
        /// <param name="max">Максимальное значение в диапазоне.</param>
        /// <param name="propertyName">Имя объекта, подлежащего проверке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName = "")
        {
            if (value < min || value > max)
                throw new ArgumentException($"Значение вне диапазона! {propertyName}");
        }
    }
}
