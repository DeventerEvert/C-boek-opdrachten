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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HD4._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gemiddeldBtn_Click(object sender, RoutedEventArgs e)
        {

            double result1 = Convert.ToDouble(valueBox1.Text);
            double result2 = Convert.ToDouble(valueBox2.Text);
            double total = (result1 + result2) / 2;
            GemiddeldeBlok.Text = Convert.ToString(total);

            int preciseResult = Convert.ToInt32(result1);
            int preciseResult2 = Convert.ToInt32(result2);
            int preciseTotal = (preciseResult + preciseResult2) / 2;
            GemiddeldeBlok2.Text = Convert.ToString(preciseTotal);







        }
    }
}
