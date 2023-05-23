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

namespace WpfBasics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The description is: " + this.DescriptionText.Text);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheck.IsChecked = this.AssemblyCheck.IsChecked = false;
            this.PlasmaCheck.IsChecked = this.LaserCheck.IsChecked = this.PurchaseCheck.IsChecked =
            this.LatheCheck.IsChecked = this.DrillCheck.IsChecked = this.FoldCheck.IsChecked =
            this.RollCheck.IsChecked = false;
            this.SawCheck.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {

           this.LengthTextBox.Text += (string)((CheckBox)(sender)).Content +"," ;
        }

        private void Checkbox_Unchecked(object sender, RoutedEventArgs e)
        {
            
            if (((CheckBox)(sender)).IsChecked == false)
            {
                
                this.LengthTextBox.Text = this.LengthTextBox.Text.Replace((string)((CheckBox)(sender)).Content," ");
            }

        }

        private void Robber_SelectionChanged(object sender, SelectionChangedEventArgs? e)
        {
            if (this.NoteText==null)
            {
                return;
            }

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteText.Text = (string)value.Content; 
        }

        private void Window_Loaded(object sender, RoutedEventArgs? e)
        {
            Robber_SelectionChanged(this.Robber, null);
        }

        private void Supplier_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Massive.Text = this.Supplier.Text;
        }
    }
}
