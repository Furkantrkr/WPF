using System.Security.Policy;
using System.Windows;

namespace WPF.View
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModalWindow(Window parentWindow)
        {
            Owner = parentWindow;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Success = true;
            Input = txtInput.Text;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtInput.Text))
                btnOK.IsEnabled = true;
            else btnOK.IsEnabled = false;
        }
    }
}
