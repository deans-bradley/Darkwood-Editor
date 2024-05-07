using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class EffectViewModel : INotifyPropertyChanged
    {
        private int _type;
        private int _duration;
        private double _modifier;
        private double _interval;
        private double _timeElapsed;

        public int Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }

        public int Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public double Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged("Modifier");
            }
        }

        public double Interval
        {
            get => _interval;
            set
            {
                _interval = value;
                OnPropertyChanged("Interval");
            }
        }

        public double TimeElapsed
        {
            get => _timeElapsed;
            set
            {
                _timeElapsed = value;
                OnPropertyChanged("TimeElapsed");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
