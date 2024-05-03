using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
	public class ChEffsViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<EffectViewModel>? effects;

		public ObservableCollection<EffectViewModel>? Effects
		{
			get => effects;
			set
			{
				effects = value;
				OnPropertyChanged("Effects");
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
