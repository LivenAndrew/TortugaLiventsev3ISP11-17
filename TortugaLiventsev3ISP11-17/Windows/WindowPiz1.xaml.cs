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
    /// Логика взаимодействия для WindowPiz1.xaml
    /// </summary>
    public partial class WindowPiz1 : Window
    {
        public WindowPiz1()
        {
            InitializeComponent();
        }

        private void btnExitIn1_Click(object sender, RoutedEventArgs e)
        {
            Pizza pizza1 = new Pizza();
            pizza1.Show();
            this.Close();
        }

        private void btnWinP_Click(object sender, RoutedEventArgs e)
        {
            WindowPiz2 windowpiz = new WindowPiz2();
            windowpiz.Show();
        }
    }
}
