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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PlicCompanion
{
    /// <summary>
    /// Interaction logic for Alert.xaml
    /// </summary>
    public partial class Alert : Window
    {
        public Alert()
        {
            InitializeComponent();
            ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 255, 189, 189), new Duration(TimeSpan.FromSeconds(1)));
            this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
