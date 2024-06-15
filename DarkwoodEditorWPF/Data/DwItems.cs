using DarkwoodEditorWPF.Data.Inventory;

namespace DarkwoodEditorWPF.Data
{
    public class DwItems
    {
        private AmmoItems ammo = new AmmoItems();
        private ConsumableItems consumables = new ConsumableItems();

        public Dictionary<string, string> Inventory
        {
            get
            {
                return new Dictionary<string, string>
                {
                    
                };
            }
        }
    }
}
