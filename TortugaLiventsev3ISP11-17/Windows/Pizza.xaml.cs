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
    /// Логика взаимодействия для Pizza.xaml
    /// </summary>
    public partial class Pizza : Window
    {
        public Pizza()
        {
            InitializeComponent();
        }
        private void pizza_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void carbonara_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void btnExs_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnInfoPizza_Click(object sender, RoutedEventArgs e)
        {
            WindowPiz1 windowpiz1 = new WindowPiz1();
            windowpiz1.Show();
        }
    }
}
