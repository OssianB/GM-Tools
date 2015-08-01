using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controls.Tools.Options
{
    public partial class Options : UserControl 
    {
        public event EventHandler CloseOptions;

        public Options()
        {
            InitializeComponent();
        }

        public void  SelectedTab(int tab)
        {
            this.OptionsTabControl.SelectTab(tab);
        }

        private void lblBtnX_click(object sender, EventArgs e)
        {
            Font mfont = new Font("Areial", 8, FontStyle.Regular);
            lblbtnX.Font = mfont;
            EventHandler handler = CloseOptions;
            handler(this, e);
        }
    }
}
