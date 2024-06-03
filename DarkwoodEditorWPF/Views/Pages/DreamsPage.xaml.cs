using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for DreamsPage.xaml
    /// </summary>
    public partial class DreamsPage : Page
    {
        public DreamsPage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.DrSViewModel;
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

        private void invSlotCopyBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight("Views/Pages/InventorySlotCopyPage.xaml");
            }
        }
    }
}