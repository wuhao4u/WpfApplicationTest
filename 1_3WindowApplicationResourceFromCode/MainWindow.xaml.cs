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

namespace _1_3WindowApplicationResourceFromCode
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
        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            // resource from stack panel
            lbResult.Items.Add(pnlMain.FindResource("strPanel").ToString());

            // from window
            lbResult.Items.Add(this.FindResource("strWindow").ToString());

            // from application
            lbResult.Items.Add(Application.Current.FindResource("strApp").ToString());
        }
    }
}