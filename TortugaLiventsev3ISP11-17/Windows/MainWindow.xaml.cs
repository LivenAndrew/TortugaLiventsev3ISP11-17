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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TortugaLiventsev3ISP11_17.Windows;

namespace TortugaLiventsev3ISP11_17
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNextWindow_Click(object sender, RoutedEventArgs e)
        {
            Window1 tableWindow = new Window1();
            tableWindow.Show();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            InfoWindow infowindow = new InfoWindow();
            infowindow.Show();
        }
    }
}
