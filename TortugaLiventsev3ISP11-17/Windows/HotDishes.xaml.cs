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
    /// Логика взаимодействия для HotDishes.xaml
    /// </summary>
    public partial class HotDishes : Window
    {
        public HotDishes()
        {
            InitializeComponent();
        }

        private void zarkoe_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void image4_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void friedrice_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void lagman_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }
        private void moimoi_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnExxx_Click(object sender, RoutedEventArgs e)
        {
            ChoiceWindow menuWindow = new ChoiceWindow();
            menuWindow.Show();
            this.Close();
        }

        private void btnInfoHotDishes_Click(object sender, RoutedEventArgs e)
        {
            WindowDescriptionHD descriptionwindow = new WindowDescriptionHD();
            descriptionwindow.Show();
        }
    }
}
