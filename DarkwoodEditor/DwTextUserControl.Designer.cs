namespace DarkwoodEditor
{
    partial class DwTextUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLbl = new Label();
            valueTxtBox = new TextBox();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("PF Tempesta Seven", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(10, 11);
            nameLbl.Margin = new Padding(0, 1, 0, 1);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(74, 25);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // valueTxtBox
            // 
            valueTxtBox.BackColor = Color.FromArgb(80, 80, 80);
            valueTxtBox.BorderStyle = BorderStyle.FixedSingle;
            valueTxtBox.ForeColor = Color.White;
            valueTxtBox.Location = new Point(290, 10);
            valueTxtBox.Margin = new Padding(0);
            valueTxtBox.Name = "valueTxtBox";
            valueTxtBox.Size = new Size(300, 27);
            valueTxtBox.TabIndex = 1;
            // 
            // DwTextUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(valueTxtBox);
            Controls.Add(nameLbl);
            Margin = new Padding(0, 0, 0, 2);
            Name = "DwTextUserControl";
            Padding = new Padding(10);
            Size = new Size(600, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private TextBox valueTxtBox;
    }
}
