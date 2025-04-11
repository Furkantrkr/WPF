using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string _boundText;

        public string BoundText
        {
            get { return _boundText; }
            set
            {
                _boundText = value;
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Set from code";
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
