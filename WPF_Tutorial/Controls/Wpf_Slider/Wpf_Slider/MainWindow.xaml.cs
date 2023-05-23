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

namespace Wpf_Slider
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

        private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //if (myTextblock != null && mySlider.Value>0.0)
            //{
            //    myTextblock.Text = "Slider value is: " + mySlider.Value.ToString();
            //    myTextblock.FontSize = mySlider.Value;
            //}
           myTextblock.Text = "Slider value is: " + mySlider.Value.ToString();
        }
    }
}
