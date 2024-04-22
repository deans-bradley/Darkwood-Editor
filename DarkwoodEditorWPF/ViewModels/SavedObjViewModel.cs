using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class SavedObjViewModel : INotifyPropertyChanged
    {
        private string? name;
        private int iD;
        private int pID;
        private bool active;
        private List<double>? p;
        private List<double>? r;
        private List<double>? s;
        private MapElS? mapElS;

        public string? Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int ID
        {
            get => iD;
            set
            {
                iD = value;
                OnPropertyChanged("ID");
            }
        }

        public int PID
        {
            get => pID;
            set
            {
                pID = value;
                OnPropertyChanged("PID");
            }
        }

        public bool Active
        {
            get => active;
            set
            {
                active = value;
                OnPropertyChanged("Active");
            }
        }

        public List<double>? P
        {
            get => p;
            set
            {
                p = value;
                OnPropertyChanged("P");
            }
        }

        public List<double>? R
        {
            get => r;
            set
            {
                r = value;
                OnPropertyChanged("R");
            }
        }

        public List<double>? S
        {
            get => s;
            set
            {
                s = value;
                OnPropertyChanged("S");
            }
        }

        public MapElS? MapElS
        {
            get => mapElS;
            set
            {
                mapElS = value;
                OnPropertyChanged("MapElS");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}