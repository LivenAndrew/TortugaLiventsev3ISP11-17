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
    /// Логика взаимодействия для OrderPaymentWindow.xaml
    /// </summary>
    public partial class OrderPaymentWindow : Window
    {
        public OrderPaymentWindow()
        {
            InitializeComponent();
        }

        private void btnNexttWindow_Click(object sender, RoutedEventArgs e)
        {
            ThanksWindow thanksWindow = new ThanksWindow();
            thanksWindow.Show();
        }

        private void btnExitt_Click(object sender, RoutedEventArgs e)
        {
            BucketWindow bucketWindow = new BucketWindow();
            bucketWindow.Show();
            this.Close();
        }
    }
}
