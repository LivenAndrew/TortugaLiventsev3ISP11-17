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
using System.Windows.Shapes;

namespace TortugaLiventsev3ISP11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderPayment.xaml
    /// </summary>
    public partial class OrderPayment : Window
    {
        public OrderPayment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow mainWindow = new FirstWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnNextWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNexttWindow_Click(object sender, RoutedEventArgs e)
        {
            TableWindow firstWindow = new TableWindow();
            firstWindow.Show();
        }
    }
}
