namespace DarkwoodEditorWPF.Data
{
    public class ItemType
    {
        public ItemType(string value, string name)
        {
            Value = value;
            Name = name;
        }
        public string Value { get; private set; }
        public string Name { get; private set; }
    }
}
