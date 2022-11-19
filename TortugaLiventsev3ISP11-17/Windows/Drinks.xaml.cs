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
    /// Логика взаимодействия для Drinks.xaml
    /// </summary>
    public partial class Drinks : Window
    {
        public Drinks()
        {
            InitializeComponent();
        }
        private void cola_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void fanta_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void sprite_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void water_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void gaswater_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnExits_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnInfoDinks_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit1 windownapit1 = new WindowNapit1();
            windownapit1.Show();
        }
    }
}
