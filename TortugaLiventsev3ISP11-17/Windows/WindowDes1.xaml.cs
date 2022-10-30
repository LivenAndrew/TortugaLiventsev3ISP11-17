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
    /// Логика взаимодействия для WindowDes1.xaml
    /// </summary>
    public partial class WindowDes1 : Window
    {
        public WindowDes1()
        {
            InitializeComponent();
        }

        private void btnExitInn1_Click(object sender, RoutedEventArgs e)
        {
            DessertsWindow dessertswindow = new DessertsWindow();
            dessertswindow.Show();
            this.Close();
        }

        private void btnWinD_Click(object sender, RoutedEventArgs e)
        {
            WindowDes2 windowdes2 = new WindowDes2();
            windowdes2.Show();
        }
    }
}
