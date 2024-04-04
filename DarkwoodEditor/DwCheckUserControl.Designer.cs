namespace DarkwoodEditor
{
    partial class DwCheckUserControl
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
            valueChkBox = new CheckBox();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(10, 11);
            nameLbl.Margin = new Padding(0, 1, 0, 1);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(52, 18);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // valueChkBox
            // 
            valueChkBox.AutoSize = true;
            valueChkBox.ForeColor = Color.White;
            valueChkBox.Location = new Point(566, 21);
            valueChkBox.Margin = new Padding(6);
            valueChkBox.Name = "valueChkBox";
            valueChkBox.Size = new Size(18, 17);
            valueChkBox.TabIndex = 1;
            valueChkBox.UseVisualStyleBackColor = true;
            valueChkBox.CheckedChanged += valueChkBox_CheckedChanged;
            // 
            // DwCheckUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(valueChkBox);
            Controls.Add(nameLbl);
            Margin = new Padding(0, 0, 0, 2);
            Name = "DwCheckUserControl";
            Padding = new Padding(10);
            Size = new Size(600, 54);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLbl;
        private CheckBox valueChkBox;
    }
}
