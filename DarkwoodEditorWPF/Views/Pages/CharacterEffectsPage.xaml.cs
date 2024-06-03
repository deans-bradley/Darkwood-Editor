using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for CharacterEffectsPage.xaml
    /// </summary>
    public partial class CharacterEffectsPage : Page
    {
        public CharacterEffectsPage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.ChEffS;
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
    }
}
