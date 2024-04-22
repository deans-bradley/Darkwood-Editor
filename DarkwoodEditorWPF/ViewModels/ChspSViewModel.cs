using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class ChspSViewModel : INotifyPropertyChanged
    {
        private List<object>? spawnedCharacterIDs;
        private List<object>? nocturnalCharsIDs;
        private int holderID;
        private int charactersEscapedFromLocationHolderID;

        public List<object>? SpawnedCharacterIDs
        {
            get => spawnedCharacterIDs;
            set
            {
                spawnedCharacterIDs = value;
                OnPropertyChanged("SpawnedCharacterIDs");
            }
        }

        public List<object>? NocturnalCharsIDs
        {
            get => nocturnalCharsIDs;
            set
            {
                nocturnalCharsIDs = value;
                OnPropertyChanged("NocturnalCharsIDs");
            }
        }

        public int HolderID
        {
            get => holderID;
            set
            {
                holderID = value;
                OnPropertyChanged("HolderID");
            }
        }

        public int CharactersEscapedFromLocationHolderID
        {
            get => charactersEscapedFromLocationHolderID;
            set
            {
                charactersEscapedFromLocationHolderID = value;
                OnPropertyChanged("CharactersEscapedFromLocationHolderID");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
