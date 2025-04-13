using System.Collections.ObjectModel;
using WPF.Model;
using WPF.MVVM;

namespace WPF.View_Model
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items {  get; set; }
        
        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        private Item _selectedItem;
        public Item SelectedItem
        {
            get { return _selectedItem; }
            set { 
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "Item",
                SerialNumber = "xxxx",
                Quantity = 1,
            });
        }

        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }
    }
}
