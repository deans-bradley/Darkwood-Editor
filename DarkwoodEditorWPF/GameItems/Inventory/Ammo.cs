namespace DarkwoodEditorWPF.GameItems.Inventory
{
    public class Ammo
    {
        public ItemType MediumCalClip { get { return new ItemType("ammo_clip_mediumcal", "Medium caliber clip"); } }
        public ItemType SmallCalClip { get { return new ItemType("ammo_clip_smallcal", "Small caliber clip"); } }
        public ItemType MediumCalSingle { get { return new ItemType("ammo_single_mediumcal", "Medium caliber single"); } }
        public ItemType PelletSingle { get { return new ItemType("ammo_single_pellet", "Pellet single"); } }
        public ItemType ShotgunSingle { get { return new ItemType("ammo_single_shotgun", "Shotgun single"); } }
        public ItemType Battery { get { return new ItemType("battery9v", "Battery 9V"); } }
        public List<ItemType> AmmoItems
        {
            get
            {
                return new List<ItemType>()
                {
                    MediumCalClip,
                    SmallCalClip,
                    MediumCalSingle,
                    PelletSingle,
                    ShotgunSingle,
                    Battery
                };
            }
        }
    }
}