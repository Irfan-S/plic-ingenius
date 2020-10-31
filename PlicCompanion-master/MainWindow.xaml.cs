using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PlicCompanion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
        // settime = 4000;
        static int settime = (Properties.Settings.Default.tmrH * 3600000) + (Properties.Settings.Default.tmrM * 60000);
        Options opt;
        Analysis an;
        System.Timers.Timer timer = new System.Timers.Timer(settime);
        public MainWindow()
        {
            InitializeComponent();
            //System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
            ni.Icon = PlicCompanion.Properties.Resources.Main;
            ni.Visible = true;
            ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                    this.Focus();
                };
            
            
            timer.Elapsed += OnTimedEvent;
            timer.Enabled = true;
            GC.KeepAlive(timer);
            timer.Enabled = true;

        }
       
        public void disable_timer()
        {
            timer.Enabled = false;
        }

        public void enable_timer()
        {
            timer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            if(!Properties.Settings.Default.tmrAudioOnly)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    // Code causing the exception or requires UI thread access
                    Alert al = new Alert();
                    al.Show();
                }));
            }
            if (Properties.Settings.Default.audio)
            {
                var alert = new SoundPlayer(PlicCompanion.Properties.Resources.alert);
                alert.Play();
            }
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (Properties.Settings.Default.minTray)
            {
                if (WindowState == System.Windows.WindowState.Minimized)
                    this.Hide();
                base.OnStateChanged(e);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // setting cancel to true will cancel the close request
            // so the application is not closed
            e.Cancel = true;

            this.Hide();

            base.OnClosing(e);
        }

        bool F1active = false;

        private void F0_Click(object sender, RoutedEventArgs e)
        {
            
            if (this.Background.ToString() == "#FF7DFFBF") //mid
            {
                desc.Content = "Your current posture is not ideal and is not recommended for long term. Correction is advised";
                pos.Content = "Intermediate";
                F0.Content = "F1";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 255, 189, 193), new Duration(TimeSpan.FromSeconds(1)));
                this.Background = new SolidColorBrush(Color.FromArgb(255, 125, 255, 191));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
                if(Properties.Settings.Default.audio)
                {
                    var alert = new SoundPlayer(PlicCompanion.Properties.Resources.mid);
                    alert.Play();
                }
            }
            else if (this.Background.ToString() == "#FFFFBDC1") //bad
            {
                desc.Content = "Your current posture has a strong chance for adverse long term effects. Strongly recommended to change immediately";
                pos.Content = "Bad";
                F0.Content = "F2";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 255, 88, 88), new Duration(TimeSpan.FromSeconds(1)));
                this.Background = new SolidColorBrush(Color.FromArgb(255, 255, 189, 193));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
                if(Properties.Settings.Default.audio)
                {
                    var alert = new SoundPlayer(PlicCompanion.Properties.Resources.bad);
                    alert.Play();
                }
            }
            else //good
            {
                desc.Content = "Your current posture is ideal and will keep your neck and muscles healthy and pain free in the long term";
                pos.Content = "Good";
                F0.Content = "F0";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 125, 255, 191), new Duration(TimeSpan.FromSeconds(1)));
                this.Background = new SolidColorBrush(Color.FromArgb(255, 255, 88, 88));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
                if (Properties.Settings.Default.audio)
                {
                    var alert = new SoundPlayer(PlicCompanion.Properties.Resources.good);
                    alert.Play();
                }
            }

            
        }
        
        private void F1_Click(object sender, RoutedEventArgs e)
        {
            if (F1active == false)
            {
                F1active = true;
                F0.Visibility = Visibility.Hidden;
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 145, 145, 145), new Duration(TimeSpan.FromSeconds(1)));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
                pos.Content = "Inactive";
                desc.Content = "User has moved away from workplace";
            }
            else
            {
                F1active = false;
                F0.Visibility = Visibility.Visible;
                desc.Content = "Your current posture is ideal and will keep your neck and muscles healthy and pain free in the long term";
                pos.Content = "Good";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 125, 255, 191), new Duration(TimeSpan.FromSeconds(1)));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            ni.Visible = false; 
            ni.Dispose();
            Environment.Exit(0);
        }


        private async void con_Click(object sender, RoutedEventArgs e)
        {
            if (this.Background.ToString() == "#FFFFFFFF")
            {
                con.Content = "Connecting";
                pos.Content = "Gathering Data";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 145, 145, 145), new Duration(TimeSpan.FromSeconds(1)));
                this.Background = new SolidColorBrush(Colors.White);
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);

                await Task.Delay(3500);

                con.Content = "Connected";
                pos.Content = "Connected";
                desc.Content = "";
                ColorAnimation l = new ColorAnimation(Colors.White, new Duration(TimeSpan.FromSeconds(1)));
                this.Background = new SolidColorBrush(Color.FromArgb(255, 145, 145, 145));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, l);
                await Task.Delay(1500);
                pos.Content = "Good";
                desc.Content = "Your current posture is ideal and will keep your neck and muscles healthy and pain free in the long term";
                F0.Visibility = Visibility.Visible;
                F1.Visibility = Visibility.Visible;
                if (Properties.Settings.Default.audio)
                {
                    var alert = new SoundPlayer(PlicCompanion.Properties.Resources.good);
                    alert.Play();
                }
                ColorAnimation a = new ColorAnimation(Color.FromArgb(255, 125, 255, 191), new Duration(TimeSpan.FromSeconds(1)));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, a);
            }
            else 
            {
                con.Content = "Disconnecting";
                pos.Content = "Lost Connection, reconnecting...";
                desc.Content = "Please wait..";
                ColorAnimation ca = new ColorAnimation(Color.FromArgb(255, 145, 145, 145), new Duration(TimeSpan.FromSeconds(2)));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca);
                F0.Visibility = Visibility.Hidden;
                F1.Visibility = Visibility.Hidden;
                await Task.Delay(3000);

                con.Content = "Disconnected";
                pos.Content = "-";
                desc.Content = "Connectivity to the Plicinc device could not be established. Please connect/reconnect your device";
                ColorAnimation a = new ColorAnimation(Colors.White, new Duration(TimeSpan.FromSeconds(1)));
                this.Background.BeginAnimation(SolidColorBrush.ColorProperty, a);
            }

        }

        private void loadPrefs()
        {
            settime = (Properties.Settings.Default.tmrH * 3600000) + (Properties.Settings.Default.tmrM * 60000);
            if (!Properties.Settings.Default.tmrEn)
                disable_timer();
            else
                enable_timer();

        }   

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadPrefs();
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            if (opt == null)
                opt = new Options();
            opt.Closed += delegate { opt = null; };
            opt.Show();
            opt.Activate();
        }

        private void anal_Click(object sender, RoutedEventArgs e)
        {
            if (an == null)
                an = new Analysis();
            an.Closed += delegate { an = null; };
            an.Show();
            an.Activate();
        }
    }
}                