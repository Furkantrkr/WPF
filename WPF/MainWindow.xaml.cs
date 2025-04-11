using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Could not open file.","ERROR",MessageBoxButton.OK, MessageBoxImage.Error);
            MessageBoxResult result = MessageBox.Show("Do you agree?","Agreement",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            tbInfo.Text = result == MessageBoxResult.Yes ? "Agreed" : "Not Agreed";
        }
    }
}
