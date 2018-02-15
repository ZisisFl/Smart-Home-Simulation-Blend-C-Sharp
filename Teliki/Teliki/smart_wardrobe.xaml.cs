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
    /// Interaction logic for smart_wardrobe.xaml
    /// </summary>
    public partial class smart_wardrobe : Window
    {
        bool gender_clicked = true;

        public smart_wardrobe()
        {
            InitializeComponent();
        }

        private void male_Click(object sender, RoutedEventArgs e)
        {
            gender_clicked = true;
                male.Background = Brushes.Black;
                male.Foreground = Brushes.White;
                female.Background = Brushes.White;
                female.Foreground = Brushes.Black;                          
        }

        private void female_Click(object sender, RoutedEventArgs e)
        {
            gender_clicked = false;
            female.Background = Brushes.Black;
            female.Foreground = Brushes.White;
            male.Background = Brushes.White;
            male.Foreground = Brushes.Black;
        }

        private void everyday_Click(object sender, RoutedEventArgs e)
        {
            Hide_Prev();

            if (gender_clicked == true)
                everyday_m.Visibility = Visibility.Visible;
            else
                everyday_w.Visibility = Visibility.Visible;
        }

        private void formal_Click(object sender, RoutedEventArgs e)
        {
            Hide_Prev();

            if (gender_clicked == true)
                formal_m.Visibility = Visibility.Visible;
            else
                formal_w.Visibility = Visibility.Visible;
        }

        private void gym_Click(object sender, RoutedEventArgs e)
        {
            Hide_Prev();

            if (gender_clicked == true)
                gym_m.Visibility = Visibility.Visible;
            else
                gym_w.Visibility = Visibility.Visible;
        }

        private void work_Click(object sender, RoutedEventArgs e)
        {
            Hide_Prev();

            if (gender_clicked == true)
                work_m.Visibility = Visibility.Visible;
            else
                work_w.Visibility = Visibility.Visible;
        }

        public void Hide_Prev()
        {
            everyday_m.Visibility = Visibility.Hidden;
            everyday_w.Visibility = Visibility.Hidden;
            formal_m.Visibility = Visibility.Hidden;
            formal_w.Visibility = Visibility.Hidden;
            gym_m.Visibility = Visibility.Hidden;
            gym_w.Visibility = Visibility.Hidden;
            work_m.Visibility = Visibility.Hidden;
            work_w.Visibility = Visibility.Hidden;
        }
    }
}
