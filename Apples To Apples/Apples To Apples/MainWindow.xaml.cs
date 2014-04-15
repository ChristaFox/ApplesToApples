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

namespace Apples_To_Apples
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

        public Rectangle DrawCard(int left, int top, String message, SolidColorBrush color, Canvas canvas)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 200;
            rect.Height = 300;
            rect.Fill = color;

            canvas.Children.Add(rect);
            Canvas.SetLeft(rect, left);
            Canvas.SetTop(rect, top);
            return rect;
        }

        public Boolean IsJudge()
        {
            return false;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            StartPage.Visibility = System.Windows.Visibility.Collapsed;
            LblTitle.Visibility = System.Windows.Visibility.Collapsed;
            if (IsJudge())
                JudgeView.Visibility = System.Windows.Visibility.Visible;
            else
                PlayerView.Visibility = System.Windows.Visibility.Visible; 
        }
    }
}
