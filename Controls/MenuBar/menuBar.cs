using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controls.MenuBar
{
    public partial class menuBar : UserControl
    {
        Tools.Options.Options opt = new Tools.Options.Options();

        public menuBar()
        {
            InitializeComponent();
        }

#region MenuItems

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMTabout abt = new GMTabout();
            abt.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opt.SelectedTab(1);
            opt.SetBounds(50, 50, opt.Size.Width, opt.Size.Height);
            Font ff = new Font("Arial", 8, FontStyle.Bold);
            opt.lblBtnX_Font(ff);
            this.ParentForm.Controls.Add(opt);
            opt.SetlblBtnUpDown("↑");
            opt.CloseOptions += Opt_CloseOptions;
            opt.OnCloseOptions += Opt_OnCloseOptions;
            opt.UpWindow += Opt_UpWindow;
            opt.DownWindow += Opt_DownWindow;
        }

        private void Opt_DownWindow(object sender, EventArgs e)
        {
            opt.SetBounds(50, 50, opt.Size.Width, opt.Size.Height);
            ParentForm.Controls.Add(opt);

        }

        private void Opt_UpWindow(object sender, EventArgs e)
        {
            //ParentForm.Controls.Remove(opt);
            GagetWindow GW = new GagetWindow(opt);
            
            GW.Show();
        }

        protected virtual void Opt_OnCloseOptions(object sender, EventArgs e)
        {
            Font ff = new Font("Arial", 8, FontStyle.Regular);
            opt.lblBtnX_Font(ff);
        }

        protected virtual void Opt_CloseOptions(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Remove(opt);
        }
        #endregion

    }
}
