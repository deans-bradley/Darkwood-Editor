using System.Windows.Controls;
using DarkwoodEditorWPF.GameItems;

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

            DwItems items = new DwItems();

            // TODO: Fix this
            typeComBox.ItemsSource = items.InventoryItems;
        }
    }
}
