using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class MapSViewModel : INotifyPropertyChanged
    {
        private object? elementIDs;
        private List<Type>? types;

        public object? ElementIDs
        {
            get => elementIDs;
            set
            {
                elementIDs = value;
                OnPropertyChanged("ElementIDs");
            }
        }

        public List<Type>? Types
        {
            get => types;
            set
            {
                types = value;
                OnPropertyChanged("Types");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}