namespace DarkwoodEditor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            majVerLbl = new Label();
            rcVerLbl = new Label();
            minVerLbl = new Label();
            majVerComLbl = new Label();
            minVerComLbl = new Label();
            rcVerComLbl = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            closeMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            worldToolStripMenuItem = new ToolStripMenuItem();
            storyToolStripMenuItem = new ToolStripMenuItem();
            timeAndWeatherToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            howToUseDwConfigToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            rootBindingSource = new BindingSource(components);
            folderBrowserDialog1 = new FolderBrowserDialog();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // majVerLbl
            // 
            resources.ApplyResources(majVerLbl, "majVerLbl");
            majVerLbl.ForeColor = Color.White;
            majVerLbl.Name = "majVerLbl";
            // 
            // rcVerLbl
            // 
            resources.ApplyResources(rcVerLbl, "rcVerLbl");
            rcVerLbl.ForeColor = Color.White;
            rcVerLbl.Name = "rcVerLbl";
            // 
            // minVerLbl
            // 
            resources.ApplyResources(minVerLbl, "minVerLbl");
            minVerLbl.ForeColor = Color.White;
            minVerLbl.Name = "minVerLbl";
            // 
            // majVerComLbl
            // 
            resources.ApplyResources(majVerComLbl, "majVerComLbl");
            majVerComLbl.ForeColor = Color.White;
            majVerComLbl.Name = "majVerComLbl";
            // 
            // minVerComLbl
            // 
            resources.ApplyResources(minVerComLbl, "minVerComLbl");
            minVerComLbl.ForeColor = Color.White;
            minVerComLbl.Name = "minVerComLbl";
            // 
            // rcVerComLbl
            // 
            resources.ApplyResources(rcVerComLbl, "rcVerComLbl");
            rcVerComLbl.ForeColor = Color.White;
            rcVerComLbl.Name = "rcVerComLbl";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(fileToolStripMenuItem, "fileToolStripMenuItem");
            fileToolStripMenuItem.BackColor = Color.Transparent;
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, closeMenuItem, toolStripSeparator1, exitMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Padding = new Padding(0);
            // 
            // openMenuItem
            // 
            resources.ApplyResources(openMenuItem, "openMenuItem");
            openMenuItem.BackColor = Color.Transparent;
            openMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openMenuItem.ForeColor = Color.White;
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Padding = new Padding(0, 4, 0, 4);
            openMenuItem.Click += openItm_Click;
            // 
            // saveMenuItem
            // 
            resources.ApplyResources(saveMenuItem, "saveMenuItem");
            saveMenuItem.BackColor = Color.Transparent;
            saveMenuItem.ForeColor = Color.White;
            saveMenuItem.Name = "saveMenuItem";
            // 
            // closeMenuItem
            // 
            resources.ApplyResources(closeMenuItem, "closeMenuItem");
            closeMenuItem.BackColor = Color.Transparent;
            closeMenuItem.ForeColor = Color.White;
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Click += closeMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
            toolStripSeparator1.BackColor = Color.Transparent;
            toolStripSeparator1.ForeColor = Color.Transparent;
            toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // exitMenuItem
            // 
            resources.ApplyResources(exitMenuItem, "exitMenuItem");
            exitMenuItem.BackColor = Color.Transparent;
            exitMenuItem.ForeColor = Color.White;
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
            editToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem, worldToolStripMenuItem, storyToolStripMenuItem, timeAndWeatherToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            // 
            // playerToolStripMenuItem
            // 
            resources.ApplyResources(playerToolStripMenuItem, "playerToolStripMenuItem");
            playerToolStripMenuItem.ForeColor = Color.White;
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            // 
            // worldToolStripMenuItem
            // 
            resources.ApplyResources(worldToolStripMenuItem, "worldToolStripMenuItem");
            worldToolStripMenuItem.ForeColor = Color.White;
            worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            // 
            // storyToolStripMenuItem
            // 
            resources.ApplyResources(storyToolStripMenuItem, "storyToolStripMenuItem");
            storyToolStripMenuItem.ForeColor = Color.White;
            storyToolStripMenuItem.Name = "storyToolStripMenuItem";
            // 
            // timeAndWeatherToolStripMenuItem
            // 
            resources.ApplyResources(timeAndWeatherToolStripMenuItem, "timeAndWeatherToolStripMenuItem");
            timeAndWeatherToolStripMenuItem.ForeColor = Color.White;
            timeAndWeatherToolStripMenuItem.Name = "timeAndWeatherToolStripMenuItem";
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
            helpToolStripMenuItem.BackColor = Color.Transparent;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howToUseDwConfigToolStripMenuItem, aboutToolStripMenuItem, licenceToolStripMenuItem });
            helpToolStripMenuItem.ForeColor = Color.White;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // howToUseDwConfigToolStripMenuItem
            // 
            resources.ApplyResources(howToUseDwConfigToolStripMenuItem, "howToUseDwConfigToolStripMenuItem");
            howToUseDwConfigToolStripMenuItem.ForeColor = Color.White;
            howToUseDwConfigToolStripMenuItem.Name = "howToUseDwConfigToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            // 
            // licenceToolStripMenuItem
            // 
            resources.ApplyResources(licenceToolStripMenuItem, "licenceToolStripMenuItem");
            licenceToolStripMenuItem.ForeColor = Color.White;
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(minVerLbl);
            panel1.Controls.Add(majVerLbl);
            panel1.Controls.Add(minVerComLbl);
            panel1.Controls.Add(rcVerLbl);
            panel1.Controls.Add(rcVerComLbl);
            panel1.Controls.Add(majVerComLbl);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Name = "panel2";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.mainFormBg;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem worldToolStripMenuItem;
        private ToolStripMenuItem storyToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howToUseDwConfigToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem licenceToolStripMenuItem;
        private ToolStripMenuItem timeAndWeatherToolStripMenuItem;
        private Label majVerLbl;
        private Label minVerLbl;
        private Label majVerComLbl;
        private Label minVerComLbl;
        private Label rcVerLbl;
        private Label rcVerComLbl;
        private BindingSource rootBindingSource;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem closeMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenuItem;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
