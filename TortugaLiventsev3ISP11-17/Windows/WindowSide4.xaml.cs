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
    /// Логика взаимодействия для WindowSide4.xaml
    /// </summary>
    public partial class WindowSide4 : Window
    {
        public WindowSide4()
        {
            InitializeComponent();
        }

        private void btnExitSide4_Click(object sender, RoutedEventArgs e)
        {
            WindowSide3 sidedishes = new WindowSide3();
            sidedishes.Show();
            this.Close();
        }

        private void btnWinSide4_Click(object sender, RoutedEventArgs e)
        {
            WindowSide5 windowside5 = new WindowSide5();
            windowside5.Show();
        }
    }
}
