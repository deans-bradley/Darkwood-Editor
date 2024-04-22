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

            mainWindow.MainContent.Navigate(new Uri("Views/EditRecipesPage.xaml", UriKind.Relative));
        }
    }
}
