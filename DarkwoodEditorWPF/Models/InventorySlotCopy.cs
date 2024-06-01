namespace DarkwoodEditorWPF.Models
{
    public class InventorySlotCopy
    {
        public string? Name { get; set; }
        public bool InHotbar { get; set; }
        public InvItem InvItem { get; set; } = new InvItem();
        public bool Selected { get; set; }
        public int InventoryId { get; set; }
    }
}