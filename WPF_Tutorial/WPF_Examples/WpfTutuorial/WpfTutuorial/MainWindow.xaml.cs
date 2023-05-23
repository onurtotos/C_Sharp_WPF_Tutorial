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

namespace WpfTutuorial
{
    
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();

            
        }

        //private void btnRun_Click(object sender, RoutedEventArgs e)
        //{
        //    tbHello.Text = "Running";
        //    btnRun.Content = "Stop";
        //    running = true;

        //    MessageBox.Show("Welcome!");
            
            
        //}

        //private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        //{
        //    if (running)
        //    {
        //        //stop
        //        tbStatus.Text = "Stopped";
        //        btnToggleRun.Content = "Run";
        //    }
        //    else
        //    {
        //        //run
        //        tbStatus.Text = "Running";
        //        btnToggleRun.Content = "Stop";
        //    }

        //    running=!running;

        //}
    }
}
