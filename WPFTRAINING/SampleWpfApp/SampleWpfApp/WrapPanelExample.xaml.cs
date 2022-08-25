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
using System.Windows.Shapes;

namespace SampleWpfApp
{
    /// <summary>
    /// Interaction logic for WrapPanelExample.xaml
    /// </summary>
    public partial class WrapPanelExample : Window
    {
        public WrapPanelExample()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, RoutedEventArgs e)
        {
            var content = string.Format($"The Name is {txtName.Text}\n The email Address is {txtemail.Text}\n" +
                $"The Phone is {txtPhone.Text}\n The salary is {txtSalary.Text}");
            MessageBox.Show(content);
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            txtName.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }
    }
}
