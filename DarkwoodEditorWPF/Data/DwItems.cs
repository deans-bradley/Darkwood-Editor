using DarkwoodEditorWPF.Data.Inventory;

namespace DarkwoodEditorWPF.Data
{
    public class DwItems
    {
        private AmmoItems ammo = new AmmoItems();
        private ConsumableItems consumables = new ConsumableItems();

        public Dictionary<string, string> Ammo 
        { 
            get 
            {
                return new Dictionary<string, string>
                {
                    { ammo.MediumCalClip.Name, ammo.MediumCalClip.Value },
                    { ammo.SmallCalClip.Name, ammo.SmallCalClip.Value },
                    { ammo.MediumCalSingle.Name, ammo.MediumCalSingle.Value },
                    { ammo.PelletSingle.Name, ammo.PelletSingle.Value },
                    { ammo.ShotgunCalSingle.Name, ammo.ShotgunCalSingle.Value },
                    { ammo.Battery.Name, ammo.Battery.Value }
                };
            } 
        }

        public Dictionary<string, string> Consumables
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { consumables.Acid.Name, consumables.Acid.Value },
                    { consumables.Alcohol.Name, consumables.Alcohol.Value },
                    { consumables.AntidotePoison.Name, consumables.AntidotePoison.Value },
                    { consumables.Bandages.Name, consumables.Bandages.Value },
                    { consumables.BandagesAlcohol.Name, consumables.BandagesAlcohol.Value },
                    { consumables.Bread.Name, consumables.Bread.Value },
                    { consumables.ChickenEgg.Name, consumables.ChickenEgg.Value },
                    { consumables.ChickenEggRed.Name, consumables.ChickenEggRed.Value },
                    { consumables.DeadRat.Name, consumables.DeadRat.Value },
                    { consumables.Fish.Name, consumables.Fish.Value },
                    { consumables.Lifepotion.Name, consumables.Lifepotion.Value },
                    { consumables.Pills.Name, consumables.Pills.Value },
                    { consumables.Pills02.Name, consumables.Pills02.Value },
                    { consumables.Potato.Name, consumables.Potato.Value },
                    { consumables.Soup.Name, consumables.Soup.Value }
                };
            }
        }
    }
}
