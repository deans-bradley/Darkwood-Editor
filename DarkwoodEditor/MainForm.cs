using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Windows.Forms;
using static DarkwoodEditor.MainForm;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        static string? filePath;

        public MainForm()
        {
            InitializeComponent();
            
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());

            savDataGridView.EditingControlShowing += savDataGridView_EditingControlShowing;
            savDataGridView.CellValidating += savDataGridView_CellValidating;
            savDataGridView.RowsAdded += savDataGridView_RowsAdded;
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

                PopulateDataGridView(rootData);
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

            int rowIndex = savDataGridView.Rows.Add("Recipes");

            DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
            comboBoxCell.FlatStyle = FlatStyle.Standard;
            comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;

            foreach (var item in root.pS.recipes)
            {
                comboBoxCell.Items.AddRange(item);
                comboBoxCell.Value = item;
            }

            savDataGridView.Rows[rowIndex].Cells[1] = comboBoxCell;
        }

        // Check the data type of the cell and covert cell to appropriate cell type
        private void savDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int columnIndex = 1;
            bool value;

            foreach (DataGridViewRow row in savDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[columnIndex].Value == null) continue;

                string cell = row.Cells[columnIndex].Value.ToString();

                if (bool.TryParse(cell, out value))
                {
                    DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                    checkBoxCell.Value = value;
                    row.Cells[columnIndex] = checkBoxCell;
                }
            }
        }

        // Check the data type of the cell and covert cell to appropriate cell type
        private void savDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox comboBox)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void savDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Check if cell is a DataGridViewComboBoxCell
            if (savDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewComboBoxCell)
            {
                if (e.ColumnIndex == 1)
                {
                    DataGridViewComboBoxCell comboBoxCell = savDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                    if (!comboBoxCell.Items.Contains(e.FormattedValue))
                    {
                        comboBoxCell.Items.Add(e.FormattedValue);
                    }
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
    }
}
