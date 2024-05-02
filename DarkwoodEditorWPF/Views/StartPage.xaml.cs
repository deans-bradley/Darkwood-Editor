using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;
        }

        private void recipesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.MainContent.Navigate(new Uri("Views/UserControls/EditRecipesUserControl.xaml", UriKind.Relative));
        }

		private void craftedItemsBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

			mainWindow.MainContent.Navigate(new Uri("Views/UserControls/EditCraftedItemsUserControl.xaml", UriKind.Relative));
		}

		private void IntTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			foreach (char c in e.Text)
			{
				if (!Char.IsDigit(c))
				{
					e.Handled = true;
					return;
				}
			}
		}

		private void DoubleTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
		{
			foreach (char c in e.Text)
			{
				if (!char.IsDigit(c) && c != '.' || (c == '.' && ((TextBox)sender).Text.Contains('.')))
				{
					e.Handled = true;
					return;
				}
			}
		}
	}
}
