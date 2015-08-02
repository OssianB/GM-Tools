namespace Controls.Tools.Options
{
    partial class Options
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
            this.components = new System.ComponentModel.Container();
            this.OptionsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblbtnX = new System.Windows.Forms.Label();
            this.gbxBorder = new System.Windows.Forms.GroupBox();
            this.lblBtnM = new System.Windows.Forms.Label();
            this.lblBtnUpDown = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OptionsTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbxBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsTabControl
            // 
            this.OptionsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsTabControl.Controls.Add(this.tabPage1);
            this.OptionsTabControl.Controls.Add(this.tabPage2);
            this.OptionsTabControl.Controls.Add(this.tabPage3);
            this.OptionsTabControl.Controls.Add(this.tabPage4);
            this.OptionsTabControl.Controls.Add(this.tabPage5);
            this.OptionsTabControl.Location = new System.Drawing.Point(10, 20);
            this.OptionsTabControl.Name = "OptionsTabControl";
            this.OptionsTabControl.SelectedIndex = 0;
            this.OptionsTabControl.Size = new System.Drawing.Size(655, 424);
            this.OptionsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTime);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(647, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Combat System";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(647, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Shops";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(647, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Players";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblbtnX
            // 
            this.lblbtnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbtnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbtnX.Location = new System.Drawing.Point(650, 1);
            this.lblbtnX.Name = "lblbtnX";
            this.lblbtnX.Size = new System.Drawing.Size(15, 15);
            this.lblbtnX.TabIndex = 1;
            this.lblbtnX.Text = "X";
            this.lblbtnX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbtnX.Click += new System.EventHandler(this.lblBtnX_click);
            this.lblbtnX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBtn_MouseDown);
            this.lblbtnX.MouseLeave += new System.EventHandler(this.lblBtn_MouseLeave);
            this.lblbtnX.MouseHover += new System.EventHandler(this.lblBtn_MouseHover);
            this.lblbtnX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBtn_MouseUp);
            // 
            // gbxBorder
            // 
            this.gbxBorder.Controls.Add(this.lblBtnM);
            this.gbxBorder.Controls.Add(this.lblBtnUpDown);
            this.gbxBorder.Controls.Add(this.lblbtnX);
            this.gbxBorder.Location = new System.Drawing.Point(4, 3);
            this.gbxBorder.Name = "gbxBorder";
            this.gbxBorder.Size = new System.Drawing.Size(667, 447);
            this.gbxBorder.TabIndex = 2;
            this.gbxBorder.TabStop = false;
            // 
            // lblBtnM
            // 
            this.lblBtnM.Location = new System.Drawing.Point(620, 1);
            this.lblBtnM.Name = "lblBtnM";
            this.lblBtnM.Size = new System.Drawing.Size(15, 15);
            this.lblBtnM.TabIndex = 3;
            this.lblBtnM.Text = "M";
            this.lblBtnM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBtnM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblBtnM_MouseDown);
            this.lblBtnM.MouseLeave += new System.EventHandler(this.lblBtn_MouseLeave);
            this.lblBtnM.MouseHover += new System.EventHandler(this.lblBtn_MouseHover);
            this.lblBtnM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblBtnM_MouseUp);
            // 
            // lblBtnUpDown
            // 
            this.lblBtnUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBtnUpDown.Location = new System.Drawing.Point(635, 1);
            this.lblBtnUpDown.Name = "lblBtnUpDown";
            this.lblBtnUpDown.Size = new System.Drawing.Size(15, 15);
            this.lblBtnUpDown.TabIndex = 2;
            this.lblBtnUpDown.Text = "↑";
            this.lblBtnUpDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBtnUpDown.Click += new System.EventHandler(this.lblBtnUp_Click);
            this.lblBtnUpDown.MouseLeave += new System.EventHandler(this.lblBtn_MouseLeave);
            this.lblBtnUpDown.MouseHover += new System.EventHandler(this.lblBtn_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(210, 142);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "lblTime";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OptionsTabControl);
            this.Controls.Add(this.gbxBorder);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(672, 451);
            this.OptionsTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbxBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OptionsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblbtnX;
        private System.Windows.Forms.GroupBox gbxBorder;
        private System.Windows.Forms.Label lblBtnUpDown;
        private System.Windows.Forms.Label lblBtnM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}
