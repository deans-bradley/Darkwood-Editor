using DarkwoodEditorWPF.Helpers.PropertyValues;
using DarkwoodEditorWPF.Models;
using DarkwoodEditorWPF.ViewModels;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;

namespace DarkwoodEditorWPF.Helpers
{
    public class ConvertCollections
    {
        // List<string> to ObservableCollection<StringValue>
        public ObservableCollection<StringValue> ConvertStringListToObservableCollection(List<string>? list)
        {
            ObservableCollection<StringValue> observableCollection = new ObservableCollection<StringValue>();

            foreach (string item in list ?? throw new NullReferenceException())
            {
                observableCollection.Add(new StringValue { Value = item });
            }

            return observableCollection;
        }

        // ObservableCollection<StringValue> to List<string>
        public List<string> ConvertObservableCollectionToStringList(ObservableCollection<StringValue> observableCollection)
        {
            List<string> list = new List<string>();

            foreach (StringValue item in observableCollection)
            {
                list.Add(item.Value ?? throw new NullReferenceException());
            }

            return list;
        }

        // List<int> to ObservableCollection<IntValue>
        public ObservableCollection<IntValue> ConvertIntListToObservableCollection(List<int> list)
        {
            ObservableCollection<IntValue> observableCollection = new ObservableCollection<IntValue>();

            foreach (int item in list)
            {
                observableCollection.Add(new IntValue { Value = item });
            }

            return observableCollection;
        }

        // ObservableCollection<IntValue> to List<int>
        public List<int> ConvertObservableCollectionToIntList(ObservableCollection<IntValue> observableCollection)
        {
            List<int> list = new List<int>();

            foreach (IntValue item in observableCollection)
            {
                list.Add(item.Value);
            }

            return list;
        }

        // List<object> to ObservableCollection<CraftedItemViewModel>
        public ObservableCollection<CraftedItemViewModel> ConvertCraftedItemListToObservableCollection(List<object> list)
        {
            ObservableCollection<CraftedItemViewModel> observableCollection = new ObservableCollection<CraftedItemViewModel>();

			foreach (object item in list)
			{
				JObject? jObject = item as JObject;

				CraftedItem? craftedItem = jObject?.ToObject<CraftedItem>();

                if (craftedItem != null)
                {
                    observableCollection.Add(new CraftedItemViewModel 
                    { 
                        StringValue = craftedItem._string, 
                        IntValue = craftedItem._int 
                    });
                }
			}

			return observableCollection;
        }

        // ObservableCollection<CraftedItemViewModel> to List<object>
        public List<object> ConvertObservableCollectionToCraftedItemList(ObservableCollection<CraftedItemViewModel> observableCollection)
        {
			List<object> list = new List<object>();

			foreach (CraftedItemViewModel item in observableCollection)
            {
			    JObject jObject = new JObject
                {
                    { "_string", item.StringValue },
                    { "_int", item.IntValue }
			    };

                list.Add(jObject);
			}

			return list;
		}

        // List<object> to ObservableCollection<EffectViewModel>
        public ObservableCollection<EffectViewModel> ConvertEffectListToObservableCollection(List<object> list)
        {
            ObservableCollection<EffectViewModel> observableCollection = new ObservableCollection<EffectViewModel>();

            foreach (object item in list)
            {
                JObject? jObject = item as JObject;

                Effect? effect = jObject?.ToObject<Effect>();

                if (effect != null)
                {
                    observableCollection.Add(new EffectViewModel
                    {
                        Type = effect.Type,
                        Duration = effect.Duration,
                        Modifier = effect.Modifier,
                        Interval = effect.Interval,
                        TimeElapsed = effect.TimeElapsed
                    });
                }
            }

            return observableCollection;
        }

        // ObservableCollection<EffectViewModel> to List<object>
        public List<object> ConvertObservableCollectionToEffectList(ObservableCollection<EffectViewModel> observableCollection)
        {
            List<object> list = new List<object>();

            foreach (EffectViewModel item in observableCollection)
            {
                JObject jObject = new JObject
                {
                    { "type", item.Type },
                    { "duration", item.Duration },
                    { "modifier", item.Modifier },
                    { "interval", item.Interval },
                    { "timeElapsed", item.TimeElapsed }
                };

                list.Add(jObject);
            }

            return list;
        }

        // TODO: Implement AvailableSkillsStates ObservableCollection conversion
        // List<object> to ObservableCollection<AvailableSkillsStatesViewModel>
        public ObservableCollection<AvailableSkillsStatesViewModel> ConvertAvailableSkillStatesListToObservableCollection(List<object> list)
        {
            ObservableCollection<AvailableSkillsStatesViewModel> observableCollection = new ObservableCollection<AvailableSkillsStatesViewModel>();

            foreach (object item in list)
            {
                JObject? jObject = item as JObject;

                AvailableSkillsStates? skillsStates = jObject?.ToObject<AvailableSkillsStates>();

                if (skillsStates != null)
                {
                    //observableCollection.Add(new SkillsStatesViewModel
                    //{

                    //});
                }
            }

            return observableCollection;
        }

        // TODO: Implement AvailableSkillsStates List conversion
        // ObservableCollection<AvailableSkillsStatesViewModel> to List<object>
        public List<object> ConvertObservableCollectionToAvailableSkillsStatesList(ObservableCollection<AvailableSkillsStatesViewModel> observableCollection)
        {
            List<object> list = new List<object>();

            foreach (AvailableSkillsStatesViewModel item in observableCollection)
            {
                JObject jObject = new JObject
                {

                };

                list.Add(jObject);
            }

            return list;
        }

        // List<object> to ObservableCollection<SkillsStatesViewModel>
        public ObservableCollection<SkillsStatesViewModel> ConvertSkillsStatesListToObservableCollection(List<object> list)
        {
            ObservableCollection<SkillsStatesViewModel> observableCollection = new ObservableCollection<SkillsStatesViewModel>();

            foreach (object item in list)
            {
                JObject? jObject = item as JObject;

                SkillsStates? skillsStates = jObject?.ToObject<SkillsStates>();

                if (skillsStates != null)
                {
                    observableCollection.Add(new SkillsStatesViewModel
                    {
                        Type = skillsStates.Type,
                        TimesUsed = skillsStates.TimesUsed
                    });
                }
            }

            return observableCollection;
        }

        // ObservableCollection<SkillsStatesViewModel> to List<object>
        public List<object> ConvertObservableCollectionToSkillsStatesList(ObservableCollection<SkillsStatesViewModel> observableCollection)
        {
            List<object> list = new List<object>();

            foreach (SkillsStatesViewModel item in observableCollection)
            {
                JObject jObject = new JObject
                {
                    { "type", item.Type },
                    { "timesUsed", item.TimesUsed }
                };

                list.Add(jObject);
            }

            return list;
        }

        // InvItem to InvItemViewModel
        public InvItemViewModel ConvertInvItemToInvItemViewModel(InvItem invItem)
        {
            if (invItem != null)
            {
                return new InvItemViewModel
                {
                    SlotId = invItem.SlotId,
                    Type = invItem.Type,
                    Durability = invItem.Durability,
                    Amount = invItem.Amount,
                    IsRecipe = invItem.IsRecipe,
                    RecipeFor = invItem.RecipeFor,
                    Modifiers = ConvertStringListToObservableCollection(invItem.Modifiers),
                    Upgrades = ConvertStringListToObservableCollection(invItem.Upgrades),
                    TimeDeactivated = invItem.TimeDeactivated,
                    ShouldBeActive = invItem.ShouldBeActive,
                    TimeSeen = invItem.TimeSeen
                };
            }
            else
            {
                return new InvItemViewModel();
            }
        }

        // InvItemViewModel to InvItem
        public InvItem ConvertInvItemViewModelToInvItem(InvItemViewModel invItemViewModel)
        {
            return new InvItem
            {
                SlotId = invItemViewModel.SlotId,
                Type = invItemViewModel.Type,
                Durability = invItemViewModel.Durability,
                Amount = invItemViewModel.Amount,
                IsRecipe = invItemViewModel.IsRecipe,
                RecipeFor = invItemViewModel.RecipeFor,
                Modifiers = ConvertObservableCollectionToStringList(invItemViewModel.Modifiers),
                Upgrades = ConvertObservableCollectionToStringList(invItemViewModel.Upgrades),
                TimeDeactivated = invItemViewModel.TimeDeactivated,
                ShouldBeActive = invItemViewModel.ShouldBeActive,
                TimeSeen = invItemViewModel.TimeSeen
            };
        }

        // List<object> to ObservableCollection<InvItemViewModel>
        public ObservableCollection<InvItemViewModel> ConvertInvItemListToObservableCollection(List<object> list)
        {
            ObservableCollection<InvItemViewModel> observableCollection = new ObservableCollection<InvItemViewModel>();

            foreach (object item in list)
            {
                JObject? jObject = item as JObject;

                InvItem? invItem = jObject?.ToObject<InvItem>();

                if (invItem != null)
                {
                    observableCollection.Add(new InvItemViewModel
                    {
                        SlotId = invItem.SlotId,
                        Type = invItem.Type,
                        Durability = invItem.Durability,
                        Amount = invItem.Amount,
                        IsRecipe = invItem.IsRecipe,
                        RecipeFor = invItem.RecipeFor,
                        Modifiers = ConvertStringListToObservableCollection(invItem.Modifiers),
                        Upgrades = ConvertStringListToObservableCollection(invItem.Upgrades),
                        TimeDeactivated = invItem.TimeDeactivated,
                        ShouldBeActive = invItem.ShouldBeActive,
                        TimeSeen = invItem.TimeSeen
                    });
                }
            }

            return observableCollection;
        }

        // ObservableCollection<InvItemViewModel> to List<object>
        public List<object> ConvertObservableCollectionToInvItemList(ObservableCollection<InvItemViewModel> observableCollection)
        {
            List<object> list = new List<object>();

            foreach (InvItemViewModel item in observableCollection)
            {
                JObject jObject = new JObject
                {
                    { "slotId", item.SlotId },
                    { "type", item.Type },
                    { "durability", item.Durability },
                    { "amount", item.Amount },
                    { "isRecipe", item.IsRecipe },
                    { "recipeFor", item.RecipeFor },
                    { "modifiers", JToken.FromObject(ConvertObservableCollectionToStringList(item.Modifiers)) },
                    { "upgrades", JToken.FromObject(ConvertObservableCollectionToStringList(item.Upgrades)) },
                    { "timeDeactivated", item.TimeDeactivated },
                    { "shouldBeActive", item.ShouldBeActive },
                    { "timeSeen", item.TimeSeen }
                };

                list.Add(jObject);
            }

            return list;
        }

        // List<object> to ObservableCollection<InventorySlotCopyViewModel>
        public ObservableCollection<InventorySlotCopyViewModel> ConvertInventorySlotCopyListToObservableCollection(List<object> list)
        {
            ObservableCollection<InventorySlotCopyViewModel> observableCollection = new ObservableCollection<InventorySlotCopyViewModel>();

            foreach (object item in list)
            {
                JObject? jObject = item as JObject;

                InventorySlotCopy? inventorySlotCopy = jObject?.ToObject<InventorySlotCopy>();

                if (inventorySlotCopy != null)
                {
                    observableCollection.Add(new InventorySlotCopyViewModel
                    {
                        Name = inventorySlotCopy.Name ?? "",
                        InHotbar = inventorySlotCopy.InHotbar,
                        InvItem = ConvertInvItemToInvItemViewModel(inventorySlotCopy.InvItem),
                        Selected = inventorySlotCopy.Selected,
                        InventoryId = inventorySlotCopy.InventoryId
                    });
                }
            }

            return observableCollection;
        }

        // ObservableCollection<InventorySlotCopyViewModel> to List<object>
        public List<object> ConvertObservableCollectionToInventorySlotCopyList(ObservableCollection<InventorySlotCopyViewModel> observableCollection)
        {
            List<object> list = new List<object>();

            foreach (InventorySlotCopyViewModel item in observableCollection)
            {
                JObject jObject = new JObject
                {
                    { "name", item.Name },
                    { "inHotbar", item.InHotbar },
                    { "invItem", JToken.FromObject(ConvertInvItemViewModelToInvItem(item.InvItem)) },
                    { "selected", item.Selected },
                    { "inventoryId", item.InventoryId }
                };

                list.Add(jObject);
            }

            return list;
        }
    }
}
