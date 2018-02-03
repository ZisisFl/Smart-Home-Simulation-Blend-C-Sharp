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
    /// Interaction logic for smart_fridge.xaml
    /// </summary>
    public partial class smart_fridge : Window
    {
        public smart_fridge()
        {
            InitializeComponent();
        }

        private void browser_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_browser();
            Form.Show();
            this.Hide();
        }

        private void weather_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_weather();
            Form.Show();
            this.Hide();
        }

        private void radio_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_radio();
            Form.Show();
            this.Hide();
        }

        private void internal_indications_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_internal_indications();
            Form.Show();
            this.Hide();
        }

        private void recipes_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_recipes();
            Form.Show();
            this.Hide();
        }

        private void online_shop_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_online_shop();
            Form.Show();
            this.Hide();
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            var Form = new sf_calendar();
            Form.Show();
            this.Hide();
        }

    }
}
