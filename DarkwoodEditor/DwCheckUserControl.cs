using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkwoodEditor
{
    public partial class DwCheckUserControl : UserControl
    {
        private bool originalValue;
        private bool valueChanged;

        public DwCheckUserControl()
        {
            InitializeComponent();
            originalValue = valueChkBox.Checked;
            valueChkBox.CheckedChanged += valueChkBox_CheckedChanged;
        }

        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }

        public bool Value
        {
            get { return valueChkBox.Checked; }
            set
            {
                valueChkBox.Checked = value;
                originalValue = value;
                valueChanged = false;
            }
        }

        public bool ValueChanged
        {
            get { return originalValue != valueChkBox.Checked; }
            private set { valueChanged = value; }
        }

        public void UpdateOriginalValue()
        {
            originalValue = valueChkBox.Checked;
        }

        private void valueChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (originalValue == valueChkBox.Checked)
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
