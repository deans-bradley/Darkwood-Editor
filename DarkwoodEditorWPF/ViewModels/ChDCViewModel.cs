using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class ChDCViewModel : INotifyPropertyChanged
    {
        private List<CharacterState>? characterStates;

        public List<CharacterState>? CharacterStates
        {
            get => characterStates;
            set
            {
                characterStates = value;
                OnPropertyChanged("CharacterStates");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
