using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkwoodEditorWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string filePath;

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
