using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class AvailableSkillsStatesViewModel : INotifyPropertyChanged
    {
        // TODO: Implement the AvailableSkillStatesViewModel class

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
