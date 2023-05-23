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

namespace Wpf_Checkboxes
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

       
        private void cbParentCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = cbParent.IsChecked == true;
            cbCheese.IsChecked = newVal;
            cbTomato.IsChecked = newVal;
            cbPep.IsChecked = newVal;
            cbMush.IsChecked = newVal;
        }

        private void cbTopingsCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbParent.IsChecked = null;
            if ((cbCheese.IsChecked==true) && (cbMush.IsChecked== true) && (cbTomato.IsChecked == true) && (cbPep.IsChecked == true))
            {
                cbParent.IsChecked = true;
            }
            if ((cbCheese.IsChecked == false) && (cbMush.IsChecked == false) && (cbTomato.IsChecked == false) && (cbPep.IsChecked == false))
            {
                cbParent.IsChecked = false;
            }


        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is checked.";
        }
        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is unchecked.";
        }
        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is in the indeterminate state.";
        }

    }
}
