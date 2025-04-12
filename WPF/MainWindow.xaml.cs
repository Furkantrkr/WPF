using System.Windows;
using Winforms = System.Windows.Forms;

namespace WPF
{
    public partial class MainWindow : Window
    {
        bool IsRunning = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            Winforms.FolderBrowserDialog folderBrowserDialog = new Winforms.FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = "C:\\Users\\FurkanTurker\\Desktop\\FT\\WPF\\01 - GettingStartedWithWPF\\WPF";
            Winforms.DialogResult result = folderBrowserDialog.ShowDialog();

            if(result == Winforms.DialogResult.OK)
            {
                string path = folderBrowserDialog.SelectedPath;
            }
            
        }
    }
}
