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
        public static System.Drawing.Color Red = System.Drawing.Color.FromArgb(127, 255, 127, 127);
        
        /// <summary>
        /// Зеленый.
        /// </summary>
        public static System.Drawing.Color Green = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Черный с прозрачностью 50%.
        /// </summary>
        public static System.Drawing.Color TransparentBlack_50 = System.Drawing.Color.FromArgb(127, 0, 0, 0);
        
        /// <summary>
        /// Черный с прозрачностью 25%.
        /// </summary>
        public static System.Drawing.Color TransparentBlack_25 = System.Drawing.Color.FromArgb(63, 0, 0, 0);

        /// <summary>
        /// Светло-розовый.
        /// </summary>
        public static System.Drawing.Color LightPink = System.Drawing.Color.LightPink;
        
        /// <summary>
        /// Белый.
        /// </summary>
        public static System.Drawing.Color White = System.Drawing.Color.White;
        
        /// <summary>
        /// Оранжевый.
        /// </summary>
        public static System.Drawing.Color Orange = System.Drawing.Color.Orange;
    }
}
