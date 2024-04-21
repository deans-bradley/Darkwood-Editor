using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class HsViewModel : INotifyPropertyChanged
    {
        private int slotCount;
        private List<object> invItems;

        public int SlotCount
        {
            get { return slotCount; }
            set
            {
                slotCount = value;
                OnPropertyChanged("SlotCount");
            }
        }

        public List<object> InvItems
        {
            get { return invItems; }
            set
            {
                invItems = value;
                OnPropertyChanged("InvItems");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
