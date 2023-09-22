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

namespace Hfd3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

            Line leftLeg = new Line();
            leftLeg.X1 = 20;
            leftLeg.Y1 = 80;
            leftLeg.X2 = 70;
            leftLeg.Y2 = 10;
            leftLeg.Stroke = new SolidColorBrush(Colors.Black);

            Line rightLeg = new Line();
            rightLeg.X1 = 70;
            rightLeg.Y1 = 10;
            rightLeg.X2 = 120;
            rightLeg.Y2 = 80;
            rightLeg.Stroke = new SolidColorBrush(Colors.Black);

            Line triangleBase = new Line();
            triangleBase.X1 = 120;
            triangleBase.Y1 = 80;
            triangleBase.X2 = 20;
            triangleBase.Y2 = 80;
            triangleBase.Stroke = new SolidColorBrush(Colors.Black);

            paperCanvas.Children.Add(leftLeg);
            paperCanvas.Children.Add(rightLeg);
            paperCanvas.Children.Add(triangleBase);


        }
    }
}
