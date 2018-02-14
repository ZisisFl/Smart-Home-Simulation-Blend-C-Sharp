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
        bool male_clicked = true;
        public smart_wardrobe()
        {
            InitializeComponent();
        }

        private void male_Click(object sender, RoutedEventArgs e)
        {
            male_clicked = true;
        }

        private void formal_Click(object sender, RoutedEventArgs e)
        {
            if (male_clicked == true)
            {
                clothes.Source = new BitmapImage(new Uri(@"pack://application:,,,/Virvou;component/Resources/formal_m.png"));
            }
            else
                clothes.Source = new BitmapImage(new Uri(@"\Resources\formal_w.png"));
        }
    }
}
