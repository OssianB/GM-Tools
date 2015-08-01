using System;
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
            this.ParentForm.Controls.Add(opt);
            opt.CloseOptions += Opt_CloseOptions;
        }

        private void Opt_CloseOptions(object sender, EventArgs e)
        {
            this.ParentForm.Controls.Remove(opt);
        }
        #endregion

    }
}
