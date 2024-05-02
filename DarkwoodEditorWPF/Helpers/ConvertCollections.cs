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
        public ObservableCollection<CraftedItemViewModel> ConvertCraftedItemViewModelListToObservableCollection(List<object> list)
        {
            ObservableCollection<CraftedItemViewModel> observableCollection = new ObservableCollection<CraftedItemViewModel>();

			foreach (object item in list)
			{
				JObject? jObject = item as JObject;

				CraftedItem? craftedItem = jObject?.ToObject<CraftedItem>();

                observableCollection.Add(new CraftedItemViewModel { StringValue = craftedItem?._string ?? throw new NullReferenceException(), IntValue = craftedItem._int });
			}

			return observableCollection;
        }

        // ObservableCollection<CraftedItemViewModel> to List<object>
        public List<object> ConvertObservableCollectionToCraftedItemViewModelList(ObservableCollection<CraftedItemViewModel> observableCollection)
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
    }
}
