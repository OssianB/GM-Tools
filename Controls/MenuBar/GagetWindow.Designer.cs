namespace Controls.MenuBar
{
    partial class GagetWindow
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
            this.gbxGagetWindowBorder = new System.Windows.Forms.GroupBox();
            this.lblBtnUpDown = new System.Windows.Forms.Label();
            this.lblbtnX = new System.Windows.Forms.Label();
            this.gbxGagetWindowBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxGagetWindowBorder
            // 
            this.gbxGagetWindowBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGagetWindowBorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxGagetWindowBorder.Controls.Add(this.lblBtnUpDown);
            this.gbxGagetWindowBorder.Controls.Add(this.lblbtnX);
            this.gbxGagetWindowBorder.Location = new System.Drawing.Point(8, 8);
            this.gbxGagetWindowBorder.Name = "gbxGagetWindowBorder";
            this.gbxGagetWindowBorder.Size = new System.Drawing.Size(815, 564);
            this.gbxGagetWindowBorder.TabIndex = 0;
            this.gbxGagetWindowBorder.TabStop = false;
            // 
            // lblBtnUpDown
            // 
            this.lblBtnUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtnUpDown.Location = new System.Drawing.Point(782, 0);
            this.lblBtnUpDown.Name = "lblBtnUpDown";
            this.lblBtnUpDown.Size = new System.Drawing.Size(15, 15);
            this.lblBtnUpDown.TabIndex = 5;
            this.lblBtnUpDown.Text = "↑";
            this.lblBtnUpDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBtnUpDown.Click += new System.EventHandler(this.lblBtnUpDown_Click);
            // 
            // lblbtnX
            // 
            this.lblbtnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbtnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnX.Location = new System.Drawing.Point(797, 0);
            this.lblbtnX.Name = "lblbtnX";
            this.lblbtnX.Size = new System.Drawing.Size(15, 15);
            this.lblbtnX.TabIndex = 4;
            this.lblbtnX.Text = "X";
            this.lblbtnX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbtnX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblbtnX_MouseDown);
            this.lblbtnX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblbtnX_MouseUp);
            // 
            // GagetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(831, 578);
            this.Controls.Add(this.gbxGagetWindowBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1080, 1920);
            this.Name = "GagetWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GagetWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GagetWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GagetWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GagetWindow_MouseUp);
            this.gbxGagetWindowBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGagetWindowBorder;
        public System.Windows.Forms.Label lblBtnUpDown;
        public System.Windows.Forms.Label lblbtnX;
    }
}