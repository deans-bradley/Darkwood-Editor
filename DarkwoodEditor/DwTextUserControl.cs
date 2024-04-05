namespace DarkwoodEditor
{
    public partial class DwTextUserControl : UserControl
    {
        public DwTextUserControl()
        {
            InitializeComponent();
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

        private void valueTxtBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
