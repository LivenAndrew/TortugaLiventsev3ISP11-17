using System;
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
    /// Логика взаимодействия для DessertsWindow.xaml
    /// </summary>
    public partial class DessertsWindow : Window
    {
        public DessertsWindow()
        {
            InitializeComponent();
        }
        private void cheesecake_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void chocolatecake_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void tiramisy_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void btnExxits_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnInfoDessert_Click(object sender, RoutedEventArgs e)
        {
            WindowDes1 windowdes1 = new WindowDes1();
            windowdes1.Show();
        }
    }
}
