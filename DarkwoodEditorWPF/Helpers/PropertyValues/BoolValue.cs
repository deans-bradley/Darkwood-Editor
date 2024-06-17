using System.ComponentModel;

namespace DarkwoodEditorWPF.Helpers.PropertyValues
{
    public class BoolValue : INotifyPropertyChanged
    {
        private bool _value;
        public bool Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}