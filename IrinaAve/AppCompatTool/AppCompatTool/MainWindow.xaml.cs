using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AppCompatTool
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

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BrowseSourceFolderButtonClick(object sender, RoutedEventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            openDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory;

            var dialogResult = openDialog.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                sourceFolderEditBox.Text = openDialog.SelectedPath;
            }
        }

        private void BrowseDestinationFolderButtonClick(object sender, RoutedEventArgs e)
        {
            var openDialog = new FolderBrowserDialog();
            openDialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var dialogResult = openDialog.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                destinationFolderEditBox.Text = openDialog.SelectedPath;
            }

            //var openDialog = new Microsoft.Win32.OpenFileDialog();
            //openDialog.Filter = "Text documents (.txt)|*.txt";
            //var dialogResult = openDialog.ShowDialog();
            //if (dialogResult == true)
            //{
            //}
        }
    }
}
