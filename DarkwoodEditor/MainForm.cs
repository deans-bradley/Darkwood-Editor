using Newtonsoft.Json;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        static string? filePath;

        public MainForm()
        {
            InitializeComponent();

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

                Root rootData = loadRoot();

                majVerLbl.Text += rootData.majorVersion;
                minVerLbl.Text += rootData.minorVersion;
                majVerComLbl.Text += rootData.majorVersionCompatibility;
                minVerComLbl.Text += rootData.minorVersionCompatibility;
                rcVerLbl.Text += rootData.RCVersion;
                rcVerComLbl.Text += rootData.RCVersionCompatibility;

                addItemsToFlowLayout(rootData);
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();

            /* 
            * TODO: Check if current file has been modified
            * and confirm exit with MessageBox.
            *
            DialogResult dialogResult = MessageBox.Show("Sure?", "Title", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // do something
            }
            else if (dialogResult == DialogResult.No)
            {
                // do something else
            }
            */
        }

        private Root loadRoot()
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Root>(json);
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            majVerLbl.Text = Properties.Resources.majVer;
            minVerLbl.Text = Properties.Resources.minVer;
            majVerComLbl.Text = Properties.Resources.majrVerCom;
            minVerComLbl.Text = Properties.Resources.minVerCom;
            rcVerLbl.Text = Properties.Resources.rcVer;
            rcVerComLbl.Text = Properties.Resources.rcVerCom;
        }

        private void addItemsToFlowLayout(Root rootData)
        {
            Dictionary<string, string> dataMap = new Dictionary<string, string>()
            {
                { "Health", rootData.pS.health.ToString() },
                { "Stamina", rootData.pS.stamina.ToString() },
                { "Experience", rootData.pS.experience.ToString() },
                { "Current level", rootData.pS.currentLevel.ToString() }
            };

            foreach (var kvp in dataMap)
            {
                DwTextUserControl dwText = new DwTextUserControl();
                dwText.SetData(kvp.Key, kvp.Value);
                flowLayoutPanel1.Controls.Add(dwText);
            }
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
