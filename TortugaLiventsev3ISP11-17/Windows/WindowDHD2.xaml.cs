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
    /// Логика взаимодействия для WindowDHD2.xaml
    /// </summary>
    public partial class WindowDHD2 : Window
    {
        public WindowDHD2()
        {
            InitializeComponent();
        }

        private void btnExitInf_Click(object sender, RoutedEventArgs e)
        {
            WindowDescriptionHD hotdishes = new WindowDescriptionHD();
            hotdishes.Show();
            this.Close();
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD3 hotdishes2 = new WindowDHD3();
            hotdishes2.Show();
        }
    }
}
