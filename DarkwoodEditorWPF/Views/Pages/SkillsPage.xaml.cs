using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for SkillsPage.xaml
    /// </summary>
    public partial class SkillsPage : Page
    {
        public SkillsPage()
        {
            InitializeComponent();
            CheckDropDowns();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.SkillS;
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

        // TODO: Move this to a better place
        private void CheckDropDowns()
        {
            PsViewModel? psVM = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;

            if (psVM?.SkillS?.AvailableSkillsStates == null)
            {
                availableSkillsDrpDwn.Visibility = Visibility.Collapsed;
            }

            if (psVM?.SkillS?.SkillsStates == null)
            {
                skillsStatesDrpDwn.Visibility = Visibility.Collapsed;
            }
        }
    }
}
