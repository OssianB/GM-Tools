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
           
            lblTime.Text = "0";
        }

        public void  SelectedTab(int tab)
        {
            this.OptionsTabControl.SelectTab(tab);
        }

        //private void lblBtnX_click(object sender, EventArgs e)
        //{
        //   //CloseOptions(this, e);
        //}

    //    public void lblBtnX_Font(Font f)
    //    {
    //        lblbtnX.Font = f;
    //    }

    //    public void SetlblBtnUpDown(string upDown)
    //    {
    //        lblBtnUpDown.Text = upDown;
    //    }

    //    private void lblBtn_MouseDown(object sender, MouseEventArgs e)
    //    {
    //        OnCloseOptions(this, e);
    //    }

    //    private void lblBtn_MouseUp(object sender, MouseEventArgs e)
    //    {
    //        CloseOptions(this, e);
    //    }

    //    private void lblBtn_MouseHover(object sender, EventArgs e)
    //    {
    //        Label lb = (Label)sender;
    //        lb.BackColor = Color.LightGray;
    //    }

    //    private void lblBtn_MouseLeave(object sender, EventArgs e)
    //    {
    //        Label lb = (Label)sender;
    //        lb.BackColor = Color.Transparent;
    //    }

    //    private void lblBtnUp_Click(object sender, EventArgs e)
    //    {
    //        if (lblBtnUpDown.Text == "↑")
    //        {
    //            lblBtnUpDown.Text = "↓";
    //            UpWindow(this, e);
    //        }
    //        else
    //        {
    //            lblBtnUpDown.Text = "↑";
    //            DownWindow(this, e);
    //        }


    //    }

    //    private int timer = 0;

    //    private void lblBtnM_MouseDown(object sender, MouseEventArgs e)
    //    {
    //        timer1.Start();
    //        timer1.Interval = 1;
    //    }

    //    private void lblBtnM_MouseUp(object sender, MouseEventArgs e)
    //    {
    //        timer1.Stop();
    //    }

    //    private void timer1_Tick(object sender, EventArgs e)
    //    {
    //        timer += 1;
    //        lblTime.Text = timer.ToString();
    //    }
    }
}
