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
    /// Логика взаимодействия для BucketWindow.xaml
    /// </summary>
    public partial class BucketWindow : Window
    {
        public BucketWindow()
        {
            InitializeComponent();
        }

        private void btnNextttWindow_Click(object sender, RoutedEventArgs e)
        {
           OrderPaymentWindow orderpaymentWindow = new OrderPaymentWindow();
            orderpaymentWindow.Show();
        }

        private void btnExittt_Click(object sender, RoutedEventArgs e)
        {
            DescriptionWindow descriptionWindow = new DescriptionWindow();
            descriptionWindow.Show();
            this.Close();
        }
    }
}