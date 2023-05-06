using Programming.Model.Classes;
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
    /// Хранит данные об элементе пользовательского управления RectanglesControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Массив объектов класса <see cref="Rectangle"/> на пять элементов.
        /// </summary>
        private Model.Classes.Geometry.Rectangle[] _rectangle = new Model.Classes.Geometry.Rectangle[5];

        /// <summary>
        /// Объект класса <see cref="Rectangle"/>, выбранный пользователем.
        /// </summary>
        private Model.Classes.Geometry.Rectangle _currentRectangle = new Model.Classes.Geometry.Rectangle();

        /// <summary>
        /// Инициализация компонентов. Заполнение массива <see cref="_rectangle"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            RectangleListBox.SetSelected(0, true);

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                _rectangle[i] = new Model.Classes.Geometry.Rectangle
                (
                    rand.Next(0, 100),
                    rand.Next(0, 100),
                    "White",
                    new Model.Classes.Geometry.Point2D(rand.Next(0, 100), rand.Next(0, 100))
                );
            }
        }

        /// <summary>
        /// Выводит информацию о выбранном прямоугольнике
        /// из массива <see cref="_rectangle"/>.
        /// </summary>
        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangle[RectangleListBox.SelectedIndex];

            if (_currentRectangle != null)
            {
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color;
                CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
                CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        /// <summary>
        /// Присваивает выбранному прямоугольнику измененную длину.
        /// </summary>
        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthTextBox.BackColor = AppColors.White;
                _currentRectangle.Length = double.Parse(LengthTextBox.Text);
            }
            catch
            {
                LengthTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Присваивает выбранному прямоугольнику измененную ширину.
        /// </summary>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = AppColors.White;
                _currentRectangle.Width = double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Присваивает выбранному прямоугольнику измененный цвет.
        /// </summary>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        /// <summary>
        /// Ищет объект класса <see cref="Rectangle"/> с наибольшей шириной.
        /// </summary>
        /// <param name="rectangleArray">Массив объектов типа <see cref="Rectangle"/>.</param>
        /// <returns>Уникальный идентификатор прямоугольника с
        /// наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Model.Classes.Geometry.Rectangle[] rectangleArray)
        {
            int temp = 0;

            for (int i = 0; i < rectangleArray.Length; i++)
            {
                if (rectangleArray[i].Width > rectangleArray[temp].Width)
                    temp = i;
            }

            return temp;
        }

        /// <summary>
        /// Вызывает поиск прямоугольника с наибольшей шириной.
        /// </summary>
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectangleListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangle);
        }
    }
}
