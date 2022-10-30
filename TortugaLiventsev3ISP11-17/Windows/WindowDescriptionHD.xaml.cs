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
    /// Логика взаимодействия для WindowDescriptionHD.xaml
    /// </summary>
    public partial class WindowDescriptionHD : Window
    {
        public WindowDescriptionHD()
        {
            InitializeComponent();
        }

        private void btnExitInfo_Click(object sender, RoutedEventArgs e)
        {
            HotDishes hotdishes = new HotDishes();
            hotdishes.Show();
            this.Close();
        }

        private void btnNTWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowDHD2 hotdishes2 = new WindowDHD2();
            hotdishes2.Show();
        }
    }
}
