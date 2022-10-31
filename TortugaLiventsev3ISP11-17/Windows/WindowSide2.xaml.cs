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
    /// Логика взаимодействия для WindowSide2.xaml
    /// </summary>
    public partial class WindowSide2 : Window
    {
        public WindowSide2()
        {
            InitializeComponent();
        }

        private void btnExitSide2_Click(object sender, RoutedEventArgs e)
        {
            WindowSide1 sidedishes = new WindowSide1();
            sidedishes.Show();
            this.Close();
        }

        private void btnWinSide2_Click(object sender, RoutedEventArgs e)
        {
            WindowSide3 windowside3 = new WindowSide3();
            windowside3.Show();
        }
    }
}
