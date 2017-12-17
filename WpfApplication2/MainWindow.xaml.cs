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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double upspeed;
        double downspeed;
        double garantalt_le;
        double garantalt_fel;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void down_mbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        

            double.TryParse(down_mbs.Text, out downspeed);

        }

        public void up_mbs_TextChanged(object sender, TextChangedEventArgs e)
        {
          

            double.TryParse(up_mbs.Text, out upspeed);
        }

        public void Button_calculate_Click(object sender, RoutedEventArgs e)
        {
            double valos_le = downspeed / 8;
            double valos_fel = upspeed / 8;
            double garantaltanLe = garantalt_le / 8;
            double garantaltanFel = garantalt_fel / 8;
            label_down.Content = valos_le + " MB/s";
            label_up.Content = valos_fel + " MB/s";
            label_valodi_down.Content = garantaltanLe + " MB/s";
            label_valodi_up.Content = garantaltanFel + " MB/s";

        }

        private void garantalt_le_mbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            double.TryParse(garantalt_le_mbs.Text, out garantalt_le);
        }

        private void garantalt_fel_mbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            double.TryParse(garantalt_fel_mbs.Text, out garantalt_fel);
        }

        private void nullazo_button_Click(object sender, RoutedEventArgs e)
        {
            label_down.Content = "";
            label_up.Content = "";
            label_valodi_down.Content = "";
            label_valodi_up.Content = "";
            up_mbs.Text = "";
            down_mbs.Text = "";
            garantalt_fel_mbs.Text = "";
            garantalt_le_mbs.Text = "";
        }
    }
}
