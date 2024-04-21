using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string filePath;

        private SaveMS _saveMS;
        private RootViewModel _rootViewModel;
        private PsViewModel _psViewModel;

        public MainViewModel()
        {
            _rootViewModel = new RootViewModel();
            _psViewModel = new PsViewModel();
        }

        public string FilePath
        {
            get => filePath;
            set
            {
                filePath = value;
                OnPropertyChanged("FilePath");
            }
        }

        public SaveMS SaveMS
        {
            get => _saveMS;
            set
            {
                _saveMS = value;
                OnPropertyChanged("SaveMS");
            }
        }

        public RootViewModel RootViewModel
        {
            get => _rootViewModel;
            set
            {
                _rootViewModel = value;
                OnPropertyChanged("RootViewModel");
            }
        }

        public PsViewModel PsViewModel
        {
            get => _psViewModel;
            set
            {
                _psViewModel = value;
                OnPropertyChanged("PsViewModel");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
