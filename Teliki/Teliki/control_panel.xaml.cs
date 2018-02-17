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

namespace Teliki
{
    /// <summary>
    /// Interaction logic for control_panel.xaml
    /// </summary>
    public partial class control_panel : Window
    {
        living_roo l_r = new living_roo();
        kitchen k = new kitchen();
        bedroom b = new bedroom();

        public control_panel()
        {
            InitializeComponent();    
        }

        private void lights_l_Checked(object sender, RoutedEventArgs e)
        {
            l_r.lights.Visibility = Visibility.Visible;
            l_r.Show();
        }

        private void lights_l_Unchecked(object sender, RoutedEventArgs e)
        {
            l_r.lights.Visibility = Visibility.Hidden;
        }

        private void lights_k_Checked(object sender, RoutedEventArgs e)
        {
            k.lights.Visibility = Visibility.Visible;
            k.Show();
        }

        private void lights_k_Unchecked(object sender, RoutedEventArgs e)
        {
            k.lights.Visibility = Visibility.Hidden;
        }

        private void lights_b_Checked(object sender, RoutedEventArgs e)
        {
            b.lights.Visibility = Visibility.Visible;
            b.Show();
        }

        private void lights_b_Unchecked(object sender, RoutedEventArgs e)
        {
            b.lights.Visibility = Visibility.Hidden;
        }

        private void kalorifer_l_Checked(object sender, RoutedEventArgs e)
        {
            aircondition_l.IsChecked = false;
            l_r.c_temp_text.Text = "20.0°C";
            l_r.c_temp_text.Foreground = Brushes.Red;
            l_r.c_temp_text.Visibility = Visibility.Visible;
            l_r.Show();
        }

        private void kalorifer_l_Unchecked(object sender, RoutedEventArgs e)
        {
            l_r.c_temp_text.Visibility = Visibility.Hidden;
        }

        private void kalorifer_b_Checked(object sender, RoutedEventArgs e)
        {
            aircondition_b.IsChecked = false;
            b.c_temp_text.Text = "20.0°C";
            b.c_temp_text.Foreground = Brushes.Red;
            b.c_temp_text.Visibility = Visibility.Visible;
            b.Show();
        }

        private void kalorifer_b_Unchecked(object sender, RoutedEventArgs e)
        {
            b.c_temp_text.Visibility = Visibility.Hidden;
        }

        private void kalorifer_k_Checked(object sender, RoutedEventArgs e)
        {
            k.c_temp_text.Text = "20.0°C";
            k.c_temp_text.Foreground = Brushes.Red;
            k.c_temp_text.Visibility = Visibility.Visible;
            k.Show();
        }

        private void kalorifer_k_Unchecked(object sender, RoutedEventArgs e)
        {
            k.c_temp_text.Visibility = Visibility.Hidden;
        }

        private void aircondition_b_Checked(object sender, RoutedEventArgs e)
        {
            kalorifer_b.IsChecked = false;
            b.c_temp_text.Text = "24.0°C";
            b.c_temp_text.Foreground = Brushes.Blue;
            b.c_temp_text.Visibility = Visibility.Visible;
            b.Show();

        }

        private void aircondition_b_Unchecked(object sender, RoutedEventArgs e)
        {
            b.c_temp_text.Visibility = Visibility.Hidden;
        }

        private void aircondition_l_Checked(object sender, RoutedEventArgs e)
        {
            kalorifer_l.IsChecked = false;
            l_r.c_temp_text.Text = "24.0°C";
            l_r.c_temp_text.Foreground = Brushes.Blue;
            l_r.c_temp_text.Visibility = Visibility.Visible;
            l_r.Show();
        }

        private void aircondition_l_Unchecked_1(object sender, RoutedEventArgs e)
        {
            l_r.c_temp_text.Visibility = Visibility.Hidden;
        }

        private void sound_system_Checked(object sender, RoutedEventArgs e)
        {
            l_r.sound_text.Visibility = Visibility.Visible;
            l_r.Show();
        }

        private void sound_system_Unchecked(object sender, RoutedEventArgs e)
        {
            l_r.sound_text.Visibility = Visibility.Hidden;
        }

        private void tv_Checked(object sender, RoutedEventArgs e)
        {
            l_r.tv_open.Visibility = Visibility.Visible;
            l_r.Show();
        }

        private void tv_Unchecked(object sender, RoutedEventArgs e)
        {
            l_r.tv_open.Visibility = Visibility.Hidden;
        }
    }
}
