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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        private void gorbluda_Click(object sender, RoutedEventArgs e)
        {
            HotDishes hotdishesWindow = new HotDishes();
            hotdishesWindow.Show();
            this.Close();
        }
        private void napitki_Click(object sender, RoutedEventArgs e)
        {
            Drinks drinksWindow = new Drinks();
            drinksWindow.Show();
            this.Close();
        }
        private void garniry_Click(object sender, RoutedEventArgs e)
        {
            SideDishes sidedishes = new SideDishes();
            sidedishes.Show();
            this.Close();
        }
        private void deserty_Click(object sender, RoutedEventArgs e)
        {
            DessertsWindow dessertswindow = new DessertsWindow();
            dessertswindow.Show();
            this.Close();
        }
        private void pizza_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizzawindow = new Pizza();
            pizzawindow.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            throw new NotImplementedException();
        }

        private void btnEXx_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
    }

}