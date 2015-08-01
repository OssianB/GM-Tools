using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.MenuBar
{
    public partial class GagetWindow : Form
    {

        Tools.Options.Options opt = new Tools.Options.Options();

        public GagetWindow()
        {
            InitializeComponent();
        }

        private UserControl UControl;

        public GagetWindow(UserControl UC)
            : this()
        {
            UControl = UC;

            if (UC.Name == opt.Name)
            {
                opt = (Tools.Options.Options)UC;
                opt.CloseOptions += Opt_CloseOptions;
            }

            this.Controls.Add(UControl);
            UControl.SetBounds(0, 0, UControl.Size.Width, UControl.Size.Height);
        }


        protected void Opt_CloseOptions(object sender, EventArgs e)
        {
            Controls.Remove(UControl);
            this.Close();
        }
    }
}
