namespace DarkwoodEditorWPF.Data.Inventory
{
    public class AmmoItems
    {
        public KeyValuePair<string, string> MediumCalClip { get { return new KeyValuePair<string, string>("ammo_clip_mediumcal", "Medium caliber clip"); } }
        public KeyValuePair<string, string> SmallCalClip { get { return new KeyValuePair<string, string>("ammo_clip_smallcal", "Small caliber clip"); } }
        public KeyValuePair<string, string> MediumCalSingle { get { return new KeyValuePair<string, string>("ammo_single_mediumcal", "Medium caliber single"); } }
        public KeyValuePair<string, string> PelletSingle { get { return new KeyValuePair<string, string>("ammo_single_pellet", "Pellet single"); } }
        public KeyValuePair<string, string> ShotgunCalSingle { get { return new KeyValuePair<string, string>("ammo_single_shotgun", "Shotgun single"); } }
        public KeyValuePair<string, string> Battery { get { return new KeyValuePair<string, string>("battery9v", "Battery 9V"); } }
    }
}