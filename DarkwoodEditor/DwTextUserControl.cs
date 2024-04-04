namespace DarkwoodEditor
{
    public partial class DwTextUserControl : UserControl
    {
        private string originalValue;
        private bool valueChanged;

        public DwTextUserControl()
        {
            InitializeComponent();
            originalValue = valueTxtBox.Text;
            valueTxtBox.TextChanged += valueTxtBox_TextChanged;
        }

        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public string Value
        {
            get { return valueTxtBox.Text; }
            set 
            { 
                valueTxtBox.Text = value;
                originalValue = value;
                valueChanged = false;
            }
        }

        public bool ValueChanged
        {
            get { return originalValue != valueTxtBox.Text; }
            private set { valueChanged = value; }
        }

        public void UpdateOriginalValue()
        {
            originalValue = valueTxtBox.Text;
        }

        private void valueTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (originalValue == valueTxtBox.Text)
            {
                ValueChanged = true;
            }
            else
            {
                ValueChanged = false;
            }
        }
    }
}
