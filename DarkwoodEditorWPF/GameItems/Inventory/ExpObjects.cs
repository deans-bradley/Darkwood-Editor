namespace DarkwoodEditorWPF.GameItems.Inventory
{
    public class ExpObjects
    {
        public ItemType ExpBio2MeatMutated { get { return new ItemType("exp_bio2_meat_mutated", "Bio2 - meat mutated"); } }
        public ItemType ExpBio2Mushroom01 { get { return new ItemType("exp_bio2_mushroom_01", "Bio2 - mushroom"); } }
        public ItemType ExpBio2Nightmushroom01 { get { return new ItemType("exp_bio2_nightmushroom_01", "Bio2 - nightmushroom 01"); } }
        public ItemType ExpBio3MeatMutated { get { return new ItemType("exp_bio3_meat_mutated", "Bio3 - meat mutated"); } }
        public ItemType ExpBio3MushroomMeat01 { get { return new ItemType("exp_bio3_mushroom_meat_01", "Bio3 - mushroom meat 01"); } }
        public ItemType ExpBio3Nightmushroom01 { get { return new ItemType("exp_bio3_nightmushroom_01", "Bio3 - nightmushroom 01"); } }
        public ItemType ExpCockroachMutated { get { return new ItemType("exp_cockroach_mutated", "Cockroach mutated"); } }
        public ItemType ExpEpickiExp { get { return new ItemType("exp_epickiexp", "Epicki exp"); } }
        public ItemType ExpMeatMutated { get { return new ItemType("exp_meat_mutated", "Meat mutated"); } }
        public ItemType ExpMushroom { get { return new ItemType("exp_mushroom", "Mushroom"); } }
        public ItemType ExpNightmushroom { get { return new ItemType("exp_nightmushroom", "Nightmushroom"); } }
        public ItemType ExpPiskle { get { return new ItemType("exp_piskle", "Piskle"); } }
        public List<ItemType> ExpObjectItems 
        { 
            get 
            { 
                return new List<ItemType>() 
                { 
                    ExpBio2MeatMutated, 
                    ExpBio2Mushroom01, 
                    ExpBio2Nightmushroom01, 
                    ExpBio3MeatMutated, 
                    ExpBio3MushroomMeat01, 
                    ExpBio3Nightmushroom01, 
                    ExpCockroachMutated, 
                    ExpEpickiExp, 
                    ExpMeatMutated, 
                    ExpMushroom, 
                    ExpNightmushroom, 
                    ExpPiskle 
                }; 
            } 
        }
    }
}
