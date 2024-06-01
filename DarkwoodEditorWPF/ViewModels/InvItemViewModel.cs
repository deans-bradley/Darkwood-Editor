using DarkwoodEditorWPF.Helpers;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class InvItemViewModel : INotifyPropertyChanged
    {
        private int slotId;
        private string? type;
        private double durability;
        private int amount;
        private bool isRecipe;
        private string? recipeFor;
        private ObservableCollection<StringValue> modifiers = new ObservableCollection<StringValue>();
        private ObservableCollection<StringValue> upgrades = new ObservableCollection<StringValue>();
        private double timeDeactivated;
        private bool shouldBeActive;
        private double timeSeen;

        public int SlotId
        {
            get => slotId;
            set
            {
                slotId = value;
                OnPropertyChanged("SlotId");
            }
        }

        public string? Type
        {
            get => type;
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        public double Durability
        {
            get => durability;
            set
            {
                durability = value;
                OnPropertyChanged("Durability");
            }
        }

        public int Amount
        {
            get => amount;
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public bool IsRecipe
        {
            get => isRecipe;
            set
            {
                isRecipe = value;
                OnPropertyChanged("IsRecipe");
            }
        }

        public string? RecipeFor
        {
            get => recipeFor;
            set
            {
                recipeFor = value;
                OnPropertyChanged("RecipeFor");
            }
        }

        public ObservableCollection<StringValue> Modifiers
        {
            get => modifiers;
            set
            {
                modifiers = value;
                OnPropertyChanged("Modifiers");
            }
        }

        public ObservableCollection<StringValue> Upgrades
        {
            get => upgrades;
            set
            {
                upgrades = value;
                OnPropertyChanged("Upgrades");
            }
        }

        public double TimeDeactivated
        {
            get => timeDeactivated;
            set
            {
                timeDeactivated = value;
                OnPropertyChanged("TimeDeactivated");
            }
        }

        public bool ShouldBeActive
        {
            get => shouldBeActive;
            set
            {
                shouldBeActive = value;
                OnPropertyChanged("ShouldBeActive");
            }
        }

        public double TimeSeen
        {
            get => timeSeen;
            set
            {
                timeSeen = value;
                OnPropertyChanged("TimeSeen");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}