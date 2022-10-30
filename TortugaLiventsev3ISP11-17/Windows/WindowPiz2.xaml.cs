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
    /// Логика взаимодействия для WindowPiz2.xaml
    /// </summary>
    public partial class WindowPiz2 : Window
    {
        public WindowPiz2()
        {
            InitializeComponent();
        }

        private void btnExitIn2_Click(object sender, RoutedEventArgs e)
        {
            WindowPiz1 pizza = new WindowPiz1();
            pizza.Show();
            this.Close();
        }

        private void btnWinP2_Click(object sender, RoutedEventArgs e)
        {
            Pizza windowpiz = new Pizza();
            windowpiz.Show();
        }
    }
}
