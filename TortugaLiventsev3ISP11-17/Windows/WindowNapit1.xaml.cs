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
    /// Логика взаимодействия для WindowNapit1.xaml
    /// </summary>
    public partial class WindowNapit1 : Window
    {
        public WindowNapit1()
        {
            InitializeComponent();
        }

        private void btnExitNap1_Click(object sender, RoutedEventArgs e)
        {
            Drinks drinks = new Drinks();
            drinks.Show();
            this.Close();
        }

        private void btnWinNap1_Click(object sender, RoutedEventArgs e)
        {
            WindowNapit2 windownapit2 = new WindowNapit2();
            windownapit2.Show();
        }
    }
}
