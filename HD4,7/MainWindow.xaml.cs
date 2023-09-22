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

namespace HD4_7
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
            int totalNumberOfSeconds = Convert.ToInt32(valueBox.Text);
            int hours = 3600;
            int minutes = 60;
            int seconds = 1;

            hours = totalNumberOfSeconds / hours;
            totalNumberOfSeconds = totalNumberOfSeconds - 3600 * hours;
            minutes = totalNumberOfSeconds / minutes;
            totalNumberOfSeconds = totalNumberOfSeconds - 60 * minutes;
            seconds = totalNumberOfSeconds / seconds;

            hoursBlock.Text = Convert.ToString(hours);
            minutesBlock.Text = Convert.ToString(minutes);
            secondsBlock.Text = Convert.ToString(seconds);
        }
    }
}
