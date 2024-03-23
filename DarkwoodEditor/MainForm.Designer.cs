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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            majVerLbl = new Label();
            minVerLbl = new Label();
            majVerComLbl = new Label();
            minVerComLbl = new Label();
            rcVerLbl = new Label();
            rcVerComLbl = new Label();
            savDataGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(942, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, closeMenuItem, toolStripSeparator1, exitMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(155, 26);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openItm_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(155, 26);
            saveMenuItem.Text = "Save";
            // 
            // closeMenuItem
            // 
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Size = new Size(155, 26);
            closeMenuItem.Text = "Close File";
            closeMenuItem.Click += closeMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(152, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(155, 26);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem, worldToolStripMenuItem, storyToolStripMenuItem, timeAndWeatherToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(213, 26);
            playerToolStripMenuItem.Text = "Player";
            // 
            // worldToolStripMenuItem
            // 
            worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            worldToolStripMenuItem.Size = new Size(213, 26);
            worldToolStripMenuItem.Text = "Enviroment";
            // 
            // storyToolStripMenuItem
            // 
            storyToolStripMenuItem.Name = "storyToolStripMenuItem";
            storyToolStripMenuItem.Size = new Size(213, 26);
            storyToolStripMenuItem.Text = "World";
            // 
            // timeAndWeatherToolStripMenuItem
            // 
            timeAndWeatherToolStripMenuItem.Name = "timeAndWeatherToolStripMenuItem";
            timeAndWeatherToolStripMenuItem.Size = new Size(213, 26);
            timeAndWeatherToolStripMenuItem.Text = "Time and Weather";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howToUseDwConfigToolStripMenuItem, aboutToolStripMenuItem, licenceToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseDwConfigToolStripMenuItem
            // 
            howToUseDwConfigToolStripMenuItem.Name = "howToUseDwConfigToolStripMenuItem";
            howToUseDwConfigToolStripMenuItem.Size = new Size(237, 26);
            howToUseDwConfigToolStripMenuItem.Text = "How to use DwConfig";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(237, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // licenceToolStripMenuItem
            // 
            licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            licenceToolStripMenuItem.Size = new Size(237, 26);
            licenceToolStripMenuItem.Text = "Licence";
            // 
            // majVerLbl
            // 
            majVerLbl.AutoSize = true;
            majVerLbl.Location = new Point(16, 56);
            majVerLbl.Margin = new Padding(0, 0, 0, 6);
            majVerLbl.Name = "majVerLbl";
            majVerLbl.Size = new Size(107, 20);
            majVerLbl.TabIndex = 2;
            majVerLbl.Text = "Major Version: ";
            // 
            // minVerLbl
            // 
            minVerLbl.AutoSize = true;
            minVerLbl.Location = new Point(16, 82);
            minVerLbl.Margin = new Padding(0, 0, 0, 6);
            minVerLbl.Name = "minVerLbl";
            minVerLbl.Size = new Size(107, 20);
            minVerLbl.TabIndex = 3;
            minVerLbl.Text = "Minor Version: ";
            // 
            // majVerComLbl
            // 
            majVerComLbl.AutoSize = true;
            majVerComLbl.Location = new Point(16, 108);
            majVerComLbl.Margin = new Padding(0, 0, 0, 6);
            majVerComLbl.Name = "majVerComLbl";
            majVerComLbl.Size = new Size(201, 20);
            majVerComLbl.TabIndex = 4;
            majVerComLbl.Text = "Major Version Compatibility: ";
            // 
            // minVerComLbl
            // 
            minVerComLbl.AutoSize = true;
            minVerComLbl.Location = new Point(16, 134);
            minVerComLbl.Margin = new Padding(0, 0, 0, 6);
            minVerComLbl.Name = "minVerComLbl";
            minVerComLbl.Size = new Size(201, 20);
            minVerComLbl.TabIndex = 5;
            minVerComLbl.Text = "Minor Version Compatibility: ";
            // 
            // rcVerLbl
            // 
            rcVerLbl.AutoSize = true;
            rcVerLbl.Location = new Point(16, 160);
            rcVerLbl.Margin = new Padding(0, 0, 0, 6);
            rcVerLbl.Name = "rcVerLbl";
            rcVerLbl.Size = new Size(86, 20);
            rcVerLbl.TabIndex = 6;
            rcVerLbl.Text = "RC Version: ";
            // 
            // rcVerComLbl
            // 
            rcVerComLbl.AutoSize = true;
            rcVerComLbl.Location = new Point(16, 186);
            rcVerComLbl.Margin = new Padding(0, 0, 0, 6);
            rcVerComLbl.Name = "rcVerComLbl";
            rcVerComLbl.Size = new Size(180, 20);
            rcVerComLbl.TabIndex = 7;
            rcVerComLbl.Text = "RC Version Compatibility: ";
            // 
            // savDataGridView
            // 
            savDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            savDataGridView.Location = new Point(446, 56);
            savDataGridView.Name = "savDataGridView";
            savDataGridView.RowHeadersWidth = 51;
            savDataGridView.Size = new Size(484, 525);
            savDataGridView.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 593);
            Controls.Add(savDataGridView);
            Controls.Add(rcVerComLbl);
            Controls.Add(rcVerLbl);
            Controls.Add(minVerComLbl);
            Controls.Add(majVerComLbl);
            Controls.Add(minVerLbl);
            Controls.Add(majVerLbl);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Darkwood Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)savDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem closeMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenuItem;
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
        private DataGridView savDataGridView;
    }
}
