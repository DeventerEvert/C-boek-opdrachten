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

namespace HD4._7
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

        private void oldManBox_Click(object sender, RoutedEventArgs e)
        {
            double value = Convert.ToInt32(openHaard.Text);
            double celcius = (value - 32) * 5 / 9;
            resultBlock.Text = $"{value} graden fahrenheit = {(float)System.Math.Round(celcius, 2)} graden celcius";
        }
    }
}
