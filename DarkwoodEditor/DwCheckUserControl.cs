namespace DarkwoodEditor
{
    public partial class DwCheckUserControl : UserControl
    {
        public DwCheckUserControl()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public bool Value
        {
            get { return valueChkBox.Checked; }
            set { valueChkBox.Checked = value; }
        }

        private void valueChkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
