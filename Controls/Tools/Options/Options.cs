using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Collections;
using System.Threading;

namespace Controls.Tools.Options
{
    public partial class Options : UserControl 
    {

        

        public event EventHandler CloseOptions;
        public event EventHandler OnCloseOptions;
        public event EventHandler UpWindow;
        public event EventHandler DownWindow;

        private System.Timers.Timer myTimer;
        int timeElapsed = 0;

        List<Tuple<string, string>> Tlist = new List<Tuple<string, string>>();
        ArrayList Tarray = new ArrayList();
        private Thread demothred;

        public Options()
        {
            InitializeComponent();
            lblTime.Text = "0";

            myTimer = new System.Timers.Timer(1);
            myTimer.Elapsed += MyTimer_Elapsed;
         
        }

        private void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timeElapsed += 1;

            try
            { 
            this.demothred = new Thread(new ThreadStart(this.ThreadProcSafe));
            this.demothred.Start();
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void ThreadProcSafe()
        {
            this.SetTime(timeElapsed.ToString());
        }

        private void SetTime(string txt)
        {
            if (this.txtTimer.InvokeRequired)
            {
                SetTimeCallback d = new SetTimeCallback(SetTime);
                this.Invoke(d, new object[] { txt });
            }
            else
            {
                this.txtTimer.Text = txt;
            }
        }

        delegate void SetTimeCallback(string txt);

        public void  SelectedTab(int tab)
        {
            this.OptionsTabControl.SelectTab(tab);
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            timeElapsed = 0;
            addLists((int)nmrUD.Value * 1000);
            addArraylists((int)nmrUD.Value * 1000);

            findinLists();

        }

        void addLists(int nums)
        {
            timeElapsed = 0;
            myTimer.Start();
            for (int i = 0; i <= nums; i++)
            {
                Tlist.Add(Tuple.Create<string,string>( i.ToString(), (i * 7).ToString() ));
            }
            myTimer.Stop();
            txtTestResult.Text += "Filling the list : " + timeElapsed.ToString() + " ms" + Environment.NewLine;
        }

     
        void addArraylists(int nums)
        {
            myTimer.Start();
            for (int i = 0; i <= nums; i++)
            {
                Tarray.Add(Tuple.Create<string, string>(i.ToString(), (i * 7).ToString()));
            }
            myTimer.Stop();
            txtTestResult.Text += "Filling the Arraylist : " + timeElapsed.ToString() + " ms" + Environment.NewLine;
        }

        void findinLists()
        {
            timeElapsed = 0;
            myTimer.Start();
            if (Tlist.Where(t => t.Item1.Contains("68")).Count() > 0 )
            {
                if (Tlist.Where(t => t.Item2.Contains("616")).Count() < 0)
                {
                    myTimer.Stop();
                    txtTestResult.Text += "List Loop Compleat in : " + timeElapsed.ToString() + " ms";
                }
            }
            myTimer.Stop();
            txtTestResult.Text += "List Loop compleat in : " + timeElapsed.ToString() + " ms" ;
            timeElapsed = 0;

            
            
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
