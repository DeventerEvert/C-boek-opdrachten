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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HFD3._6
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

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
           Ellipse headShape = new Ellipse();
            headShape.Width = 150;
            headShape.Height = 200;
            headShape.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            headShape.Margin = new Thickness(60, 80, 300, 0);
            paperCanvas.Children.Add(headShape);

            Ellipse eyeShape = new Ellipse();
            eyeShape.Width = 20;
            eyeShape.Height = 20;
            eyeShape.Fill = new SolidColorBrush(Colors.White);
            eyeShape.Margin = new Thickness(105, 130, 100, 0);
            paperCanvas.Children.Add(eyeShape);

            Ellipse eyeShape2 = new Ellipse();
            eyeShape2.Width = 20;
            eyeShape2.Height = 20;
            eyeShape2.Fill = new SolidColorBrush(Colors.White);
            eyeShape2.Margin = new Thickness(155, 130, 100, 0);
            paperCanvas.Children.Add(eyeShape2);

            Ellipse eyelid = new Ellipse();
            eyelid.Width = 10;
            eyelid.Height = 10;
            eyelid.Fill = new SolidColorBrush(Colors.Black);
            eyelid.Margin = new Thickness(110, 135, 105, 0);
            paperCanvas.Children.Add(eyelid);

            Ellipse eyeLid1 = new Ellipse();
            eyeLid1.Width = 10;
            eyeLid1.Height = 10;
            eyeLid1.Fill = new SolidColorBrush(Colors.Black);
            eyeLid1.Margin = new Thickness(160, 135, 110, 0);
            paperCanvas.Children.Add(eyeLid1);

            Ellipse mouthFace = new Ellipse();
            mouthFace.Width = 80;
            mouthFace.Height = 20;
            mouthFace.Fill = new SolidColorBrush(Colors.White);
            mouthFace.Margin = new Thickness(100, 200, 110, 0);
            paperCanvas.Children.Add(mouthFace);


            Ellipse leftEar = new Ellipse();
            leftEar.Width = 15;
            leftEar.Height = 40;
            leftEar.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            leftEar.Margin = new Thickness(55, 135, 110, 0);
            paperCanvas.Children.Add(leftEar);

            Ellipse rightEar = new Ellipse();
            rightEar.Width = 15;
            rightEar.Height = 40;
            rightEar.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            rightEar.Margin = new Thickness(200, 130, 110, 0);
            paperCanvas.Children.Add(rightEar);

            Ellipse noseFace = new Ellipse();
            noseFace.Width = 20;
            noseFace.Height = 20;
            noseFace.Fill = new SolidColorBrush(Colors.BurlyWood);
            noseFace.Margin = new Thickness(130, 160, 110, 0);
            paperCanvas.Children.Add(noseFace);


        }
    }
}
