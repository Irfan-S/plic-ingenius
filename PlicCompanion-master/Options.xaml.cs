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

namespace PlicCompanion
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {

#pragma warning disable CS0414 // The field 'Options.flag' is assigned but its value is never used
        bool flag;
#pragma warning restore CS0414 // The field 'Options.flag' is assigned but its value is never used
        public Options()
        {
            InitializeComponent();
            flag = false;
        }

        public void getPrefs()
        {
            runStart.IsChecked = Properties.Settings.Default.runStart;
            trayMin.IsChecked = Properties.Settings.Default.minTray;
            audioEn.IsChecked = Properties.Settings.Default.audio;
            timrEnable.IsChecked = Properties.Settings.Default.tmrEn;
            hour.Value = Properties.Settings.Default.tmrH;
            min.Value = Properties.Settings.Default.tmrM;
            tmrAudioOnly.IsChecked = Properties.Settings.Default.tmrAudioOnly;
        }

        public void savePrefs()
        {
            Properties.Settings.Default.runStart = (bool)runStart.IsChecked;
            Properties.Settings.Default.minTray = (bool)trayMin.IsChecked;
            Properties.Settings.Default.audio = (bool)audioEn.IsChecked;
            Properties.Settings.Default.tmrEn = (bool)timrEnable.IsChecked;
            Properties.Settings.Default.tmrH = (short)hour.Value;
            Properties.Settings.Default.tmrM = (short)min.Value;
            Properties.Settings.Default.tmrAudioOnly = (bool)tmrAudioOnly.IsChecked;

            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.runStart == true)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                string BaseDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                key.SetValue("PlicCompanion", BaseDir);
            }

            if (!Properties.Settings.Default.tmrEn)
                (Application.Current.MainWindow as MainWindow).disable_timer();
            else
                (Application.Current.MainWindow as MainWindow).enable_timer();
        }

        private void runStart_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.runStart = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            getPrefs();
        }

        private void apply_Click(object sender, RoutedEventArgs e)
        {
            savePrefs();
            this.Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
                if ((MessageBox.Show("Abort unsaved changes and close options?", "Options", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes)
                    this.Close();
        }

        private void Common_SettingsChanged(object sender, EventArgs e)
        {
            flag = true;
        }
    }
}
