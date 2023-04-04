﻿using System;
using System.Collections.Generic;
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
using System.Linq;
using System.Data.Linq;

namespace Chat_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseWindowButtonClick(object sender, MouseButtonEventArgs e) //Closing window
        {
            this.Close();
            
        }

        private void DragWindowOnMouseLeftButtonDown(object sender, MouseButtonEventArgs e) //Dragging window
        {
            this.DragMove();
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            var color = (Color)ColorConverter.ConvertFromString("#cdd9e5");
            var colorlast = new SolidColorBrush(color);
            SettingsBars.Foreground = colorlast;
        }

        private void SettingsBars_OnMouseLeave(object sender, MouseEventArgs e)
        {
            SettingsBars.Foreground = Brushes.Aquamarine;
        }
    }
}
