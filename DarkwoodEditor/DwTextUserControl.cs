namespace DarkwoodEditor
{
    public partial class DwTextUserControl : UserControl
    {
        public DwTextUserControl(string name, string value)
        {
            InitializeComponent();
            Name = name;
            Value = value;
        }

        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public string Value
        {
            get { return valueTxtBox.Text; }
            set { valueTxtBox.Text = value; }
        }
    }
}
