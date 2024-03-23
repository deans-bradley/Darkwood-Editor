using Newtonsoft.Json;
using System.Windows.Forms;

namespace DarkwoodEditor
{
    public partial class MainForm : Form
    {
        static string? filePath;

        public MainForm()
        {
            InitializeComponent();
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
        }

        private void InitializeDataGridView()
        {
            // TODO
        }

        private void PopulateDataGridView()
        {
            // TODO
        }
    }
}
