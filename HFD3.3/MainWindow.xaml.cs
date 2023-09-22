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

namespace HFD3._3
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
            vertLine.Y1 = 800;
            vertLine.X2 = 266.66;
            vertLine.Y2 = 200;
            vertLine.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(vertLine);

            Line vertLine2 = new Line();
            vertLine2.X1 = 523.33;
            vertLine2.Y1 = 800;
            vertLine2.X2 = 523.33;
            vertLine2.Y2 = 200;
            vertLine2.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(vertLine2);

            Line leftLeg = new Line();
            leftLeg.X1 = 20;
            leftLeg.Y1 = 80;
            leftLeg.X2 = 165;
            leftLeg.Y2 = 10;
            leftLeg.Margin = new Thickness(235, 120, 0, 0);
            leftLeg.Stroke = new SolidColorBrush(Colors.Yellow);

            Line rightLeg = new Line();
            rightLeg.X1 = 150;
            rightLeg.Y1 = 10;
            rightLeg.X2 = 288;
            rightLeg.Y2 = 80;
            rightLeg.Margin = new Thickness(250, 120, 0, 0);
            rightLeg.Stroke = new SolidColorBrush(Colors.Yellow);

            Line triangleBase = new Line();
            triangleBase.X1 = 300;
            triangleBase.Y1 = 80;
            triangleBase.X2 = 20;
            triangleBase.Y2 = 80;
            triangleBase.Margin = new Thickness(236, 120, 0, 0);
            triangleBase.Stroke = new SolidColorBrush(Colors.Yellow);

            Ellipse windowEllipse = new Ellipse();
            windowEllipse.Width = 50;
            windowEllipse.Height = 50;
            windowEllipse.Margin = new Thickness(372, 143, 0, 0);
            windowEllipse.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(windowEllipse);

            Rectangle windowRectangle = new Rectangle();
            windowRectangle.Width = 50; 
            windowRectangle.Height = 100;
            windowRectangle.Margin = new Thickness(436, 360, 0, 0);
            windowRectangle.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(windowRectangle);

            Rectangle windowRectangle2 = new Rectangle();
            windowRectangle2.Width = 80;
            windowRectangle2.Height = 30;
            windowRectangle2.Margin = new Thickness(290, 260, 0, 0);
            windowRectangle2.Stroke = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(windowRectangle2);


            paperCanvas.Children.Add(leftLeg);
            paperCanvas.Children.Add(rightLeg);
            paperCanvas.Children.Add(triangleBase);
        }
    }
}
