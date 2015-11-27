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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace _7_1Dialogs
{
    /// <summary>
    /// OpenFileDialog.xaml 的交互逻辑
    /// </summary>
    public partial class OpenFileDialog : Window
    {
        public OpenFileDialog()
        {
            InitializeComponent();
        }

        //private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        //{
        //    Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
        //    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
        //    if (openFileDialog.ShowDialog() == true)
        //        txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        //}
        private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                    lbFiles.Items.Add(System.IO.Path.GetFileName(filename));
            }
        }
    }
}
