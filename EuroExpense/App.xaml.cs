using System;
using System.Windows;
using EuroExpense.Helpers;

namespace EuroExpense
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ThemeManager.LoadSavedTheme();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            DispatcherUnhandledException += (sender, args) =>
            {
                MessageBox.Show($"An error occurred: {args.Exception.Message}", 
                              "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                args.Handled = true;
            };
        }
    }
}
