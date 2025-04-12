using System.Collections;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window
    {
 
        public MainWindow()
        {
            InitializeComponent();
            _entries = new ObservableCollection<string>();

            DataContext = this;
        }

        private ObservableCollection<string> _entries;

        public ObservableCollection<string> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Entries.Add(txtEntry.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem = (string)lvEntries.SelectedItem;
            Entries.Remove(selectedItem);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Entries.Clear();
        }
    }
}