using DarkwoodEditorWPF.Models;
using System.Collections.ObjectModel;

namespace DarkwoodEditorWPF.Helpers
{
    // TODO: Change from interface to abstract class
    public interface IConvertCollection
    {
        // Convert a List of strings to an ObservableCollection of StringValues
        private ObservableCollection<StringValue> ConvertStringListToObservableCollection(List<string> list)
        {
            ObservableCollection<StringValue> observableCollection = new ObservableCollection<StringValue>();

            foreach (string item in list)
            {
                observableCollection.Add(new StringValue { Value = item });
            }

            return observableCollection;
        }

        private List<string> ConvertObservableCollectionToStringList(ObservableCollection<StringValue> observableCollection)
        {
            List<string> list = new List<string>();

            foreach (StringValue item in observableCollection)
            {
                list.Add(item.Value ?? throw new NullReferenceException());
            }

            return list;
        }

        // TODO: Add more methods to convert other types of collections
    }
}
