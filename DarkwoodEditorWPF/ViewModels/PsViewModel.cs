using DarkwoodEditorWPF.Helpers;
using DarkwoodEditorWPF.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class PsViewModel : ConvertCollections, INotifyPropertyChanged
    {
        private List<double> position = new List<double>();
        private List<double> rotation = new List<double>();
        private double health;
        private double stamina;
        private int experience;
        private int currentLevel;
        private int healthUpgrades;
        private int staminaUpgrades;
        private int hotbarUpgrades;
        private int inventoryUpgrades;
        private int lastTimeAte;
        private double saturation;
        private bool fedToday;
        private int lifes;
        private ObservableCollection<StringValue> recipes = new ObservableCollection<StringValue>();
        private List<object> craftedItems = new List<object>();
        private ChEffS? chEffS;
        private SkillS? skillS;
        private int expMachineId;
        private bool examinedExpMachine;
        private bool gotHitAtLeastOnce;
        private bool diedAtLeastOnce;

        public List<double> Position
        {
            get => position;
            set
            {
                position = value;
                OnPropertyChanged("Position");
            }
        }

        public List<double> Rotation
        {
            get => rotation;
            set
            {
                rotation = value;
                OnPropertyChanged("Rotation");
            }
        }

        public double Health
        {
            get => health;
            set
            {
                health = value;
                OnPropertyChanged("Health");
            }
        }

        public double Stamina
        {
            get => stamina;
            set
            {
                stamina = value;
                OnPropertyChanged("Stamina");
            }
        }

        public int Experience
        {
            get => experience;
            set
            {
                experience = value;
                OnPropertyChanged("Experience");
            }
        }

        public int CurrentLevel
        {
            get => currentLevel;
            set
            {
                currentLevel = value;
                OnPropertyChanged("CurrentLevel");
            }
        }

        public int HealthUpgrades
        {
            get => healthUpgrades;
            set
            {
                healthUpgrades = value;
                OnPropertyChanged("HealthUpgrades");
            }
        }

        public int StaminaUpgrades
        {
            get => staminaUpgrades;
            set
            {
                staminaUpgrades = value;
                OnPropertyChanged("StaminaUpgrades");
            }
        }

        public int HotbarUpgrades
        {
            get => hotbarUpgrades;
            set
            {
                hotbarUpgrades = value;
                OnPropertyChanged("HotbarUpgrades");
            }
        }

        public int InventoryUpgrades
        {
            get => inventoryUpgrades;
            set
            {
                inventoryUpgrades = value;
                OnPropertyChanged("InventoryUpgrades");
            }
        }

        public int LastTimeAte
        {
            get => lastTimeAte;
            set
            {
                lastTimeAte = value;
                OnPropertyChanged("LastTimeAte");
            }
        }

        public double Saturation
        {
            get => saturation;
            set
            {
                saturation = value;
                OnPropertyChanged("Saturation");
            }
        }

        public bool FedToday
        {
            get => fedToday;
            set
            {
                fedToday = value;
                OnPropertyChanged("FedToday");
            }
        }

        public int Lifes
        {
            get => lifes;
            set
            {
                lifes = value;
                OnPropertyChanged("Lifes");
            }
        }

        public ObservableCollection<StringValue> Recipes
        {
            get => recipes;
            set
            {
                recipes = value;
                OnPropertyChanged("Recipes");
            }
        }

        public List<object> CraftedItems
        {
            get => craftedItems;
            set
            {
                craftedItems = value;
                OnPropertyChanged("CraftedItems");
            }
        }

        public ChEffS? ChEffS
        {
            get => chEffS;
            set
            {
                chEffS = value;
                OnPropertyChanged("ChEffS");
            }
        }

        public SkillS? SkillS
        {
            get => skillS;
            set
            {
                skillS = value;
                OnPropertyChanged("SkillS");
            }
        }

        public int ExpMachineId
        {
            get => expMachineId;
            set
            {
                expMachineId = value;
                OnPropertyChanged("ExpMachineId");
            }
        }

        public bool ExaminedExpMachine
        {
            get => examinedExpMachine;
            set
            {
                examinedExpMachine = value;
                OnPropertyChanged("ExaminedExpMachine");
            }
        }

        public bool GotHitAtLeastOnce
        {
            get => gotHitAtLeastOnce;
            set
            {
                gotHitAtLeastOnce = value;
                OnPropertyChanged("GotHitAtLeastOnce");
            }
        }

        public bool DiedAtLeastOnce
        {
            get => diedAtLeastOnce;
            set
            {
                diedAtLeastOnce = value;
                OnPropertyChanged("DiedAtLeastOnce");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
