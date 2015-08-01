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
        public event EventHandler OnCloseOptions;
        public event EventHandler UpWindow;
        public event EventHandler DownWindow;

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
           // CloseOptions(this, e);
        }

        public void lblBtnX_Font(Font f)
        {
            lblbtnX.Font = f;
        }

        private void lblBtn_MouseDown(object sender, MouseEventArgs e)
        {
            OnCloseOptions(this, e);
        }

        private void lblBtn_MouseUp(object sender, MouseEventArgs e)
        {
            CloseOptions(this, e);
        }

        private void lblBtn_MouseHover(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGray;
        }

        private void lblBtn_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.Transparent;
        }

        private void lblBtnUp_Click(object sender, EventArgs e)
        {
            if (lblBtnUpDown.Text == "↑")
            {
                lblBtnUpDown.Text = "↓";
                UpWindow(this, e);
            }
            else
            {
                lblBtnUpDown.Text = "↑";
                DownWindow(this, e);
            }

            
        }

    }
}
