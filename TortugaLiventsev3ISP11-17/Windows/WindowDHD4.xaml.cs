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
    /// Логика взаимодействия для WindowDHD4.xaml
    /// </summary>
    public partial class WindowDHD4 : Window
    {
        public WindowDHD4()
        {
            InitializeComponent();
        }

        private void btnExitInf3_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD3 hotdishes3 = new WindowDHD3();
            hotdishes3.Show();
            this.Close();
        }

        private void btnWindow3_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD5 hotdishes5 = new WindowDHD5();
            hotdishes5.Show();
        }
    }
}
