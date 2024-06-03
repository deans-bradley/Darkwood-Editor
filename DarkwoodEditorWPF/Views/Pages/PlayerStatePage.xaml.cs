using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
	/// <summary>
	/// Interaction logic for PlayerStatePage.xaml
	/// </summary>
	public partial class PlayerStatePage : Page
    {
        public PlayerStatePage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;
        }

        private void recipesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/RecipesPage.xaml");
            }
        }

		private void craftedItemsBtn_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/CraftedItemsPage.xaml");
            }
		}

		private void playerEffectsBtn_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/CharacterEffectsPage.xaml");
            }
		}

        private void skillsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/SkillsPage.xaml");
            }
        }

        // TODO: Add input validation methods in helper class
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