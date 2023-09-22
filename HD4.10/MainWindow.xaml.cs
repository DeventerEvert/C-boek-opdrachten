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

namespace HD4._10
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

        private void calcBtn_Click(object sender, RoutedEventArgs e)
        {
            //N = aantal jaar
            //R = rente percentage
            //E = je uitkomst
            //B = beginsaldo

            double begin;
            double b = Convert.ToDouble(beginBox.Text);
            double n = Convert.ToInt32(jarenBox.Text);
            double r = Convert.ToDouble(renteBox.Text);
            begin = b * Math.Pow((1 + (r / 100)), n);

            resultBox.Text = Convert.ToString(Math.Round(begin, 2));
        }
    }
}
