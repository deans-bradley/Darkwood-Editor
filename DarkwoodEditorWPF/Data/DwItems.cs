using DarkwoodEditorWPF.Data.Inventory;

namespace DarkwoodEditorWPF.Data
{
    public class DwItems
    {
        private AmmoItems ammo = new AmmoItems;
        private ConsumableItems consumables = new ConsumableItems;

        public Dictionary<string, string> Ammo 
        { 
            get 
            {
                return new Dictionary<string, string>
                {
                    ammo.MediumCalClip,
                    ammo.SmallCalClip,
                    ammo.MediumCalSingle,
                    ammo.PelletSingle,
                    ammo.ShotgunCalSingle,
                    ammo.Battery
                };
            } 
        }

        public Dictionary<string, string> Consumables
        {
            get
            {
                return new Dictionary<string, string>
                {
                    consumables.Acid,
                    consumables.Alcohol,
                    consumables.AntidotePoison,
                    consumables.Bandages,
                    consumables.BandagesAlcohol,
                    consumables.Bread,
                    consumables.ChickenEgg,
                    consumables.ChickenEggRed,
                    consumables.DeadRat,
                    consumables.Fish,
                    consumables.Lifepotion,
                    consumables.Pills,
                    consumables.Pills02,
                    consumables.Potato,
                    consumables.Soup
                };
            }
        }
    }

    public static class DictionaryExtensions
    {
        public static void Add(this Dictionary<string, string> dictionary, KeyValuePair<string, string> kvp)
        {
            dictionary.Add(kvp.Key, kvp.Value);
        }
    }
}
