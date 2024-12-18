﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Contacts.ViewModel;
using Windows.UI.ViewManagement;

namespace Contacts.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Экземпляр ViewModel.
        /// </summary>
        private MainVM _mainVM = new MainVM();
        /// <summary>
        /// Конструктор главного окна.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainVM;

            Loaded += (o, e) => SizeToContent = SizeToContent.Manual;
        }
        /// <summary>
        /// Выполняется при закрытии
        /// приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closing(object sender, CancelEventArgs e)
        {
            if (_mainVM.IsReadOnly == true)
            {
                _mainVM.SaveCommand.Execute(true);
            }
        }
    }
}
