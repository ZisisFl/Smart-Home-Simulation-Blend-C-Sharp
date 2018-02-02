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
    /// Interaction logic for kitchen.xaml
    /// </summary>
    public partial class kitchen : Window
    {
        public kitchen()
        {
            InitializeComponent();
        }

        private void bedroom_k_Click(object sender, RoutedEventArgs e)
        {
            var Form = new bedroom();
            Form.Show();
            this.Hide();
        }

        private void living_room_k_Click(object sender, RoutedEventArgs e)
        {
            var Form = new living_roo();
            Form.Show();
            this.Hide();
        }

        private void image_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Form = new s_phone();
            Form.Show();
        }

        private void smart_fridge_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Form = new smart_fridge();
            Form.Show();
            this.Hide();
        }
    }
}
