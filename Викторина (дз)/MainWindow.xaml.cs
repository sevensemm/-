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

namespace Викторина__дз_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Otv1.IsChecked == true || Otv2.IsChecked == true || Otv3.IsChecked == true || Otv4.IsChecked == true)
            {
                MessageBox.Show("Поздравляем, вы успешно сдали тест!!!!");
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Попробуйте снова!!!");
            }
        }
    }
}
