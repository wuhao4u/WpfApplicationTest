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
using System.Threading;

namespace WpfApplicationTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Title = "Clicked";
            //var msg = MessageBox.Show("Hello from WPF");
            //this.IsEnabled = false;
            lblResult.Content = "Commencing long-running operation…";
            Task<string> task1 = Task.Run<string>(() =>
               {
                   // This represents a long-running operation.
                   Thread.Sleep(10000);
                   return "Operation Complete";
               });
            // This statement blocks the UI thread until the task result is available.
            lblResult.Content = task1.Result;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Cast TextBox.
            TextBox box = sender as TextBox;

            // If text is present, enable the button.
            // ... Otherwise disable the button.
            this.btnLongOperation.IsEnabled = box.Text.Length > 0;
        }

        private async void btnAsync_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "Commencing long-running operation…";
            Task<string> task1 = Task.Run<string>(() =>
               {
                   // This represents a long-running operation.
                   Thread.Sleep(10000);
                   return "Operation Complete";
               });
            // This statement is invoked when the result of task1 is available.
            // In the meantime, the method completes and the thread is free to do other work.
            lblResult.Content = await task1;
        }
    }
}
