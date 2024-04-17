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
        }

        public int MinorVersion
        {
            get => minorVersion;
        }

        public int MajorVersionCompatibility
        {
            get => majorVersionCompatibility;
        }

        public int MinorVersionCompatibility
        {
            get => minorVersionCompatibility;
        }

        public int RCVersion
        {
            get => rCVersion;
        }

        public int RCVersionCompatibility
        {
            get => rCVersionCompatibility;
        }

        // Add more properties here

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
