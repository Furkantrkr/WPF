using System.Collections;
using System.Windows;

namespace WPF
{
    public partial class MainWindow : Window
    {
        bool IsRunning = false;
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            IList items = lvEntries.SelectedItems;
            MessageBoxResult result = MessageBox.Show($"Are you sure that you want to delete: {items.Count} items?", "Sure?", MessageBoxButton.YesNo);

            IList itemsList = new ArrayList(items);

            if (result == MessageBoxResult.Yes)
                foreach (object item in itemsList)
                {
                    //
                    lvEntries.Items.Remove(item);
                }
            else
                return;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}