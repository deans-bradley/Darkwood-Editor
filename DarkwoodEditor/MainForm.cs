using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        string? filePath;

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

                addItemsToLabels(rootData);
                addItemsToFlowLayout(rootData);
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        private Root loadRoot()
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Root>(json);
        }

        private void addItemsToLabels(Root rootData)
        {
            majVerLbl.Text += rootData.majorVersion;
            minVerLbl.Text += rootData.minorVersion;
            majVerComLbl.Text += rootData.majorVersionCompatibility;
            minVerComLbl.Text += rootData.minorVersionCompatibility;
            rcVerLbl.Text += rootData.RCVersion;
            rcVerComLbl.Text += rootData.RCVersionCompatibility;
        }

        private void addItemsToFlowLayout(Root rootData)
        {
            Dictionary<string, string> dataMap = new Dictionary<string, string>
            {
                { "Health", rootData.pS.health.ToString() },
                { "Stamina", rootData.pS.stamina.ToString() },
                { "Experience", rootData.pS.experience.ToString() },
                { "Current level", rootData.pS.currentLevel.ToString() },
                { "Health upgrades", rootData.pS.healthUpgrades.ToString() },
                { "Stamina upgrades", rootData.pS.staminaUpgrades.ToString() },
                { "Hotbar upgrades", rootData.pS.hotbarUpgrades.ToString() },
                { "Inventory upgrades", rootData.pS.inventoryUpgrades.ToString() },
                { "Last time ate", rootData.pS.lastTimeAte.ToString() },
                { "Saturation", rootData.pS.saturation.ToString() },
                { "Fed today", rootData.pS.fedToday.ToString() },
                { "Lifes", rootData.pS.lifes.ToString() },
                { "Got hit atleast once", rootData.pS.gotHitAtLeastOnce.ToString() },
                { "Died atleast once", rootData.pS.diedAtLeastOnce.ToString() }
            };

            foreach (var kvp in dataMap)
            {
                DwTextUserControl dwText = new DwTextUserControl();
                DwCheckUserControl dwCheck = new DwCheckUserControl();

                bool value;
                if (bool.TryParse(kvp.Value, out value))
                {
                    dwCheck.Name = kvp.Key;
                    dwCheck.Value = value;

                    flowLayoutPanel1.Controls.Add(dwCheck);
                }
                else
                {
                    dwText.Name = kvp.Key;
                    dwText.Value = kvp.Value;

                    flowLayoutPanel1.Controls.Add(dwText);
                }
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            bool fileChanged = isFileChanged();

            if (fileChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to close the current file?", "File not saved", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    updateFileChangedStatus();
                    clearFile();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (!fileChanged)
            {
                clearFile();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            bool fileChanged = isFileChanged();

            if (fileChanged)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "File not saved", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            else if (!fileChanged)
            {
                Close();
            }
        }

        private void clearFile()
        {
            majVerLbl.Text = Properties.Resources.majVer;
            minVerLbl.Text = Properties.Resources.minVer;
            majVerComLbl.Text = Properties.Resources.majrVerCom;
            minVerComLbl.Text = Properties.Resources.minVerCom;
            rcVerLbl.Text = Properties.Resources.rcVer;
            rcVerComLbl.Text = Properties.Resources.rcVerCom;

            flowLayoutPanel1.Controls.Clear();
        }

        private bool isFileChanged()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is DwTextUserControl dwText)
                {
                    if (dwText.ValueChanged)
                    {
                        return true;
                    }
                }
                else if (control is DwCheckUserControl dwCheck)
                {
                    if (dwCheck.ValueChanged)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void updateFileChangedStatus()
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is DwTextUserControl dwControl)
                {
                    dwControl.UpdateOriginalValue();
                }
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

        private void testBtn_Click(object sender, EventArgs e)
        {

        }
    }
}