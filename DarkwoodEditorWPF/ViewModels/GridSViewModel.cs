using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class GridSViewModel : INotifyPropertyChanged
    {
        private List<GridState>? gridStates;

        public List<GridState>? GridStates
        {
            get => gridStates;
            set
            {
                gridStates = value;
                OnPropertyChanged("GridStates");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
