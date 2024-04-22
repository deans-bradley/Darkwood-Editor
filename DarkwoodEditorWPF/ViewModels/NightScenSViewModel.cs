using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class NightScenSViewModel : INotifyPropertyChanged
    {
        private int scenarioID;
        private string? previousScenarioName;
        private int previousScenarioDifficulty;

        public int ScenarioID
        {
            get => scenarioID;
            set
            {
                scenarioID = value;
                OnPropertyChanged("ScenarioID");
            }
        }

        public string? PreviousScenarioName
        {
            get => previousScenarioName;
            set
            {
                previousScenarioName = value;
                OnPropertyChanged("PreviousScenarioName");
            }
        }

        public int PreviousScenarioDifficulty
        {
            get => previousScenarioDifficulty;
            set
            {
                previousScenarioDifficulty = value;
                OnPropertyChanged("PreviousScenarioDifficulty");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
