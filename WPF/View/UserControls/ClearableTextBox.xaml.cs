using System.Windows;
using System.Windows.Controls;

namespace WPF.View.UserControls
{

    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private string _placeHolder;

        public string PlaceHolder
        {
            get => _placeHolder;
            set { 
                _placeHolder = value; 
                // do not do this
                tbPlaceHolder.Text = _placeHolder;
                // OnPropertyChanged()
            }
        }


        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(txtInput.Text))
                tbPlaceHolder.Visibility = Visibility.Visible;
             else 
                tbPlaceHolder.Visibility = Visibility.Hidden;
        }
    }
}
