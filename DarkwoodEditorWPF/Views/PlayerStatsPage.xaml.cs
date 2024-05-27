using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
	/// <summary>
	/// Interaction logic for PlayerStatsPage.xaml
	/// </summary>
	public partial class PlayerStatsPage : Page
    {
        public PlayerStatsPage()
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
                mainContent.SetContentRight("Views/UserControls/EditRecipesUserControl.xaml");
            }
        }

		private void craftedItemsBtn_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/UserControls/EditCraftedItemsUserControl.xaml");
            }
		}

		private void playerEffectsBtn_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/UserControls/ChEffsUserControl.xaml");
            }
		}

        private void skillsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/UserControls/SkillsUserControl.xaml");
            }
        }

        //
        // Input validation
        //
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
