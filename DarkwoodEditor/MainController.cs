using Newtonsoft.Json;

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

        public void UpdateRoot(Root root)
        {
            rootData = root;
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

        public void GetViewData()
        {

        }
    }
}