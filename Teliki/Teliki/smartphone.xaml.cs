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

namespace Teliki
{
    /// <summary>
    /// Interaction logic for kinito.xaml
    /// </summary>
    public partial class s_phone : Window
    {
        public s_phone()
        {
            InitializeComponent();
        }

        private void internal_view_Click(object sender, RoutedEventArgs e)
        {
            fridge_inside.Visibility = Visibility.Visible;
        }

        private void back_phone_Click(object sender, RoutedEventArgs e)
        {
            fridge_inside.Visibility = Visibility.Hidden;
        }
    }
}
