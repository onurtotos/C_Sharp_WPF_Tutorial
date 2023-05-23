using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Wpf_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //We can make changes by giving the names to our elements.
            myTextBlock1.Text = " Hello from Onur!";
            myTextBlock1.Foreground = Brushes.CornflowerBlue;
           
            myTextBlock1.Inlines.Add(new Run(" Run text that I added in Code behind")
            {
                Foreground = Brushes.Chocolate,
                TextDecorations = TextDecorations.Underline
            });


            TextBlock textBlock = new TextBlock(new Run("A bit of text content..."));

            textBlock.Background = Brushes.AntiqueWhite;
            textBlock.Foreground = Brushes.Navy;

            textBlock.FontFamily = new FontFamily("Century Gothic");
            textBlock.FontSize = 12;
            textBlock.FontStretch = FontStretches.UltraExpanded;
            textBlock.FontStyle = FontStyles.Italic;
            textBlock.FontWeight = FontWeights.UltraBold;

            textBlock.LineHeight = Double.NaN;
            textBlock.Padding = new Thickness(5, 10, 5, 10);
            textBlock.TextAlignment = TextAlignment.Center;
            textBlock.TextWrapping = TextWrapping.Wrap;

            textBlock.Typography.NumeralStyle = FontNumeralStyle.OldStyle;
            textBlock.Typography.SlashedZero = true;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"http://onurtotos.com", UseShellExecute = true });
        }
    }
}
