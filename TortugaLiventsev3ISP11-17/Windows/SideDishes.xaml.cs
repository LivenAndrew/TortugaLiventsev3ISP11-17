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
    /// Логика взаимодействия для SideDishes.xaml
    /// </summary>
    public partial class SideDishes : Window
    {
        public SideDishes()
        {
            InitializeComponent();
        }

        private void ricevegetable_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void potatosoev_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void pasta_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void ratatue_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void potatoefri_Click(object sender, RoutedEventArgs e)
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

        private void btnInfoSideDishes_Click(object sender, RoutedEventArgs e)
        {
            WindowSide1 windowside1 = new WindowSide1();
            windowside1.Show();
        }
    }
}
