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

        public event EventHandler CloseGW;
        public event EventHandler OnCloseGW;
        public event EventHandler UpGW;
        public event EventHandler DownGW;
        public event EventHandler MoveGW;

        Tools.Options.Options opt = new Tools.Options.Options();

        private Boolean MoveMode = false;

        public GagetWindow()
        {
            InitializeComponent();
        }

        private UserControl UControl;

        public GagetWindow(UserControl UC, int val)
            : this()
        {
            UControl = UC;

            UControl.Location = new Point(8, 8);
            gbxGagetWindowBorder.Controls.Add(UControl);
            gbxGagetWindowBorder.Size = new Size(UControl.Width, UControl.Height);

            
            //UControl.SetBounds(0, 0, UControl.Width, UControl.Height);
            //UControl.Dock = DockStyle.Fill;
            
        }

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

        public void ButtonOptions(Font f,Control control)
        {
            control.Font = f;
        }

        protected void Opt_CloseOptions(object sender, EventArgs e)
        {
            Controls.Remove(UControl);
            this.Close();
        }

        private void lblBtnM_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void lblBtnUpDown_Click(object sender, EventArgs e)
        {
            UpGW(this, e);
        }

        protected virtual void lblbtnX_MouseDown(object sender, MouseEventArgs e)
        {
            OnCloseGW(this, e); 
        }

        private void lblbtnX_MouseUp(object sender, MouseEventArgs e)
        {
            CloseGW(this, e);
        }

        private void GagetWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            downPoint = new Point(e.X, e.Y);
        }

        private void GagetWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X, 
                this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        private void GagetWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        public Point downPoint = Point.Empty;
    }
}
