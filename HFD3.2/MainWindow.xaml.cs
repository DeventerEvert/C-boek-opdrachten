using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HFD3._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Line vertLine = new Line();
            vertLine.X1 = 266.66;
            vertLine.Y1 = 450;
            vertLine.X2 = 266.66;
            vertLine.Y2 = 0;
            vertLine.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(vertLine);

            Line vertLine2 = new Line();
            vertLine2.X1 = 533.33;
            vertLine2.Y1 = 450;
            vertLine2.X2 = 533.33;
            vertLine2.Y2 = 0;
            vertLine2.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(vertLine2);

            Line horiLine = new Line();
            horiLine.Y1 = 150;
            horiLine.X2 = 800;
            horiLine.Y2 = 150;
            horiLine.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(horiLine);

            Line horiLine2 = new Line();
            horiLine2.Y1 = 300;
            horiLine2.X2 = 800;
            horiLine2.Y2 = 300;
            horiLine2.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(horiLine2);

            canvasBorder.BorderThickness = new Thickness(1);
        }
    }
}
