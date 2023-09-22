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

namespace SomeShapes
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            //Maak een nieuwe rechthoek
            Rectangle upperRectangle = new Rectangle();
            upperRectangle.Width = 100;
            upperRectangle.Height = 50;
            upperRectangle.Margin = new Thickness(10, 10, 0, 0);
            upperRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(upperRectangle);

            //Maak een streep door de rechthoek
            Line lineInRectangle = new Line();
            lineInRectangle.X1 = 10;
            lineInRectangle.Y1 = 10;
            lineInRectangle.X2 = 110;
            lineInRectangle.Y2 = 60;
            lineInRectangle.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(lineInRectangle);

            //Maak een nieuwe rechthoek
            Rectangle leftRect = new Rectangle();
            leftRect.Width = 100;
            leftRect.Height = 50;
            leftRect.Margin = new Thickness(10, 80, 0, 0);
            leftRect.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(leftRect);

            //Maak een circel door de rechthoek
            Ellipse leftElip = new Ellipse();
            leftElip.Width = 100;
            leftElip.Height = 50;
            leftElip.Margin = new Thickness(10, 80, 0, 0);
            leftElip.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(leftElip);

            //Maak een circel
            Ellipse bottomElip = new Ellipse();
            bottomElip.Width = 100;
            bottomElip.Height = 50;
            bottomElip.Margin = new Thickness(10, 150, 0, 0);
            bottomElip.Fill = new SolidColorBrush(Colors.Gray);
            paperCanvas.Children.Add(bottomElip);

            //Maak een BitMapImage
            BitmapImage demo = new BitmapImage();
            demo.BeginInit();
            demo.UriSource = new Uri(@"D:\RocMN\Test.jpg", UriKind.RelativeOrAbsolute);
            demo.EndInit();
            Image rightImg = new Image();
            rightImg.Source = demo;
            rightImg.Margin = new Thickness(120, 10, 0, 0);
            rightImg.Width = 150;
            rightImg.Height = 150;
            paperCanvas.Children.Add(rightImg);
            
        }
    }
}
