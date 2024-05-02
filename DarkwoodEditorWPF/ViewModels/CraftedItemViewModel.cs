using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class CraftedItemViewModel : INotifyPropertyChanged
    {
        private string? _string;
        private int _int;

        public string? StringValue
        {
            get => _string;
            set
            {
                _string = value;
                OnPropertyChanged("StringValue");
            }
        }

        public int IntValue
        {
            get => _int;
            set
            {
                _int = value;
                OnPropertyChanged("IntValue");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
