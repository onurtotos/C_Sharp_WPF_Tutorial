using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_OpenF_Dialog
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

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            //creating object to use OpenFileDialog Class
            OpenFileDialog oFd = new OpenFileDialog();

            //The code below is used for showing the files window
            //oFd.ShowDialog();

            //Setting up the default directory once it clicked
            oFd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //You can also set up the default directory by using following code;
            oFd.InitialDirectory = @"C:\";

            //OR you can use the folloing code to make it more specific
            oFd.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..");

            //Filtering file types
            oFd.Filter = "Text files (*.text)|*.txt|All Files(*.*)|*.*";

            //Restoring the containing information from file to our Textbox
            if (oFd.ShowDialog()==true)
            {
                myTextbox.Text = File.ReadAllText(oFd.FileName);
               
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            //Create and Save a text file or any file that will help you out.
            SaveFileDialog sFd = new SaveFileDialog();
            sFd.Filter = "Text files (*.text)|*.txt|All Files(*.*)|*.*";
            if (sFd.ShowDialog()==true)
            {
                File.WriteAllText(sFd.FileName, myTextbox.Text);
            }
        }
    }
}
