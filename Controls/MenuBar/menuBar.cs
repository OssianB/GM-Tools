using System;
using System.Drawing;
using System.Windows.Forms;

namespace Controls.MenuBar
{
    public partial class menuBar : UserControl
    {
        Tools.Options.Options opt = new Tools.Options.Options();
        GagetWindow gwForm = new GagetWindow();

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

            //opt.SelectedTab(1);
            //opt.SetBounds(0, 0, opt.Width, opt.Height);

            gwForm = new GagetWindow(opt, 1);
            gwForm.OnCloseGW += GwForm_OnCloseGW;
            gwForm.CloseGW += GwForm_CloseGW;

            gwForm.Show();

            //GagetWindow GW = new GagetWindow(opt,1);
            //GW.OnCloseGW += GW_OnCloseGW;
            //GW.CloseGW += GW_CloseGW;


            //GW.Show();

            //opt.SelectedTab(1);
            //opt.SetBounds(50, 50, opt.Size.Width, opt.Size.Height);
            ////Font ff = new Font("Arial", 8, FontStyle.Bold);
            ////opt.lblBtnX_Font(ff);
            //this.ParentForm.Controls.Add(opt);
            ////opt.SetlblBtnUpDown("↑"); //alt + 24
            //opt.CloseOptions += Opt_CloseOptions;
            //opt.OnCloseOptions += Opt_OnCloseOptions;
            //opt.UpWindow += Opt_UpWindow;
            //opt.DownWindow += Opt_DownWindow;
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

            GW.OnCloseGW += GwForm_OnCloseGW;
            GW.CloseGW += GwForm_CloseGW;
            
            GW.Show();
        }

        protected virtual void Opt_OnCloseOptions(object sender, EventArgs e)
        {
            //Font ff = new Font("Arial", 8, FontStyle.Regular);
            //opt.lblBtnX_Font(ff);
        }

        protected virtual void Opt_CloseOptions(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Remove(opt);
        }
        #endregion

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            gwForm = new GagetWindow();
            gwForm.MdiParent = this.ParentForm;
            gwForm.OnCloseGW += GwForm_OnCloseGW;
            gwForm.CloseGW += GwForm_CloseGW;

            gwForm.Show();
        }

        protected virtual void GwForm_CloseGW(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Remove(opt);
            gwForm.Hide();
        }

        protected virtual void GwForm_OnCloseGW(object sender, EventArgs e)
        {
            Font ff = new Font("Arial", 8, FontStyle.Regular);
            gwForm.ButtonOptions(ff,gwForm.lblbtnX);
        }
    }
}
