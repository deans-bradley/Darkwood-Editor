using DarkwoodEditorWPF.GameItems.Inventory;

namespace DarkwoodEditorWPF.GameItems
{
    public class DwItems
    {
        private Ammo ammo = new Ammo();
        private Consumables consumables = new Consumables();
        private ExpObjects expObjects = new ExpObjects();
        private Firearms firearms = new Firearms();

        private List<ItemType> inventoryItems = new List<ItemType>();

        public DwItems()
        {
            inventoryItems.AddRange(ammo.AmmoItems);
            inventoryItems.AddRange(consumables.ConsumableItems);
            inventoryItems.AddRange(expObjects.ExpObjectItems);
            inventoryItems.AddRange(firearms.FirearmItems);
        }

        public List<ItemType> InventoryItems { get { return inventoryItems; } }
    }
}
