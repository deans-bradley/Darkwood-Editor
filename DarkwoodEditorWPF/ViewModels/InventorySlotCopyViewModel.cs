using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class InventorySlotCopyViewModel : INotifyPropertyChanged
    {
        private string name = "";
        private bool inHotbar;
        private InvItemViewModel invItem = new InvItemViewModel();
        private bool selected;
        private int inventoryId;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool InHotbar
        {
            get => inHotbar;
            set
            {
                inHotbar = value;
                OnPropertyChanged("inHotbar");
            }
        }

        public InvItemViewModel InvItem
        {
            get => invItem;
            set
            {
                invItem = value;
                OnPropertyChanged("InvItem");
            }
        }

        public bool Selected
        {
            get => selected;
            set
            {
                selected = value;
                OnPropertyChanged("Selected");
            }
        }

        public int InventoryId
        {
            get => inventoryId;
            set
            {
                inventoryId = value;
                OnPropertyChanged("InventoryId");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}