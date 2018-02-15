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
        int prev_state = 0;
        int curr_state = 0;

        public smart_fridge()
        {
            InitializeComponent();
        }       

        private void browser_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            browser1.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 1;
        }

        private void weather_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            weather_text.Visibility = Visibility.Visible;
            weather_pic.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 2;
        }

        private void radio_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            radio_img.Visibility = Visibility.Visible;
            radio_text.Visibility = Visibility.Visible;
            radio_slider.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 3;
        }

        private void internal_indications_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            internal_indications_text.Visibility = Visibility.Visible;
            humidity_text.Visibility = Visibility.Visible;
            temp.Visibility = Visibility.Visible;
            humidity.Visibility = Visibility.Visible;
            temp_slider.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 4;
        }

        private void recipes_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            recipes1.Visibility = Visibility.Visible;
            search_b.Visibility = Visibility.Visible;
            search_text.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 5;
        }

        private void online_shop_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            kritikosb.Visibility = Visibility.Visible;
            caremarketb.Visibility = Visibility.Visible;
            efreshb.Visibility = Visibility.Visible;
            shop_text.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 6;
        }

        private void calendar_Click(object sender, RoutedEventArgs e)
        {
            home_button_Click(this, null);

            empty.Visibility = Visibility.Visible;
            calendar_pic.Visibility = Visibility.Visible;
            prev_state = curr_state;
            curr_state = 7;
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

        private void temp_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double temperature = e.NewValue;
            temp.Text = String.Format("{0:0.0}", temperature) + "°C";
        }

        private void radio_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = e.NewValue;
            radio_text.Text = String.Format("{0:0.0}", value) + "MHz";
        }

        private void home_button_Click(object sender, RoutedEventArgs e)
        {
            //curr_state = 0;
            //empty canvas
            empty.Visibility = Visibility.Hidden;
            //calendar
            calendar_pic.Visibility = Visibility.Hidden;
            //online shopping
            kritikos.Visibility = Visibility.Hidden;
            efresh.Visibility = Visibility.Hidden;
            care_market.Visibility = Visibility.Hidden;

            kritikosb.Visibility = Visibility.Hidden;
            caremarketb.Visibility = Visibility.Hidden;
            efreshb.Visibility = Visibility.Hidden;
            shop_text.Visibility = Visibility.Hidden;
            //recipes
            recipes1.Visibility = Visibility.Hidden;
            search_b.Visibility = Visibility.Hidden;
            search_text.Visibility = Visibility.Hidden;
            //internal indications
            internal_indications_text.Visibility = Visibility.Hidden;
            humidity_text.Visibility = Visibility.Hidden;
            temp.Visibility = Visibility.Hidden;
            humidity.Visibility = Visibility.Hidden;
            temp_slider.Visibility = Visibility.Hidden;
            //radio
            radio_img.Visibility = Visibility.Hidden;
            radio_text.Visibility = Visibility.Hidden;
            radio_slider.Visibility = Visibility.Hidden;
            //weather
            weather_text.Visibility = Visibility.Hidden;
            weather_pic.Visibility = Visibility.Hidden;
            //browser
            browser1.Visibility = Visibility.Hidden;
        }

        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            if (curr_state == 1)
            {
                browser1.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 2)
            {
                weather_text.Visibility = Visibility.Hidden;
                weather_pic.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 3)
            {
                radio_img.Visibility = Visibility.Hidden;
                radio_text.Visibility = Visibility.Hidden;
                radio_slider.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 4)
            {
                internal_indications_text.Visibility = Visibility.Hidden;
                humidity_text.Visibility = Visibility.Hidden;
                temp.Visibility = Visibility.Hidden;
                humidity.Visibility = Visibility.Hidden;
                temp_slider.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 5)
            {
                recipes1.Visibility = Visibility.Hidden;
                search_b.Visibility = Visibility.Hidden;
                search_text.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 6)
            {
                kritikos.Visibility = Visibility.Hidden;
                efresh.Visibility = Visibility.Hidden;
                care_market.Visibility = Visibility.Hidden;

                kritikosb.Visibility = Visibility.Hidden;
                caremarketb.Visibility = Visibility.Hidden;
                efreshb.Visibility = Visibility.Hidden;
                shop_text.Visibility = Visibility.Hidden;
            }
            else if (curr_state == 7)
            {
                calendar_pic.Visibility = Visibility.Hidden;
            }



            if (prev_state == 1)
            {
                browser1.Visibility = Visibility.Visible;
            }
            else if (prev_state == 2)
            {
                weather_text.Visibility = Visibility.Visible;
                weather_pic.Visibility = Visibility.Visible;
            }
            else if (prev_state == 3)
            {
                radio_img.Visibility = Visibility.Visible;
                radio_text.Visibility = Visibility.Visible;
                radio_slider.Visibility = Visibility.Visible;
            }
            else if (prev_state == 4)
            {
                internal_indications_text.Visibility = Visibility.Visible;
                humidity_text.Visibility = Visibility.Visible;
                temp.Visibility = Visibility.Visible;
                humidity.Visibility = Visibility.Visible;
                temp_slider.Visibility = Visibility.Visible;
            }
            else if (prev_state == 5)
            {
                recipes1.Visibility = Visibility.Visible;
                search_b.Visibility = Visibility.Visible;
                search_text.Visibility = Visibility.Visible;
            }
            else if (prev_state == 6)
            {
                kritikos.Visibility = Visibility.Visible;
                efresh.Visibility = Visibility.Visible;
                care_market.Visibility = Visibility.Visible;

                kritikosb.Visibility = Visibility.Visible;
                caremarketb.Visibility = Visibility.Visible;
                efreshb.Visibility = Visibility.Visible;
                shop_text.Visibility = Visibility.Visible;
            }
            else if (prev_state == 7)
            {
                calendar_pic.Visibility = Visibility.Visible;
            }
            else if (prev_state == 0)
            {
                home_button_Click(this, null);
            }
        }
    }
}
