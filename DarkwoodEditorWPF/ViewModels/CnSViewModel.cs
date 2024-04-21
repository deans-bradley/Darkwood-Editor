using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class CnSViewModel : INotifyPropertyChanged
    {
        private int currentTime;
        private int day;
        private double gameTime;
        private int workbenchLevel;
        private bool isAfrerDeath;
        private bool gaveAfterNightRewards;

        public int CurrentTime
        {
            get => currentTime;
            set
            {
                currentTime = value;
                OnPropertyChanged("CurrentTime");
            }
        }

        public int Day
        {
            get => day;
            set
            {
                day = value;
                OnPropertyChanged("Day");
            }
        }

        public double GameTime
        {
            get => gameTime;
            set
            {
                gameTime = value;
                OnPropertyChanged("GameTime");
            }
        }

        public int WorkbenchLevel
        {
            get => workbenchLevel;
            set
            {
                workbenchLevel = value;
                OnPropertyChanged("WorkbenchLevel");
            }
        }

        public bool IsAfterDeath
        {
            get => isAfrerDeath;
            set
            {
                isAfrerDeath = value;
                OnPropertyChanged("IsAfterDeath");
            }
        }

        public bool GaveAfterNightRewards
        {
            get => gaveAfterNightRewards;
            set
            {
                gaveAfterNightRewards = value;
                OnPropertyChanged("GaveAfterNightRewards");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
