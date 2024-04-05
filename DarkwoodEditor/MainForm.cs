using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        private MainController mainController;
        string? filePath;

        public MainForm()
        {
            InitializeComponent();
            mainController = new MainController(this);
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
        }

        private void openItm_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFile.InitialDirectory = $@"C:\Users\{Environment.UserName}\AppData\LocalLow\Acid Wizard Studio\Darkwood";

            openFile.ShowDialog();

            if (openFile.CheckFileExists && openFile.FileName != String.Empty)
            {
                filePath = openFile.FileName;
                string json = File.ReadAllText(filePath);
                Root root = JsonConvert.DeserializeObject<Root>(json);

                mainController.LoadRootData(root);
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void AddToLabels(Root rootData)
        {
            majVerLbl.Text += rootData.majorVersion;
            minVerLbl.Text += rootData.minorVersion;
            majVerComLbl.Text += rootData.majorVersionCompatibility;
            minVerComLbl.Text += rootData.minorVersionCompatibility;
            rcVerLbl.Text += rootData.RCVersion;
            rcVerComLbl.Text += rootData.RCVersionCompatibility;
        }

        public void AddToFlowLayout(string name, string value)
        {
            DwTextUserControl dwText = new DwTextUserControl();
            DwCheckUserControl dwCheck = new DwCheckUserControl();

            bool boolValue;
            if (bool.TryParse(value, out boolValue))
            {
                dwCheck.Name = name;
                dwCheck.Value = boolValue;

                flowLayoutPanel1.Controls.Add(dwCheck);
            }
            else
            {
                dwText.Name = name;
                dwText.Value = value;

                flowLayoutPanel1.Controls.Add(dwText);
            }
        }

        public void ClearData()
        {
            majVerLbl.Text = Properties.Resources.majVer;
            minVerLbl.Text = Properties.Resources.minVer;
            majVerComLbl.Text = Properties.Resources.majrVerCom;
            minVerComLbl.Text = Properties.Resources.minVerCom;
            rcVerLbl.Text = Properties.Resources.rcVer;
            rcVerComLbl.Text = Properties.Resources.rcVerCom;

            flowLayoutPanel1.Controls.Clear();
        }

        // CREDIT: https://stackoverflow.com/questions/36767478/color-change-for-menuitem
        public class CustomColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(215, 0, 0, 0); }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.FromArgb(0, 0, 0, 0); }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.FromArgb(0, 0, 0, 0); }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return Color.FromArgb(0, 0, 0, 0); }
            }

            public override Color MenuBorder
            {
                get { return Color.FromArgb(50, 255, 255, 255); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(50, 255, 255, 255); }
            }

            public override Color MenuItemSelected
            {
                get { return Color.FromArgb(150, 0, 0, 0); }
            }

            public override Color MenuStripGradientBegin
            {
                get { return Color.FromArgb(50, 0, 0, 0); }
            }

            public override Color MenuStripGradientEnd
            {
                get { return Color.FromArgb(50, 0, 0, 0); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(150, 0, 0, 0); }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(150, 0, 0, 0); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(50, 255, 255, 255); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(50, 255, 255, 255); }
            }
        }
    }
}