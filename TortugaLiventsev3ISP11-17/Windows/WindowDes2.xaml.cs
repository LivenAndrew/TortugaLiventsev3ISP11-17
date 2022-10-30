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
    /// Логика взаимодействия для WindowDes2.xaml
    /// </summary>
    public partial class WindowDes2 : Window
    {
        public WindowDes2()
        {
            InitializeComponent();
        }

        private void btnExitInn1_Click(object sender, RoutedEventArgs e)
        {
            WindowDes1 dessertswindow = new WindowDes1();
            dessertswindow.Show();
            this.Close();
        }

        private void btnWinD2_Click(object sender, RoutedEventArgs e)
        {
            WindowDes3 windowdes3 = new WindowDes3();
            windowdes3.Show();
        }
    }
}
