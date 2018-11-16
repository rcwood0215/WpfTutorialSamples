using System;
using System.Windows;

namespace WpfTutorialSamples
{
    /// <summary>
    /// Interaction logic for ResourceFromCodeBehindSample.xaml
    /// </summary>
    public partial class ResourceFromCodeBehindSample : Window
    {
        public ResourceFromCodeBehindSample()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Items.Clear();
            lblResult.Items.Add(pnlMain.FindResource("strPanel").ToString());
            lblResult.Items.Add(this.FindResource("strWindow").ToString());
            lblResult.Items.Add(Application.Current.FindResource("strApp").ToString());
        }
    }
}
