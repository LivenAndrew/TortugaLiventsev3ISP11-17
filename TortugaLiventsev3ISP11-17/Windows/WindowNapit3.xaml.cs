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
    /// Логика взаимодействия для WindowNapit3.xaml
    /// </summary>
    public partial class WindowNapit3 : Window
    {
        public WindowNapit3()
        {
            InitializeComponent();
        }

        private void btnExitNapit3_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit2 drinks = new WindowNapit2();
            drinks.Show();
            this.Close();
        }

        private void btnWinNap3_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit4 windownapit4 = new WindowNapit4();
            windownapit4.Show();
        }
    }
}
