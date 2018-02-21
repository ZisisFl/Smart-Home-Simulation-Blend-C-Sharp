using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Teliki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class living_roo : Window
    {
        public living_roo()
        {
            InitializeComponent();
        }

        private void bedroom_l_Click(object sender, RoutedEventArgs e)
        {
            var Form = new bedroom();
            Form.Show();
            this.Hide();
        }

        private void kitchen_l_Click(object sender, RoutedEventArgs e)
        {
            var Form = new kitchen();
            Form.Show();
            this.Hide();
        }

        private void image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Form = new s_phone();
            Form.Show();
        }

        private void control_panel_Click(object sender, RoutedEventArgs e)
        {
            var Form = new control_panel();
            Form.Show();
        }

        private void help_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("Help.chm");
        }
    }
}
