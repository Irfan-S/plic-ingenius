using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PlicCompanion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //initialize the splash screen and set it as the application main window
            Splash splashScreen = new Splash();
            this.MainWindow = splashScreen;
            splashScreen.Show();

            //loading on seperate thread
            Task.Factory.StartNew(() =>
            {
                //simulate some work being done for now
                System.Threading.Thread.Sleep(1700);

                //since we're not on the UI thread
                //once we're done we need to use the Dispatcher
                //to create and show the main window
                this.Dispatcher.Invoke(() =>
                {
                    //initialize the main window, set it as the application main window
                    //and close the splash screen
                    var main = new MainWindow();
                    this.MainWindow = main;
                    //loginWindow.Opacity = 0;
                    main.Show();
                    splashScreen.Close();
                });
            });

        }

    }
}
