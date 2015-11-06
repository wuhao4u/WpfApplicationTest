﻿using System;
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

namespace _2_2BasicControls2
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

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }

        private void cbAllFeatures_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllFeatures.IsChecked == true);
            cbFeatureAbc.IsChecked = newVal;
            cbFeatureXyz.IsChecked = newVal;
            cbFeatureWww.IsChecked = newVal;
        }

        private void cbFeature_CheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllFeatures.IsChecked = null;
            if ((cbFeatureAbc.IsChecked == true) && (cbFeatureXyz.IsChecked == true) && (cbFeatureWww.IsChecked == true))
                cbAllFeatures.IsChecked = true;
            if ((cbFeatureAbc.IsChecked == false) && (cbFeatureXyz.IsChecked == false) && (cbFeatureWww.IsChecked == false))
                cbAllFeatures.IsChecked = false;
        }
    }
}
