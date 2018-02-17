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
            //first button
            fridge_inside.Visibility = Visibility.Hidden;
            //second button
            products.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;
            checkBox.Visibility = Visibility.Hidden;
            checkBox_Copy.Visibility = Visibility.Hidden;
            checkBox_Copy1.Visibility = Visibility.Hidden;
            checkBox_Copy2.Visibility = Visibility.Hidden;
            checkBox_Copy3.Visibility = Visibility.Hidden;
            checkBox_Copy4.Visibility = Visibility.Hidden;
            checkBox_Copy5.Visibility = Visibility.Hidden;
            checkBox_Copy6.Visibility = Visibility.Hidden;
            bought.Visibility = Visibility.Hidden;
            //third buton
            discount.Visibility = Visibility.Hidden;
        }

        private void sales_Click(object sender, RoutedEventArgs e)
        {
            discount.Visibility = Visibility.Visible;
        }

        private void products_needed_Click(object sender, RoutedEventArgs e)
        {
            products.Visibility = Visibility.Visible;
            button.Visibility = Visibility.Visible;
            checkBox.Visibility = Visibility.Visible;
            checkBox_Copy.Visibility = Visibility.Visible;
            checkBox_Copy1.Visibility = Visibility.Visible;
            checkBox_Copy2.Visibility = Visibility.Visible;
            checkBox_Copy3.Visibility = Visibility.Visible;
            checkBox_Copy4.Visibility = Visibility.Visible;
            checkBox_Copy5.Visibility = Visibility.Visible;
            checkBox_Copy6.Visibility = Visibility.Visible;           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bought.Visibility = Visibility.Visible;
        }
    }
}
