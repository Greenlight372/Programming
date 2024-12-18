﻿using Programming.Model.Classes;
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
    /// Хранит данные об элементе пользовательского управления SeasonsHandleControl.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        /// <summary>
        /// Инициализация компонентов.
        /// </summary>
        public SeasonsHandleControl()
        {
            InitializeComponent();
            SeasonComboBox.DataSource = Enum.GetNames(typeof(Model.Enums.Season));
        }

        /// <summary>
        /// Алгоритм действий в случае нажатия на кнопку SeasonButton.
        /// </summary>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string currentSeason = SeasonComboBox.Text;
            switch (currentSeason)
            {
                case "Spring":
                    SeasonHandle.BackColor = AppColors.Green;
                    break;
                case "Summer":
                    SeasonHandle.BackColor = AppColors.White;
                    MessageBox.Show("Summer's my favorite season.");
                    break;
                case "Autumn":
                    SeasonHandle.BackColor = AppColors.Orange;
                    break;
                case "Winter":
                    SeasonHandle.BackColor = AppColors.White;
                    MessageBox.Show("So cold... Why is it so cold?..");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forme = new Form2();

            forme.ShowDialog();
        }
    }
}
