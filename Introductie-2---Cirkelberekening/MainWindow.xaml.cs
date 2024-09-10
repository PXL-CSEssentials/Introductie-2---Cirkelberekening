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

namespace Introductie_2___Cirkelberekening
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Omtrek berekenen.
            string radiusTekst = radiusTextBox.Text;

            float radius = Convert.ToSingle(radiusTekst);
            float circumference = 2.0f * (float)Math.PI * radius;
            circumferenceTextBox.Text = Convert.ToString(circumference);

            // Oppervlakte berekenen.
            float surface = (float)(Math.PI * Math.Pow(radius, 2));
            surfaceTextBox.Text = Convert.ToString(surface);

            // Focus naar object verplaatsen.
            clearButton.Focus();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            radiusTextBox.Text = "0";
            circumferenceTextBox.Text = "0";
            surfaceTextBox.Text = "0";

            // Focus naar object verplaatsen.
            radiusTextBox.Focus();
        }
    }
}
