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

namespace HD4._8
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
            double r1 = Convert.ToDouble(r1Box.Text);
            double r2 = Convert.ToDouble(r2Box.Text);

            double series = r1 + r2;

            double parallel = (r1 + r2) / (r1 + r2);

            seriesBlock.Text = Convert.ToString(series);
            parallelBlock.Text = Convert.ToString(parallel);
        }
    }
}
