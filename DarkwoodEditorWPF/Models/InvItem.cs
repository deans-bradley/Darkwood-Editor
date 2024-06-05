namespace DarkwoodEditorWPF.Models
{
    public class InvItem
    {
        public int SlotId { get; set; }
        public string? Type { get; set; }
        public double Durability { get; set; }
        public int Amount { get; set; }
        public bool IsRecipe { get; set; }
        public string? RecipeFor { get; set; }
        public List<string> Modifiers { get; set; } = new List<string>();
        public List<string> Upgrades { get; set; } = new List<string>();
        public double TimeDeactivated { get; set; }
        public bool ShouldBeActive { get; set; }
        public double TimeSeen { get; set; }
    }
}
