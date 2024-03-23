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
            helpToolStripMenuItem = new ToolStripMenuItem();
            howToUseDwConfigToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            licenceToolStripMenuItem = new ToolStripMenuItem();
            majorVerLbl = new Label();
            majorVerTxtBox = new TextBox();
            minorVerLbl = new Label();
            minorVerTxtBox = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
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
            openMenuItem.Size = new Size(128, 26);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openItm_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(128, 26);
            saveMenuItem.Text = "Save";
            // 
            // closeMenuItem
            // 
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Size = new Size(128, 26);
            closeMenuItem.Text = "Close";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(125, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(128, 26);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem, worldToolStripMenuItem, storyToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(167, 26);
            playerToolStripMenuItem.Text = "Player";
            // 
            // worldToolStripMenuItem
            // 
            worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            worldToolStripMenuItem.Size = new Size(167, 26);
            worldToolStripMenuItem.Text = "Enviroment";
            // 
            // storyToolStripMenuItem
            // 
            storyToolStripMenuItem.Name = "storyToolStripMenuItem";
            storyToolStripMenuItem.Size = new Size(167, 26);
            storyToolStripMenuItem.Text = "World";
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
            // majorVerLbl
            // 
            majorVerLbl.AutoSize = true;
            majorVerLbl.Location = new Point(12, 42);
            majorVerLbl.Name = "majorVerLbl";
            majorVerLbl.Size = new Size(103, 20);
            majorVerLbl.TabIndex = 2;
            majorVerLbl.Text = "Major Version:";
            // 
            // majorVerTxtBox
            // 
            majorVerTxtBox.Location = new Point(12, 65);
            majorVerTxtBox.Name = "majorVerTxtBox";
            majorVerTxtBox.Size = new Size(125, 27);
            majorVerTxtBox.TabIndex = 3;
            // 
            // minorVerLbl
            // 
            minorVerLbl.AutoSize = true;
            minorVerLbl.Location = new Point(12, 104);
            minorVerLbl.Name = "minorVerLbl";
            minorVerLbl.Size = new Size(103, 20);
            minorVerLbl.TabIndex = 4;
            minorVerLbl.Text = "Minor Version:";
            // 
            // minorVerTxtBox
            // 
            minorVerTxtBox.Location = new Point(12, 127);
            minorVerTxtBox.Name = "minorVerTxtBox";
            minorVerTxtBox.Size = new Size(125, 27);
            minorVerTxtBox.TabIndex = 5;
            // 
            // MainForm
            // 
            Controls.Add(minorVerTxtBox);
            Controls.Add(minorVerLbl);
            Controls.Add(majorVerTxtBox);
            Controls.Add(majorVerLbl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Darkwood Editor";
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
        private Label majorVerLbl;
        private TextBox majorVerTxtBox;
        private Label minorVerLbl;
        private TextBox minorVerTxtBox;
    }
}
