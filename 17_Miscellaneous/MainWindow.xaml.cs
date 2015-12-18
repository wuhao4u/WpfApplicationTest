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
using System.Windows.Threading;

namespace _17_Miscellaneous
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            //timer.Interval = TimeSpan.FromSeconds(1);
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
