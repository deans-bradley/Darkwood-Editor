using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
    /// <summary>
    /// Interaction logic for PlayerPage.xaml
    /// </summary>
    public partial class PlayerPage : Page
    {
        public PlayerPage()
        {
            InitializeComponent();
        }

        private void dreamsBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/DreamsPage.xaml");
            }
        }
    }
}
