﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _10_MiscControls
{
    /// <summary>
    /// WindowsFormsHostControl.xaml 的交互逻辑
    /// </summary>
    public partial class WindowsFormsHostControl : Window
    {
        public WindowsFormsHostControl()
        {
            InitializeComponent();
        }

        private void wbWinForms_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Title = (sender as System.Windows.Forms.WebBrowser).DocumentTitle;
        }
    }
}
