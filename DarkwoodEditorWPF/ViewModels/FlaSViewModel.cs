using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class FlaSViewModel : INotifyPropertyChanged
    {
        private int karmaPoints;
        private List<Flag> flags;
        private List<NpcState> npcStates;
        private List<DialogueState> dialogueStates;
        private List<object> achievements;

        public int KarmaPoints
        {
            get => karmaPoints;
            set
            {
                karmaPoints = value;
                OnPropertyChanged("KarmaPoints");
            }
        }

        public List<Flag> Flags
        {
            get => flags;
            set
            {
                flags = value;
                OnPropertyChanged("Flags");
            }
        }

        public List<NpcState> NpcStates
        {
            get => npcStates;
            set
            {
                npcStates = value;
                OnPropertyChanged("NpcStates");
            }
        }

        public List<DialogueState> DialogueStates
        {
            get => dialogueStates;
            set
            {
                dialogueStates = value;
                OnPropertyChanged("DialogueStates");
            }
        }

        public List<object> Achievements
        {
            get => achievements;
            set
            {
                achievements = value;
                OnPropertyChanged("Achievements");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
