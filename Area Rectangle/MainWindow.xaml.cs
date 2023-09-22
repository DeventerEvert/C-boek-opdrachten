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

namespace Area_Rectangle
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

        private void calcTriangle_Click(object sender, RoutedEventArgs e)
        {
            int area;
            int length;
            int width;
            length = Convert.ToInt32(lengthBox.Text);
            width = Convert.ToInt32(widthBox.Text);
            area = length * width;
            MessageBox.Show("Area is: " + area);


        }


    }
}
