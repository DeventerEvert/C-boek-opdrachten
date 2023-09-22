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

namespace HD4._2
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
           double radius = Convert.ToInt32(inputBox.Text);
           double circumference = 2 * Math.PI * radius;
           double area = Math.PI * Math.Pow(radius, 2);
           double volume = (4 * Math.PI / 3) * Math.Pow(radius, 3);


           string omtrek =  $"De omtrek van de bol is {(float)System.Math.Round(circumference, 2)} diameter";        
           string oppervlak = $"Het oppervlak van de bol is {(float)System.Math.Round(area, 2)} diameter";
           string volumeBol = $"De volume van de bol is {(float)System.Math.Round(volume, 2)} diameter";

            oppervlakBlok.Text = oppervlak;
            omtrekBlok.Text = omtrek;
            volumeBlok.Text = volumeBol;

        }
    }
}

//Om af te ronden na 2 cijfers achter de punt doe je de volgende berekening x100 -> afronden naar INT -> / 100;
