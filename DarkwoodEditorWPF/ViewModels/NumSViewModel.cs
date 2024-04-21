using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class NumSViewModel : INotifyPropertyChanged
    {
        private List<Number>? numbers;
        private List<YPositionOffset>? yPositionOffsets;

        public List<Number>? Numbers
        {
            get => numbers;
            set
            {
                numbers = value;
                OnPropertyChanged("Numbers");
            }
        }

        public List<YPositionOffset>? YPositionOffsets
        {
            get => yPositionOffsets;
            set
            {
                yPositionOffsets = value;
                OnPropertyChanged("YPositionOffsets");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
