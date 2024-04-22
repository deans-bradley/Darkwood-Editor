using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
    /// <summary>
    /// Interaction logic for EditRecipesPage.xaml
    /// </summary>
    public partial class EditRecipesPage : Page
    {
        public EditRecipesPage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;
        }
    }
}
