using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class WorldGenSViewModel : INotifyPropertyChanged
    {
        private List<int>? worldChunksIDs;
        private List<int>? locationsIDs;
        private List<object>? respawnPointsIDs;
        private List<ChunkState>? chunkStates;
        private int playerBaseID;
        private int outsideLocationsGOID;
        private int roadsGOID;
        private int majorVersion;
        private int minorVersion;
        private int chapterID;

        public List<int>? WorldChunksIDs
        {
            get => worldChunksIDs;
            set
            {
                worldChunksIDs = value;
                OnPropertyChanged("WorldChunksIDs");
            }
        }

        public List<int>? LocationsIDs
        {
            get => locationsIDs;
            set
            {
                locationsIDs = value;
                OnPropertyChanged("LocationsIDs");
            }
        }

        public List<object>? RespawnPointsIDs
        {
            get => respawnPointsIDs;
            set
            {
                respawnPointsIDs = value;
                OnPropertyChanged("RespawnPointsIDs");
            }
        }

        public List<ChunkState>? ChunkStates
        {
            get => chunkStates;
            set
            {
                chunkStates = value;
                OnPropertyChanged("ChunkStates");
            }
        }

        public int PlayerBaseID
        {
            get => playerBaseID;
            set
            {
                playerBaseID = value;
                OnPropertyChanged("PlayerBaseID");
            }
        }

        public int OutsideLocationsGOID
        {
            get => outsideLocationsGOID;
            set
            {
                outsideLocationsGOID = value;
                OnPropertyChanged("OutsideLocationsGOID");
            }
        }

        public int RoadsGOID
        {
            get => roadsGOID;
            set
            {
                roadsGOID = value;
                OnPropertyChanged("RoadsGOID");
            }
        }

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

        public int ChapterID
        {
            get => chapterID;
            set
            {
                chapterID = value;
                OnPropertyChanged("ChapterID");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
