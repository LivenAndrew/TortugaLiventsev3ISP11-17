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
    /// Логика взаимодействия для WindowNapit5.xaml
    /// </summary>
    public partial class WindowNapit5 : Window
    {
        public WindowNapit5()
        {
            InitializeComponent();
        }

        private void btnExitNapit5_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit4 drinks = new WindowNapit4();
            drinks.Show();
            this.Close();
        }

        private void btnWinNap5_Click(object sender, RoutedEventArgs e)
        {
            Drinks windowdrink = new Drinks();
            windowdrink.Show();
        }
    }
}
