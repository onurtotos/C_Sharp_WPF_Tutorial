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

namespace Wpf_Buttons
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

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Foreground = Brushes.DarkBlue;
            myLabel.Foreground = Brushes.Red;
            myLabel.FontSize = myLabel.FontSize + 10;
        }

        private void myButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            myLabel.FontSize = myLabel.FontSize -5;
        }

        private void myButton_MouseEnter(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.DarkOrange;
        }

        private void myButton_MouseLeave(object sender, MouseEventArgs e)
        {
            myLabel.Foreground = Brushes.DarkSeaGreen;
        }
        void OnClick1(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.LightBlue;
        }

        void OnClick2(object sender, RoutedEventArgs e)
        {
            btn2.Background = Brushes.Pink;
        }

        void OnClick3(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Pink;
            btn2.Background = Brushes.LightBlue;
        }
    }
}
