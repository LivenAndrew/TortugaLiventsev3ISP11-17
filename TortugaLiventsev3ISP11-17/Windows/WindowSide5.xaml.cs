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
    /// Логика взаимодействия для WindowSide5.xaml
    /// </summary>
    public partial class WindowSide5 : Window
    {
        public WindowSide5()
        {
            InitializeComponent();
        }

        private void btnExitSide5_Click(object sender, RoutedEventArgs e)
        {
            WindowSide4 sidedishes = new WindowSide4();
            sidedishes.Show();
            this.Close();
        }

        private void btnWinSide5_Click(object sender, RoutedEventArgs e)
        {
            SideDishes sidedishes = new SideDishes();
            sidedishes.Show();
        }
    }
}
