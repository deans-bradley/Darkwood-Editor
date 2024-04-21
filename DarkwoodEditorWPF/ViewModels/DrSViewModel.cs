﻿using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class DrSViewModel : INotifyPropertyChanged
    {
        private List<string>? presetList;
        private bool hadDreamAtLvl2;
        private bool hadDreamAtLvl3;
        private bool hadDreamAtLvl5;
        private bool hadDreamAtLvl6;
        private bool hadDreamAtLvl7;
        private bool wantToDream;
        private object? dreamName;
        private double timeCopy;
        private int placeStartedDreamingID;
        private EffectsCopy? effectsCopy;
        private List<object>? inventorySlotsCopy;
        private List<object>? hotbarSlotsCopy;
        private List<double>? positionCopy;

        public List<string>? PresetList
        {
            get => presetList;
            set
            {
                presetList = value;
                OnPropertyChanged("PresetList");
            }
        }

        public bool HadDreamAtLvl2
        {
            get => hadDreamAtLvl2;
            set
            {
                hadDreamAtLvl2 = value;
                OnPropertyChanged("HadDreamAtLvl2");
            }
        }

        public bool HadDreamAtLvl3
        {
            get => hadDreamAtLvl3;
            set
            {
                hadDreamAtLvl3 = value;
                OnPropertyChanged("HadDreamAtLvl3");
            }
        }

        public bool HadDreamAtLvl5
        {
            get => hadDreamAtLvl5;
            set
            {
                hadDreamAtLvl5 = value;
                OnPropertyChanged("HadDreamAtLvl5");
            }
        }

        public bool HadDreamAtLvl6
        {
            get => hadDreamAtLvl6;
            set
            {
                hadDreamAtLvl6 = value;
                OnPropertyChanged("HadDreamAtLvl6");
            }
        }

        public bool HadDreamAtLvl7
        {
            get => hadDreamAtLvl7;
            set
            {
                hadDreamAtLvl7 = value;
                OnPropertyChanged("HadDreamAtLvl7");
            }
        }

        public bool WantToDream
        {
            get => wantToDream;
            set
            {
                wantToDream = value;
                OnPropertyChanged("WantToDream");
            }
        }

        public object? DreamName
        {
            get => dreamName;
            set
            {
                dreamName = value;
                OnPropertyChanged("DreamName");
            }
        }

        public double TimeCopy
        {
            get => timeCopy;
            set
            {
                timeCopy = value;
                OnPropertyChanged("TimeCopy");
            }
        }

        public int PlaceStartedDreamingID
        {
            get => placeStartedDreamingID;
            set
            {
                placeStartedDreamingID = value;
                OnPropertyChanged("PlaceStartedDreamingID");
            }
        }

        public EffectsCopy? EffectsCopy
        {
            get => effectsCopy;
            set
            {
                effectsCopy = value;
                OnPropertyChanged("EffectsCopy");
            }
        }

        public List<object>? InventorySlotsCopy
        {
            get => inventorySlotsCopy;
            set
            {
                inventorySlotsCopy = value;
                OnPropertyChanged("InventorySlotsCopy");
            }
        }

        public List<object>? HotbarSlotsCopy
        {
            get => hotbarSlotsCopy;
            set
            {
                hotbarSlotsCopy = value;
                OnPropertyChanged("HotbarSlotsCopy");
            }
        }

        public List<double>? PositionCopy
        {
            get => positionCopy;
            set
            {
                positionCopy = value;
                OnPropertyChanged("PositionCopy");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
