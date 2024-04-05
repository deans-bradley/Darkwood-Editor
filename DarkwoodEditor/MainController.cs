namespace DarkwoodEditor
{
    public class MainController
    {
        private Root rootData;
        private MainForm mainForm;

        public MainController(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public void UpdateRoot(List<string> rootValues)
        {
            rootData = mainForm.DeserializeJson();

            rootData.pS.health = Double.Parse(rootValues[0]);
            rootData.pS.stamina = Double.Parse(rootValues[1]);
            rootData.pS.experience = Int32.Parse(rootValues[2]);
            rootData.pS.currentLevel = Int32.Parse(rootValues[3]);
            rootData.pS.healthUpgrades = Int32.Parse(rootValues[4]);
            rootData.pS.staminaUpgrades = Int32.Parse(rootValues[5]);
            rootData.pS.hotbarUpgrades = Int32.Parse(rootValues[6]);
            rootData.pS.inventoryUpgrades = Int32.Parse(rootValues[7]);
            rootData.pS.lastTimeAte = Int32.Parse(rootValues[8]);
            rootData.pS.saturation = Double.Parse(rootValues[9]);
            rootData.pS.fedToday = bool.Parse(rootValues[10]);
            rootData.pS.lifes = Int32.Parse(rootValues[11]);
            rootData.pS.gotHitAtLeastOnce = bool.Parse(rootValues[12]);
            rootData.pS.diedAtLeastOnce = bool.Parse(rootValues[13]);
        }

        public void LoadRootData(Root root)
        {
            rootData = root;
            UpdateView();
        }

        public void UpdateView()
        {
            mainForm.ClearData();

            mainForm.AddToLabels(rootData);

            mainForm.AddToFlowLayout("Health", rootData.pS.health.ToString());
            mainForm.AddToFlowLayout("Stamina", rootData.pS.stamina.ToString());
            mainForm.AddToFlowLayout("Experience", rootData.pS.experience.ToString());
            mainForm.AddToFlowLayout("Current level", rootData.pS.currentLevel.ToString());
            mainForm.AddToFlowLayout("Health upgrades", rootData.pS.healthUpgrades.ToString());
            mainForm.AddToFlowLayout("Stamina upgrades", rootData.pS.staminaUpgrades.ToString());
            mainForm.AddToFlowLayout("Hotbar upgrades", rootData.pS.hotbarUpgrades.ToString());
            mainForm.AddToFlowLayout("Inventory upgrades", rootData.pS.inventoryUpgrades.ToString());
            mainForm.AddToFlowLayout("Last time ate", rootData.pS.lastTimeAte.ToString());
            mainForm.AddToFlowLayout("Saturation", rootData.pS.saturation.ToString());
            mainForm.AddToFlowLayout("Fed today", rootData.pS.fedToday.ToString());
            mainForm.AddToFlowLayout("Lifes", rootData.pS.lifes.ToString());
            mainForm.AddToFlowLayout("Got hit atleast once", rootData.pS.gotHitAtLeastOnce.ToString());
            mainForm.AddToFlowLayout("Died atleast once", rootData.pS.diedAtLeastOnce.ToString());
        }
    }
}