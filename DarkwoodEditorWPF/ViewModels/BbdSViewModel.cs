using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class BbdSViewModel : INotifyPropertyChanged
    {
        private List<BigBiomeState>? bigBiomeStates;

        public List<BigBiomeState>? BigBiomeStates
        {
            get => bigBiomeStates;
            set
            {
                bigBiomeStates = value;
                OnPropertyChanged("BigBiomeStates");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
