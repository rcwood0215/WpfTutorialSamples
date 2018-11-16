using System.Windows;

namespace WpfTutorialSamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MainWindow wnd = new MainWindow();
            /* The OpenFile() method is just and example of whate you could
               do with the parameter.  The method should be declared on your
               MainWindow class, where you could use a range of methods to
               process the passed file path.*/
            if (e.Args.Length == 1) MessageBox.Show("Now opening file: \n\n"
                 + e.Args[0]);


            // Do stuff here, e.g. to the window
            wnd.Title = "Something Else";
            wnd.WindowState = WindowState.Normal;
            // Show the window
            wnd.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK,
                MessageBoxImage.Warning);
            e.Handled = true;
        }
    }
}
