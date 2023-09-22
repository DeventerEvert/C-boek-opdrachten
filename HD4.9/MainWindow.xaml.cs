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

namespace HD4._9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            selectionBox.Items.Add("Cola - 50 Cent");
            selectionBox.Items.Add("Fanta - 75 Cent");
            selectionBox.Items.Add("Sprite - 100 Cent");


        }

        private void calcBtn_Click(object sender, RoutedEventArgs e)
        {
            //Software voor automaat.
            //Alle dranken kosten minder dan 2 euro, dit is ook de grootste munt die erin kan.
            //Programma moet wisselgeld berekenen met zo min mogelijk munten, resultaat tonen met meerdere labels van 1 euro, tot 1 cent.



            int amountGiven = Convert.ToInt32(valueBox.Text);
            int itemCost;
            int valueChange = 0;

            int cola = 50;
            int fanta = 75;
            int sprite = 100;

            int euro = 100;
            int cent50 = 50;
            int cent20 = 20;
            int cent10 = 10;
            int cent5 = 5;
            int cent2 = 2;
            int cent1 = 1;


            if (selectionBox.SelectedIndex == 0)
            {
                itemCost = cola;
                valueChange = amountGiven - itemCost;
            } 
            else if(selectionBox.SelectedIndex == 1)
            {
                itemCost = fanta;
                valueChange = amountGiven - itemCost;
            } 
            else if(selectionBox.SelectedIndex == 2){
                itemCost = sprite;
                valueChange = amountGiven - itemCost;
            }
            int totalValue;
            totalValue = valueChange / euro;
            valueChange = valueChange - euro * totalValue;
            cent100Box.Text = totalValue.ToString();
            totalValue = valueChange / cent50;
            valueChange = valueChange - cent50 * totalValue;
            cent50Box.Text = totalValue.ToString();
            totalValue = valueChange / cent20;
            valueChange = valueChange - cent20 * totalValue;
            cent20Box.Text = totalValue.ToString();
            totalValue = valueChange / cent10;
            valueChange = valueChange - cent10 * totalValue;
            cent10Box.Text = totalValue.ToString();
            totalValue = valueChange / cent5;
            valueChange = valueChange - cent5 * totalValue;
            cent5Box.Text = totalValue.ToString();
            totalValue = valueChange / cent2;
            valueChange = valueChange - cent2 * totalValue;
            cent2Box.Text = totalValue.ToString();
            totalValue = valueChange / cent1;
            valueChange = valueChange - cent1 * totalValue;
            cent1Box.Text = totalValue.ToString();







        }
    }
}
