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
    /// Логика взаимодействия для WindowSide3.xaml
    /// </summary>
    public partial class WindowSide3 : Window
    {
        public WindowSide3()
        {
            InitializeComponent();
        }

        private void btnExitSide3_Click(object sender, RoutedEventArgs e)
        {
            WindowSide2 sidedishes = new WindowSide2();
            sidedishes.Show();
            this.Close();
        }

        private void btnWinSide3_Click(object sender, RoutedEventArgs e)
        {
            WindowSide4 windowside4 = new WindowSide4();
            windowside4.Show();
        }
    }
}
