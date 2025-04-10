using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window
    {
        bool IsRunning = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnToggleRun_Click(object sender, RoutedEventArgs e)
        {
            if (!IsRunning)
            {
                tbStatus.Text = "Stopped";
                btnToggleRun.Content = "Run";
            } else
            {
                tbStatus.Text = "Running";
                btnToggleRun.Content = "Stop";
            }

            IsRunning = !IsRunning;
        }
    }
}
