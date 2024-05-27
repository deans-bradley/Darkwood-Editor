using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls
{
	/// <summary>
	/// Interaction logic for EditCraftedItemsUserControl.xaml
	/// </summary>
	public partial class EditCraftedItemsUserControl : UserControl
	{
		public EditCraftedItemsUserControl()
		{
			InitializeComponent();

			DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;
		}

		private void closeBtn_Click(object sender, RoutedEventArgs e)
		{
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight(null);
            }
        }

		private void IntValueTxtBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
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
    }
}
