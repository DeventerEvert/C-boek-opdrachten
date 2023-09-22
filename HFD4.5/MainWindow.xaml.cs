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

namespace HFD4._5
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
            double value = Convert.ToDouble(belastingBox.Text);
            double restValue = value / 100;
            double totalValue = restValue * 20;
            double totalValue2 = restValue * 80;
            nettoGeld.Text = $"Uw inkomstenbelasting is: {totalValue.ToString()}";
            nettoGeld2.Text = $"Totaal na inkomestenbelasting: {totalValue2.ToString()}";
        }
    }
}
