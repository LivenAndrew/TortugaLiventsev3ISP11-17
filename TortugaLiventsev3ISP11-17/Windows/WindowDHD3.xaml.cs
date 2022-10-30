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
    /// Логика взаимодействия для WindowDHD3.xaml
    /// </summary>
    public partial class WindowDHD3 : Window
    {
        public WindowDHD3()
        {
            InitializeComponent();
        }

        private void btnExitInf2_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD2 hotdishes3 = new WindowDHD2();
            hotdishes3.Show();
            this.Close();
        }

        private void btnWindow3_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD4 hotdishes2 = new WindowDHD4();
            hotdishes2.Show();
        }
    }
}
