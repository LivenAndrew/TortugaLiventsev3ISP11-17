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
    /// Логика взаимодействия для WindowNapit2.xaml
    /// </summary>
    public partial class WindowNapit2 : Window
    {
        public WindowNapit2()
        {
            InitializeComponent();
        }

        private void btnExitNapit2_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit1 drinks = new WindowNapit1();
            drinks.Show();
            this.Close();
        }

        private void btnWinNap2_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit3 windownapit3 = new WindowNapit3();
            windownapit3.Show();
        }
    }
}
