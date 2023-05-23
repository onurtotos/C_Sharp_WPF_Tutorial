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

namespace Wpf_Images
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

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            myImage.Source = 
            new BitmapImage(new Uri(@"/Wpf_Images;component/Images/araba.jpg",UriKind.Relative));

            //new BitmapImage(new Uri(@"/ProjectName;component/ImageFileName/imagename.extension", UriKind.Relative));
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            myImage.Source =
            new BitmapImage(new Uri(@"/Wpf_Images;component/Images/sa.jpg", UriKind.Relative));
        }
    }
}
