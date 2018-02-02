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
    /// Interaction logic for bedroom.xaml
    /// </summary>
    public partial class bedroom : Window
    {
        public bedroom()
        {
            InitializeComponent();
        }

        private void kitchen_b_Click(object sender, RoutedEventArgs e)
        {
            var Form = new kitchen();
            Form.Show();
            this.Hide();
        }

        private void living_room_b_Click(object sender, RoutedEventArgs e)
        {
            var Form = new living_roo();
            Form.Show();
            this.Hide();
        }

        private void image_Copy_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var Form = new s_phone();
            Form.Show();
        }
    }
}
