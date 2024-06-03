using DarkwoodEditorWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DarkwoodEditorWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for CraftedItemsPage.xaml
    /// </summary>
    public partial class CraftedItemsPage : Page
    {
        public CraftedItemsPage()
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

        // TODO: Remove this method after implementing validation to helper class
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
