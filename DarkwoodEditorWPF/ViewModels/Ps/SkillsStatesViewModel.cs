using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class SkillsStatesViewModel : INotifyPropertyChanged
    {
        private string? _type;
        private int _timesUsed;

        public string? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public int TimesUsed
        {
            get => _timesUsed;
            set
            {
                _timesUsed = value;
                OnPropertyChanged("TimesUsed");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
