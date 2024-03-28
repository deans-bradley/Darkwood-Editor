namespace DarkwoodEditor
{
    public partial class DwTextUserControl : UserControl
    {
        public DwTextUserControl()
        {
            InitializeComponent();
        }

        public void SetData(string name, string value)
        {
            nameLbl.Text = name;
            valueTxtBox.Text = value;
        }
    }
}
