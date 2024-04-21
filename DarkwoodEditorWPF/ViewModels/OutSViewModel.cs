using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkwoodEditorWPF.ViewModels
{
    public class OutSViewModel : INotifyPropertyChanged
    {
        private List<object>? spawnedLocationsKeys;
        private List<object>? spawnedLocationsValuesIDs;
        private List<double>? positionCopy;
        private int timeCopy;
        private bool playerInOutsideLocation;
        private string? currentLocationName;
        private int actualSpawnedLocationsCount;
        private int objectThatTransportedMeID;

        public List<object>? SpawnedLocationsKeys
        {
            get => spawnedLocationsKeys;
            set
            {
                spawnedLocationsKeys = value;
                OnPropertyChanged("SpawnedLocationsKeys");
            }
        }

        public List<object>? SpawnedLocationsValuesIDs
        {
            get => spawnedLocationsValuesIDs;
            set
            {
                spawnedLocationsValuesIDs = value;
                OnPropertyChanged("SpawnedLocationsValuesIDs");
            }
        }

        public List<double>? PositionCopy
        {
            get => positionCopy;
            set
            {
                positionCopy = value;
                OnPropertyChanged("PositionCopy");
            }
        }

        public int TimeCopy
        {
            get => timeCopy;
            set
            {
                timeCopy = value;
                OnPropertyChanged("TimeCopy");
            }
        }

        public bool PlayerInOutsideLocation
        {
            get => playerInOutsideLocation;
            set
            {
                playerInOutsideLocation = value;
                OnPropertyChanged("PlayerInOutsideLocation");
            }
        }

        public string? CurrentLocationName
        {
            get => currentLocationName;
            set
            {
                currentLocationName = value;
                OnPropertyChanged("CurrentLocationName");
            }
        }

        public int ActualSpawnedLocationsCount
        {
            get => actualSpawnedLocationsCount;
            set
            {
                actualSpawnedLocationsCount = value;
                OnPropertyChanged("ActualSpawnedLocationsCount");
            }
        }

        public int ObjectThatTransportedMeID
        {
            get => objectThatTransportedMeID;
            set
            {
                objectThatTransportedMeID = value;
                OnPropertyChanged("ObjectThatTransportedMeID");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
