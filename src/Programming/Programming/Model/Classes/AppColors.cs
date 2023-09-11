using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Красный.
        /// </summary>
        public static Color Red = Color.FromArgb(127, 255, 127, 127);
        
        /// <summary>
        /// Зеленый.
        /// </summary>
        public static Color Green = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Черный с прозрачностью 50%.
        /// </summary>
        public static Color TransparentBlack_50 = Color.FromArgb(127, 0, 0, 0);
        
        /// <summary>
        /// Черный с прозрачностью 25%.
        /// </summary>
        public static Color TransparentBlack_25 = Color.FromArgb(63, 0, 0, 0);

        /// <summary>
        /// Светло-розовый.
        /// </summary>
        public static Color LightPink = Color.LightPink;
        
        /// <summary>
        /// Белый.
        /// </summary>
        public static Color White = Color.White;
        
        /// <summary>
        /// Оранжевый.
        /// </summary>
        public static Color Orange = Color.Orange;
    }
}
