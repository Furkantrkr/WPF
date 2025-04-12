using System.Text;
using System.Windows;
using Microsoft.Win32;

namespace WPF
{
    public partial class MainWindow : Window
    {
        bool IsRunning = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Fire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "#C Source Files | *.cs";
            fileDialog.Title = "Please select a CS Sources file";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();

            if(success == true)
            {
                string[] paths = fileDialog.FileNames;
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string path in paths)
                {
                    stringBuilder.AppendLine(path);
                }
                tbInfo.Text = stringBuilder.ToString();
            }
        }
    }
}
