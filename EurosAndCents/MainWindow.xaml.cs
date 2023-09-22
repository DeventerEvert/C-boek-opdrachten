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

namespace EurosAndCents
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

        private void convertBtn_Click(object sender, RoutedEventArgs e)
        {
            int value;
            int euros;
            int cents;
            value = Convert.ToInt32(inputBox.Text);
            euros = value / 100;
            cents = value % 100;

            euroShow.Content = euros;
            centShow.Content = cents;

            fullResult.Text = $"Het volledige bedrag is {euros, -10} euro en {cents, +12} cent";

            if(value > 5000)
            {
                MessageBox.Show("This is serious money");
                euroShow.Content = "Lottery money";
            }

        }
    }
}


//  MessageBox.Show("Euros = " + euros);
//  MessageBox.Show("Cents = " + cents);