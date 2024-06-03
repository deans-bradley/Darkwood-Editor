using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.Pages
{
    /// <summary>
    /// Interaction logic for InventorySlotCopyPage.xaml
    /// </summary>
    public partial class InventorySlotCopyPage : Page
    {
        public InventorySlotCopyPage()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.DrSViewModel;
        }
    }
}
