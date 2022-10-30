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
    /// Логика взаимодействия для WindowDes3.xaml
    /// </summary>
    public partial class WindowDes3 : Window
    {
        public WindowDes3()
        {
            InitializeComponent();
        }

        private void btnExitInn3_Click(object sender, RoutedEventArgs e)
        {
            WindowDes2 dessertswindow = new WindowDes2();
            dessertswindow.Show();
            this.Close();
        }

        private void btnWinD3_Click(object sender, RoutedEventArgs e)
        {
            DessertsWindow windowdess = new DessertsWindow();
            windowdess.Show();
        }
    }
}
