namespace DarkwoodEditorWPF.GameItems.Inventory
{
    public class Consumables
    {
        public ItemType Acid { get { return new ItemType("acid", "Acid"); } }
        public ItemType Alcohol { get { return new ItemType("alcohol", "Alcohol"); } }
        public ItemType AntidotePoison { get { return new ItemType("antidote_poison", "Antidote poison"); } }
        public ItemType Bandages { get { return new ItemType("bandages", "Bandages"); } }
        public ItemType BandagesAlcohol { get { return new ItemType("bandages_alcohol", "Bandages with alcohol"); } }
        public ItemType Bread { get { return new ItemType("bread", "Bread"); } }
        public ItemType ChickenEgg { get { return new ItemType("chicken_egg", "Chicken egg"); } }
        public ItemType ChickenEggRed { get { return new ItemType("chicken_egg_red", "Chicken egg red"); } }
        public ItemType DeadRat { get { return new ItemType("dead_rat", "Dead rat"); } }
        public ItemType Fish { get { return new ItemType("fish", "Fish"); } }
        public ItemType Lifepotion { get { return new ItemType("lifepotion", "Life potion"); } }
        public ItemType Pills { get { return new ItemType("pills", "Pills"); } }
        public ItemType Pills02 { get { return new ItemType("pills_02", "Pills 2"); } }
        public ItemType Potato { get { return new ItemType("potato_01", "Potato"); } }
        public ItemType Soup { get { return new ItemType("soup_01", "Soup"); } }
        public List<ItemType> ConsumableItems
        {
            get
            {
                return new List<ItemType>()
                {
                    Acid,
                    Alcohol,
                    AntidotePoison,
                    Bandages,
                    BandagesAlcohol,
                    Bread,
                    ChickenEgg,
                    ChickenEggRed,
                    DeadRat,
                    Fish,
                    Lifepotion,
                    Pills,
                    Pills02,
                    Potato,
                    Soup
                };
            }
        }
    }
}