using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class RootViewModel : INotifyPropertyChanged
    {
        public RootViewModel() { }

        private int majorVersion;
        private int minorVersion;
        private int majorVersionCompatibility;
        private int minorVersionCompatibility;
        private int rCVersion;
        private int rCVersionCompatibility;

        // Add more properties here

        public int MajorVersion
        {
            get => majorVersion;
            set
            {
                majorVersion = value;
                OnPropertyChanged("MajorVersion");
            }
        }

        public int MinorVersion
        {
            get => minorVersion;
            set
            {
                minorVersion = value;
                OnPropertyChanged("MinorVersion");
            }
        }

        public int MajorVersionCompatibility
        {
            get => majorVersionCompatibility;  
            set
            {
                majorVersionCompatibility = value;
                OnPropertyChanged("MajorVersionCompatibility");
            }
        }

        public int MinorVersionCompatibility
        {
            get => minorVersionCompatibility;
            set
            {
                minorVersionCompatibility = value;
                OnPropertyChanged("MinorVersionCompatibility");
            }
        }

        public int RCVersion
        {
            get => rCVersion;
            set
            {
                rCVersion = value;
                OnPropertyChanged("RCVersion");
            }
        }

        public int RCVersionCompatibility
        {
            get => rCVersionCompatibility;
            set
            {
                rCVersionCompatibility = value;
                OnPropertyChanged("RCVersionCompatibility");
            }
        }

        // Add more properties here

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
