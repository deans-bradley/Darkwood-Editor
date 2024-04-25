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
    }
}
