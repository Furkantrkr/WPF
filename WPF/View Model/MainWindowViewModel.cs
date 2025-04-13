using System.Collections.ObjectModel;
using WPF.Model;
using WPF.MVVM;

namespace WPF.View_Model
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items {  get; set; }  
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();

            Items.Add(new Item()
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });
            Items.Add(new Item()
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 6
            });
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
    }
}
