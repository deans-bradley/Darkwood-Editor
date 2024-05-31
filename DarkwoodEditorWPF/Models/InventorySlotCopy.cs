namespace DarkwoodEditorWPF.Models
{
    public class InventorySlotCopy
    {
        public string? Name { get; set; }
        public bool inHotbar { get; set; }
        public InvItem? InvItem { get; set; }
        public bool Selected { get; set; }
        public int InventoryId { get; set; }
    }
}