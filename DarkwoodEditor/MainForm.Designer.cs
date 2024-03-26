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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            rootBindingSource = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)savDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
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
            fileToolStripMenuItem.BackColor = Color.Transparent;
            fileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, closeMenuItem, toolStripSeparator1, exitMenuItem });
            fileToolStripMenuItem.ForeColor = Color.White;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openMenuItem.Size = new Size(181, 26);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openItm_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveMenuItem.Size = new Size(181, 26);
            saveMenuItem.Text = "Save";
            // 
            // closeMenuItem
            // 
            closeMenuItem.Name = "closeMenuItem";
            closeMenuItem.Size = new Size(181, 26);
            closeMenuItem.Text = "Close File";
            closeMenuItem.Click += closeMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitMenuItem.Size = new Size(181, 26);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem, worldToolStripMenuItem, storyToolStripMenuItem, timeAndWeatherToolStripMenuItem });
            editToolStripMenuItem.ForeColor = Color.White;
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
            helpToolStripMenuItem.ForeColor = Color.White;
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
            majVerLbl.ForeColor = Color.White;
            majVerLbl.Location = new Point(10, 10);
            majVerLbl.Margin = new Padding(0, 0, 0, 6);
            majVerLbl.Name = "majVerLbl";
            majVerLbl.Size = new Size(107, 20);
            majVerLbl.TabIndex = 2;
            majVerLbl.Text = "Major Version: ";
            // 
            // minVerLbl
            // 
            minVerLbl.AutoSize = true;
            minVerLbl.ForeColor = Color.White;
            minVerLbl.Location = new Point(10, 36);
            minVerLbl.Margin = new Padding(0, 0, 0, 6);
            minVerLbl.Name = "minVerLbl";
            minVerLbl.Size = new Size(107, 20);
            minVerLbl.TabIndex = 3;
            minVerLbl.Text = "Minor Version: ";
            // 
            // majVerComLbl
            // 
            majVerComLbl.AutoSize = true;
            majVerComLbl.ForeColor = Color.White;
            majVerComLbl.Location = new Point(10, 62);
            majVerComLbl.Margin = new Padding(0, 0, 0, 6);
            majVerComLbl.Name = "majVerComLbl";
            majVerComLbl.Size = new Size(201, 20);
            majVerComLbl.TabIndex = 4;
            majVerComLbl.Text = "Major Version Compatibility: ";
            // 
            // minVerComLbl
            // 
            minVerComLbl.AutoSize = true;
            minVerComLbl.ForeColor = Color.White;
            minVerComLbl.Location = new Point(10, 88);
            minVerComLbl.Margin = new Padding(0, 0, 0, 6);
            minVerComLbl.Name = "minVerComLbl";
            minVerComLbl.Size = new Size(201, 20);
            minVerComLbl.TabIndex = 5;
            minVerComLbl.Text = "Minor Version Compatibility: ";
            // 
            // rcVerLbl
            // 
            rcVerLbl.AutoSize = true;
            rcVerLbl.ForeColor = Color.White;
            rcVerLbl.Location = new Point(10, 114);
            rcVerLbl.Margin = new Padding(0, 0, 0, 6);
            rcVerLbl.Name = "rcVerLbl";
            rcVerLbl.Size = new Size(86, 20);
            rcVerLbl.TabIndex = 6;
            rcVerLbl.Text = "RC Version: ";
            // 
            // rcVerComLbl
            // 
            rcVerComLbl.AutoSize = true;
            rcVerComLbl.ForeColor = Color.White;
            rcVerComLbl.Location = new Point(10, 140);
            rcVerComLbl.Margin = new Padding(0, 0, 0, 6);
            rcVerComLbl.Name = "rcVerComLbl";
            rcVerComLbl.Size = new Size(180, 20);
            rcVerComLbl.TabIndex = 7;
            rcVerComLbl.Text = "RC Version Compatibility: ";
            // 
            // savDataGridView
            // 
            savDataGridView.AllowUserToAddRows = false;
            savDataGridView.AllowUserToDeleteRows = false;
            savDataGridView.AllowUserToOrderColumns = true;
            savDataGridView.AllowUserToResizeColumns = false;
            savDataGridView.AllowUserToResizeRows = false;
            savDataGridView.BackgroundColor = Color.FromArgb(40, 40, 40);
            savDataGridView.BorderStyle = BorderStyle.None;
            savDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            savDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            savDataGridView.ColumnHeadersVisible = false;
            savDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            savDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            savDataGridView.Dock = DockStyle.Fill;
            savDataGridView.GridColor = SystemColors.ButtonShadow;
            savDataGridView.Location = new Point(10, 10);
            savDataGridView.Name = "savDataGridView";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            savDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            savDataGridView.RowHeadersVisible = false;
            savDataGridView.RowHeadersWidth = 51;
            savDataGridView.Size = new Size(551, 517);
            savDataGridView.TabIndex = 8;
            savDataGridView.RowsAdded += savDataGridView_RowsAdded;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Value";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(savDataGridView);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(371, 28);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 10, 10, 38);
            panel1.Size = new Size(571, 565);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(majVerLbl);
            panel2.Controls.Add(minVerLbl);
            panel2.Controls.Add(rcVerComLbl);
            panel2.Controls.Add(majVerComLbl);
            panel2.Controls.Add(rcVerLbl);
            panel2.Controls.Add(minVerComLbl);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 28);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(371, 565);
            panel2.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.mainFormBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Darkwood Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)savDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)rootBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private BindingSource rootBindingSource;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
