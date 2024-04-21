using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class RaSViewModel : INotifyPropertyChanged
    {
        private bool raining;
        private bool rainToday;
        private double timeToStart;
        private double lightningTime;
        private bool preRainLightning;
        private double preRainLightningTime;
        private double duration;
        private TimeToFadeInFog? timeToFadeInFog;
        private TimeToFadeOutFog? timeToFadeOutFog;
        private bool fogFadedOutToday;
        private bool fogIsActive;

        public bool Raining
        {
            get => raining;
            set
            {
                raining = value;
                OnPropertyChanged("Raining");
            }
        }

        public bool RainToday
        {
            get => rainToday;
            set
            {
                rainToday = value;
                OnPropertyChanged("RainToday");
            }
        }

        public double TimeToStart
        {
            get => timeToStart;
            set
            {
                timeToStart = value;
                OnPropertyChanged("TimeToStart");
            }
        }

        public double LightningTime
        {
            get => lightningTime;
            set
            {
                lightningTime = value;
                OnPropertyChanged("LightningTime");
            }
        }

        public bool PreRainLightning
        {
            get => preRainLightning;
            set
            {
                preRainLightning = value;
                OnPropertyChanged("PreRainLightning");
            }
        }

        public double PreRainLightningTime
        {
            get => preRainLightningTime;
            set
            {
                preRainLightningTime = value;
                OnPropertyChanged("PreRainLightningTime");
            }
        }

        public double Duration
        {
            get => duration;
            set
            {
                duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public TimeToFadeInFog? TimeToFadeInFog
        {
            get => timeToFadeInFog;
            set
            {
                timeToFadeInFog = value;
                OnPropertyChanged("TimeToFadeInFog");
            }
        }

        public TimeToFadeOutFog? TimeToFadeOutFog
        {
            get => timeToFadeOutFog;
            set
            {
                timeToFadeOutFog = value;
                OnPropertyChanged("TimeToFadeOutFog");
            }
        }

        public bool FogFadedOutToday
        {
            get => fogFadedOutToday;
            set
            {
                fogFadedOutToday = value;
                OnPropertyChanged("FogFadedOutToday");
            }
        }

        public bool FogIsActive
        {
            get => fogIsActive;
            set
            {
                fogIsActive = value;
                OnPropertyChanged("FogIsActive");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
