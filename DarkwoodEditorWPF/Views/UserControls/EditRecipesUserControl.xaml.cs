using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for EditRecipeUserControl.xaml
    /// </summary>
    public partial class EditRecipesUserControl : UserControl
    {
        public EditRecipesUserControl()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.MainContent.Content = null;
        }
    }
}
