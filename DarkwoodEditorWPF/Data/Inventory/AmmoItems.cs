﻿namespace DarkwoodEditorWPF.Data.Inventory
{
    public class AmmoItems
    {
        public ItemType MediumCalClip { get { return new ItemType("ammo_clip_mediumcal", "Medium caliber clip"); } }
        public ItemType SmallCalClip { get { return new ItemType("ammo_clip_smallcal", "Small caliber clip"); } }
        public ItemType MediumCalSingle { get { return new ItemType("ammo_single_mediumcal", "Medium caliber single"); } }
        public ItemType PelletSingle { get { return new ItemType("ammo_single_pellet", "Pellet single"); } }
        public ItemType ShotgunCalSingle { get { return new ItemType("ammo_single_shotgun", "Shotgun single"); } }
        public ItemType Battery { get { return new ItemType("battery9v", "Battery 9V"); } }

        public Dictionary<string, string> Ammo
        {
            get
            {
                return new Dictionary<string, string>
                {
                    { MediumCalClip.Name, MediumCalClip.Value },
                    { SmallCalClip.Name, SmallCalClip.Value },
                    { MediumCalSingle.Name, MediumCalSingle.Value },
                    { PelletSingle.Name, PelletSingle.Value },
                    { ShotgunCalSingle.Name, ShotgunCalSingle.Value },
                    { Battery.Name, Battery.Value }
                };
            }
        }
    }
}