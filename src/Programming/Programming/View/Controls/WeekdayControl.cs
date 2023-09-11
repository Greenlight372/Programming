using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Хранит данные об элементе пользовательского управления WeekdayControl.
    /// </summary>
    public partial class WeekdayControl : UserControl
    {
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public WeekdayControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка введенного значения на соответствие
        /// дню недели.
        /// </summary>
        private void WeekdayButton_Click(object sender, EventArgs e)
        {
            object parsedValue;
            int parseID = 0;

            if (Enum.TryParse(typeof(Weekday), WeekdayTextBox.Text, out parsedValue) == false)
            {
                WeekdayParsingResult.Text = "Такого дня недели не существует!";
            }
            else
            {
                int counter = 0;
                foreach (string value in Enum.GetNames(typeof(Weekday)))
                {
                    counter += 1;
                    if (parsedValue.ToString() == value)
                        parseID = counter;
                }
                string result = "Это день недели! (" + parsedValue + " - " + parseID + ")";
                WeekdayParsingResult.Text = result;
            }
        }
    }
}
