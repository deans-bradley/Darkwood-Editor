using System.ComponentModel;

namespace DarkwoodEditorWPF.Helpers.PropertyValues
{
    public class StringValue : INotifyPropertyChanged
    {
        private string? _value;
        public string? Value
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