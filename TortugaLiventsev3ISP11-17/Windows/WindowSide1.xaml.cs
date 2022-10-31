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
    /// Логика взаимодействия для WindowSide1.xaml
    /// </summary>
    public partial class WindowSide1 : Window
    {
        public WindowSide1()
        {
            InitializeComponent();
        }

        private void btnExitSide1_Click(object sender, RoutedEventArgs e)
        {
            SideDishes sidedishes = new SideDishes();
            sidedishes.Show();
            this.Close();
        }

        private void btnWinSide1_Click(object sender, RoutedEventArgs e)
        {
            WindowSide2 windowside2 = new WindowSide2();
            windowside2.Show();
        }
    }
}
