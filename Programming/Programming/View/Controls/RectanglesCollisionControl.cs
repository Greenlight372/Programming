using Programming.Model.Classes.Geometry;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {

        private List<Model.Classes.Geometry.Rectangle> _rectangles = new List<Model.Classes.Geometry.Rectangle>();
        public Model.Classes.Geometry.Rectangle Rectangle;
        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            Random rand = new Random();

            AddRectangleBox.BackColor = System.Drawing.Color.FromArgb(127, 0, 0, 0);
            RemoveRectangleBox.BackColor = System.Drawing.Color.FromArgb(127, 0, 0, 0);
        }

        private void AddRectangleBox_Click(object sender, EventArgs e)
        {

            _rectangles.Add(Model.Classes.Geometry.RectangleFactory.Randomize(RectanglePanel));

            int id = _rectangles[_rectangles.Count - 1].Id;
            int x = _rectangles[_rectangles.Count - 1].Center.X;
            int y = _rectangles[_rectangles.Count - 1].Center.Y;
            double width = _rectangles[_rectangles.Count - 1].Width;
            double height = _rectangles[_rectangles.Count - 1].Length;

            Panel panel = new Panel();
            panel.Location = new Point(x - Convert.ToInt32(width) / 2, y - Convert.ToInt32(height) / 2);
            panel.Width = Convert.ToInt32(width);
            panel.Height = Convert.ToInt32(height);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            _rectanglePanels.Add(panel);

            RectanglePanel.Controls.Add(_rectanglePanels[_rectanglePanels.Count - 1]);

            RectanglesListBox.Items.Add
            (
                $"{id}: (X={x}, Y={y}, Width={width}, Height={height})"
            );

            FindCollisions();
        }

        private void RemoveRectangleBox_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _rectangles.Remove(_rectangles[RectanglesListBox.SelectedIndex]);
                _rectanglePanels.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglePanel.Controls.RemoveAt(RectanglesListBox.SelectedIndex);
                RectanglesListBox.Items.RemoveAt(RectanglesListBox.SelectedIndex);

                ClearRectangleInfo();
                FindCollisions();
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int id = _rectangles[RectanglesListBox.SelectedIndex].Id;
                int x = _rectangles[RectanglesListBox.SelectedIndex].Center.X;
                int y = _rectangles[RectanglesListBox.SelectedIndex].Center.Y;
                double width = _rectangles[RectanglesListBox.SelectedIndex].Width;
                double height = _rectangles[RectanglesListBox.SelectedIndex].Length;

                RectangleIDTextBox.Text = id.ToString();
                RectangleXTextBox.Text = x.ToString();
                RectangleYTextBox.Text = y.ToString();
                RectangleWidthTextBox.Text = width.ToString();
                RectangleHeightTextBox.Text = height.ToString();
            }
        }

        private void RectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    RectangleXTextBox.BackColor = System.Drawing.Color.White;
                    _rectangles[RectanglesListBox.SelectedIndex].Center.X = int.Parse(RectangleXTextBox.Text);

                    UpdateRectangleInfo(_rectangles[RectanglesListBox.SelectedIndex]);

                    _rectanglePanels[RectanglesListBox.SelectedIndex].Width
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Height
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point
                    (
                        _rectangles[RectanglesListBox.SelectedIndex].Center.X
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width / 2),
                        _rectangles[RectanglesListBox.SelectedIndex].Center.Y
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length / 2)
                    );

                    FindCollisions();
                }
                catch
                {
                    RectangleXTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    RectangleYTextBox.BackColor = System.Drawing.Color.White;
                    _rectangles[RectanglesListBox.SelectedIndex].Center.Y = int.Parse(RectangleYTextBox.Text);

                    UpdateRectangleInfo(_rectangles[RectanglesListBox.SelectedIndex]);

                    _rectanglePanels[RectanglesListBox.SelectedIndex].Width
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Height
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point
                    (
                        _rectangles[RectanglesListBox.SelectedIndex].Center.X
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width / 2),
                        _rectangles[RectanglesListBox.SelectedIndex].Center.Y
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length / 2)
                    );
                    FindCollisions();
                }
                catch
                {
                    RectangleYTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
                    _rectangles[RectanglesListBox.SelectedIndex].Width = int.Parse(RectangleWidthTextBox.Text);

                    UpdateRectangleInfo(_rectangles[RectanglesListBox.SelectedIndex]);

                    _rectanglePanels[RectanglesListBox.SelectedIndex].Width
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Height
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point
                    (
                        _rectangles[RectanglesListBox.SelectedIndex].Center.X
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width / 2),
                        _rectangles[RectanglesListBox.SelectedIndex].Center.Y
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length / 2)
                    );
                    FindCollisions();
                }
                catch
                {
                    RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void RectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                try
                {
                    RectangleHeightTextBox.BackColor = System.Drawing.Color.White;
                    _rectangles[RectanglesListBox.SelectedIndex].Length = int.Parse(RectangleHeightTextBox.Text);

                    UpdateRectangleInfo(_rectangles[RectanglesListBox.SelectedIndex]);

                    _rectanglePanels[RectanglesListBox.SelectedIndex].Width
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Height
                    = Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length);
                    _rectanglePanels[RectanglesListBox.SelectedIndex].Location = new Point
                    (
                        _rectangles[RectanglesListBox.SelectedIndex].Center.X
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Width / 2),
                        _rectangles[RectanglesListBox.SelectedIndex].Center.Y
                        - Convert.ToInt32(_rectangles[RectanglesListBox.SelectedIndex].Length / 2)
                    );
                    FindCollisions();
                }
                catch
                {
                    RectangleHeightTextBox.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void UpdateRectangleInfo(Model.Classes.Geometry.Rectangle rectangle)
        {
            int id = rectangle.Id;
            int x = rectangle.Center.X;
            int y = rectangle.Center.Y;
            double width = rectangle.Width;
            double height = rectangle.Length;

            RectanglesListBox.Items[RectanglesListBox.SelectedIndex]
            = $"{id}: (X={x}, Y={y}, Width={width}, Height={height})";
        }

        private void ClearRectangleInfo()
        {
            RectangleIDTextBox.Text = "";
            RectangleXTextBox.Text = "";
            RectangleYTextBox.Text = "";
            RectangleWidthTextBox.Text = "";
            RectangleHeightTextBox.Text = "";
        }

        private void AddRectangleBox_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleBox.BackColor = System.Drawing.Color.FromArgb(127, 0, 0, 0);
        }

        private void RemoveRectangleBox_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveRectangleBox.BackColor = System.Drawing.Color.FromArgb(63, 0, 0, 0);
        }

        private void RemoveRectangleBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleBox.BackColor = System.Drawing.Color.FromArgb(127, 0, 0, 0);
        }

        private void AddRectangleBox_MouseMove(object sender, MouseEventArgs e)
        {
            AddRectangleBox.BackColor = System.Drawing.Color.FromArgb(63, 0, 0, 0);
        }
    }
}
