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
        string value;

        public smart_fridge()
        {
            InitializeComponent();
        }       

        private void browser_Click(object sender, RoutedEventArgs e)
        {
            browser1.Visibility = Visibility.Visible;
        }

        private void weather_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            weather_text.Visibility = Visibility.Visible;
            weather_pic.Visibility = Visibility.Visible;
        }

        private void radio_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            radio_img.Visibility = Visibility.Visible;
            radio_text.Visibility = Visibility.Visible;
            slider.Visibility = Visibility.Visible;
        }

        private void internal_indications_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            internal_indications_text.Visibility = Visibility.Visible;
            temp_text.Visibility = Visibility = Visibility.Visible;
            humidity_text.Visibility = Visibility.Visible;
            temp.Visibility = Visibility.Visible;
            humidity.Visibility = Visibility.Visible;
            temp_slider.Visibility = Visibility.Visible;
        }

        private void recipes_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            recipes1.Visibility = Visibility.Visible;
            search_b.Visibility = Visibility.Visible;
            search_text.Visibility = Visibility.Visible;
        }

        private void online_shop_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            kritikosb.Visibility = Visibility.Visible;
            caremarketb.Visibility = Visibility.Visible;
            efreshb.Visibility = Visibility.Visible;
            shop_text.Visibility = Visibility.Visible;
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            empty.Visibility = Visibility.Visible;
            calendar_pic.Visibility = Visibility.Visible;
        }

        private void caremarketb_Click(object sender, RoutedEventArgs e)
        {
            care_market.Visibility = Visibility.Visible;

            efresh.Visibility = Visibility.Hidden;
            kritikos.Visibility = Visibility.Hidden;
        }

        private void efreshb_Click(object sender, RoutedEventArgs e)
        {
            efresh.Visibility = Visibility.Visible;

            care_market.Visibility = Visibility.Hidden;
            kritikos.Visibility = Visibility.Hidden;
        }

        private void kritikosb_Click(object sender, RoutedEventArgs e)
        {
            kritikos.Visibility = Visibility.Visible;

            efresh.Visibility = Visibility.Hidden;
            care_market.Visibility = Visibility.Hidden;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = e.NewValue;
            radio_text.Text = String.Format("{0:000.0}", value);
        }

        private void save_station_Click(object sender, RoutedEventArgs e)
        {
            station_text.Text = value;
        }

        private void temp_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double temperature = e.NewValue;
            temp.Text = String.Format("{0:0.0}", temperature) + "°C";
        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
