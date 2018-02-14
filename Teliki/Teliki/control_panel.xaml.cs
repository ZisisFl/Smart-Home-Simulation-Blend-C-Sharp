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
        private living_roo _lv;
        public control_panel()
        {
            InitializeComponent();    
        }

        private void lights_l_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void tv_Checked(object sender, RoutedEventArgs e)
        {
            var l_r = new living_roo();
            l_r.tv_open.Visibility = Visibility.Visible;
            l_r.Show();
            //_lv.tv_open.Visibility = Visibility.Visible;
        }

        public control_panel(living_roo lv)
        {
            _lv = lv;
        }

        private void kalorifer_Checked(object sender, RoutedEventArgs e)
        {
            //gia ta 3 dwmatia pirazei to c_temp_text se kokkino stous 19 vathmous
        }

        private void aircondition_b_Checked(object sender, RoutedEventArgs e)
        {
            //gia bedroom mple c_temp_tex stous 24
        }

        private void aircondition_l_Checked(object sender, RoutedEventArgs e)
        {
            //gia living room mple c_temp_tex stous 24
        }
    }
}
