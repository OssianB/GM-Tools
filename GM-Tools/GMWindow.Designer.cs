namespace GM_Tools
{
    partial class GMWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar1 = new Controls.MenuBar.menuBar();
            this.menuBar = new Controls.MenuBar.menuBar();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBar1.Location = new System.Drawing.Point(-1, -1);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(1120, 24);
            this.menuBar1.TabIndex = 2;
            // 
            // menuBar
            // 
            this.menuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBar.Location = new System.Drawing.Point(2, 1);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1114, 24);
            this.menuBar.TabIndex = 1;
            // 
            // GMWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1118, 623);
            this.Controls.Add(this.menuBar);
            this.IsMdiContainer = true;
            this.Name = "GMWindow";
            this.Text = "GB Tools";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MenuBar.menuBar menuBar1;
        private Controls.MenuBar.menuBar menuBar;
    }
}

