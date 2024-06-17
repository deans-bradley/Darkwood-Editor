using DarkwoodEditorWPF.Data;
using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls.Items
{
    /// <summary>
    /// Interaction logic for InventoryItem.xaml
    /// </summary>
    public partial class InventoryItem : UserControl
    {
        public InventoryItem()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.DrSViewModel?.InventorySlotsCopy;
            LoadDropDownItems();
        }

        private void LoadDropDownItems()
        {

        }
    }
}