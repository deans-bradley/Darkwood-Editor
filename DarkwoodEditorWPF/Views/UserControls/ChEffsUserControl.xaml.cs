using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls
{
	/// <summary>
	/// Interaction logic for ChEffsUserControl.xaml
	/// </summary>
	public partial class ChEffsUserControl : UserControl
	{
		public ChEffsUserControl()
		{
			InitializeComponent();

			DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.ChEffS;
		}

		private void closeBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

			mainWindow.MainContent.Content = null;
		}
    }
}
