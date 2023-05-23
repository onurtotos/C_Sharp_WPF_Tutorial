﻿using System;
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

namespace WpfApp_TreeViews_ValueConverters
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion


        #region On Loaded

        /// <summary>
        /// When the application first opens
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //Get every logical drive on the machine
            foreach (var drive in Directory.GetLogicalDrives())
            {

                //Create a new item for it
                var item = new TreeViewItem();

                //Set the header 
                item.Header = drive;
                //Set the path
                item.Tag = drive;

                //Expanding items
                item.Items.Add(null);

                //Listen out for item being expanded
                item.Expanded += Folder_Expanded;

                //Add it to the main tree-view
                FolderView.Items.Add(item);
            }

        }

        #endregion


        #region Folder Expanded
        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {

            #region Initial Checks

            var item = (TreeViewItem)sender;

            //If the item only contains the dummy data
            if (item.Items.Count != 1 || item.Items[0] != null)
            {
                return;
            }

            //Clear dummy data
            item.Items.Clear();

            //Get full path
            var fullPath = (string)item.Tag;


            #endregion

            #region Get Folders
            //Create a blank list for directories
            var directories = new List<string>();


            //try and get directories from the folder by ignoring any issues 
            try
            {

                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                {
                    directories.AddRange(dirs);
                }
            }
            catch
            { }

            //For each directory..
            directories.ForEach(directoryPath =>
            {
                //Create directory item
                var subItem = new TreeViewItem()
                {

                    //Set header as folder name
                    Header = GetFileFolderName(directoryPath),
                    //and tag as full path
                    Tag = directoryPath
                };


                //Add dummy item so we can expand folder
                subItem.Items.Add(null);

                //Handle expanding
                subItem.Expanded += Folder_Expanded;

                //add this item to the parent
                item.Items.Add(subItem);
            });
            #endregion


            #region Get Files
            //Create a blank list for files
            var files = new List<string>();


            //try and get files from the folder by ignoring any issues 
            try
            {

                var fs = Directory.GetFiles(fullPath);
                if (fs.Length > 0)
                {
                    files.AddRange(fs);
                }
            }
            catch
            { }

            //For each file..
            files.ForEach(filePath =>
              {
                  //Create file item
                  var subItem = new TreeViewItem()
                {

                      //Set header as file name
                      Header = GetFileFolderName(filePath),
                    //and tag as full path
                    Tag = filePath
                };
                
                
                //add this item to the parent
                item.Items.Add(subItem);
              });

            #endregion
        }
        #endregion


        #region Helpers

        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="path"> The full path</param>
        /// <returns></returns>
        public static string GetFileFolderName(string path)
        {
            //C:\Something\a folder
            //C:\Something/a folder
            //a file file.png


            //if we have no path;
            if (string.IsNullOrEmpty(path))
            {
                return string.Empty;
            }

            //change all slashes to back slashes
            var normalizedPath = path.Replace('/', '\\');

            //find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            //If we don't find a backslash, return the path itself
            if (lastIndex <= 0)
            {
                return path;
            }

            //return the name after the last back slash
            return path.Substring(lastIndex + 1);
        }

        #endregion
    }
}
