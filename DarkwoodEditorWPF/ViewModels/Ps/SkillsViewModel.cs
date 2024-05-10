using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels.Ps
{
    public class SkillsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<AvailableSkillsStatesViewModel>? _availableSkillsStates;
        private ObservableCollection<SkillsStatesViewModel>? _skillsStates;
        private bool _canActivateSkill;

        public ObservableCollection<AvailableSkillsStatesViewModel>? AvailableSkillsStates
        {
            get => _availableSkillsStates;
            set
            {
                _availableSkillsStates = value;
                OnPropertyChanged("AvailableSkillsStates");
            }
        }   

        public ObservableCollection<SkillsStatesViewModel>? SkillsStates
        {
            get => _skillsStates;
            set
            {
                _skillsStates = value;
                OnPropertyChanged("SkillsStates");
            }
        }

        public bool CanActivateSkill
        {
            get => _canActivateSkill;
            set
            {
                _canActivateSkill = value;
                OnPropertyChanged("CanActivateSkill");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
