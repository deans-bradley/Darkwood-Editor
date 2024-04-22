using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class JoSViewModel : INotifyPropertyChanged
    {
        private List<object>? keysList;
        private List<object>? notesList;
        private List<object>? itemsList;
        private List<LocationsList>? locationsList;
        private List<object>? entriesList;
        private List<object>? locationDirections;

        public List<object>? KeysList
        {
            get => keysList;
            set
            {
                keysList = value;
                OnPropertyChanged("KeysList");
            }
        }

        public List<object>? NotesList
        {
            get => notesList;
            set
            {
                notesList = value;
                OnPropertyChanged("NotesList");
            }
        }

        public List<object>? ItemsList
        {
            get => itemsList;
            set
            {
                itemsList = value;
                OnPropertyChanged("ItemsList");
            }
        }

        public List<LocationsList>? LocationsList
        {
            get => locationsList;
            set
            {
                locationsList = value;
                OnPropertyChanged("LocationsList");
            }
        }

        public List<object>? EntriesList
        {
            get => entriesList;
            set
            {
                entriesList = value;
                OnPropertyChanged("EntriesList");
            }
        }

        public List<object>? LocationDirections
        {
            get => locationDirections;
            set
            {
                locationDirections = value;
                OnPropertyChanged("LocationDirections");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
