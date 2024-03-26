using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        static string? filePath;

        public MainForm()
        {
            InitializeComponent();
            savDataGridView.RowsAdded += savDataGridView_RowsAdded;
        }

        private void openItm_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFile.InitialDirectory = $@"C:\Users\{Environment.UserName}\AppData\LocalLow\Acid Wizard Studio\Darkwood";

            openFile.ShowDialog();

            if (openFile.CheckFileExists)
            {
                filePath = openFile.FileName;

                Root rootData = loadRoot();

                majVerLbl.Text += rootData.majorVersion;
                minVerLbl.Text += rootData.minorVersion;
                majVerComLbl.Text += rootData.majorVersionCompatibility;
                minVerComLbl.Text += rootData.minorVersionCompatibility;
                rcVerLbl.Text += rootData.RCVersion;
                rcVerComLbl.Text += rootData.RCVersionCompatibility;

                PopulateDataGridView(rootData);
            }
            else
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
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
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

            savDataGridView.Rows.Clear();
        }

        private void PopulateDataGridView(Root root)
        {
            // PS
            savDataGridView.Rows.Add("Health", root.pS.health);
            savDataGridView.Rows.Add("Stamina", root.pS.stamina);
            savDataGridView.Rows.Add("Experience", root.pS.experience);
            savDataGridView.Rows.Add("Current level", root.pS.currentLevel);
            savDataGridView.Rows.Add("Health upgrades", root.pS.healthUpgrades);
            savDataGridView.Rows.Add("Stamina upgrades", root.pS.staminaUpgrades);
            savDataGridView.Rows.Add("Hotbar upgrades", root.pS.hotbarUpgrades);
            savDataGridView.Rows.Add("Inventory upgrades", root.pS.inventoryUpgrades);
            savDataGridView.Rows.Add("Last time ate", root.pS.lastTimeAte);
            savDataGridView.Rows.Add("Saturation", root.pS.saturation);
            savDataGridView.Rows.Add("Fed today", root.pS.fedToday);
            savDataGridView.Rows.Add("Lifes", root.pS.lifes);
            savDataGridView.Rows.Add("Got hit atleast once", root.pS.gotHitAtLeastOnce);
            savDataGridView.Rows.Add("Died atleast once", root.pS.diedAtLeastOnce);
        }

        private void savDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int columnIndex = 1;
            bool value;

            foreach (DataGridViewRow row in savDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                
                string cell = row.Cells[columnIndex].Value.ToString();
                
                if (bool.TryParse(cell, out value))
                {
                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = value;
                    row.Cells[columnIndex] = checkBoxCell;
                }
            }
        }
    }
}
