using System;
using System.Windows.Forms;

namespace Controls.MenuBar
{
    public partial class menuBar : UserControl
    {
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
            Tools.Options.Options opt = new Tools.Options.Options();
            opt.SelectedTab(1);
            opt.SetBounds(50, 50, opt.Size.Width, opt.Size.Height);
            this.ParentForm.Controls.Add(opt);
        }
#endregion

    }
}
