using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class EvSViewModel : INotifyPropertyChanged
    {
        private List<Event>? events;
        private List<object>? activeEventCategories;
        private List<int>? worldEventsIds;
        private List<object>? gameEventsToFireAfterLoad;

        public List<Event> Events
        {
            get => events;
            set
            {
                events = value;
                OnPropertyChanged("Events");
            }
        }

        public List<object> ActiveEventCategories
        {
            get => activeEventCategories;
            set
            {
                activeEventCategories = value;
                OnPropertyChanged("ActiveEventCategories");
            }
        }

        public List<int> WorldEventsIds
        {
            get => worldEventsIds;
            set
            {
                worldEventsIds = value;
                OnPropertyChanged("WorldEventsIds");
            }
        }

        public List<object> GameEventsToFireAfterLoad
        {
            get => gameEventsToFireAfterLoad;
            set
            {
                gameEventsToFireAfterLoad = value;
                OnPropertyChanged("GameEventsToFireAfterLoad");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
