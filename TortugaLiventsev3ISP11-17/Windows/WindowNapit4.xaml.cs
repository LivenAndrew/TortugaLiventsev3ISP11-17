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
    /// Логика взаимодействия для WindowNapit4.xaml
    /// </summary>
    public partial class WindowNapit4 : Window
    {
        public WindowNapit4()
        {
            InitializeComponent();
        }

        private void btnExitNapit4_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit3 drinks = new WindowNapit3();
            drinks.Show();
            this.Close();
        }

        private void btnWinNap4_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit5 windownapit5 = new WindowNapit5();
            windownapit5.Show();
        }
    }
}
