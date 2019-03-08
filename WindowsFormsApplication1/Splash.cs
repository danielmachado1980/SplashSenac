using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Splash : Form
    {
        private int loading = 0;
        private bool toRight = true;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Splash()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading++;
            if (toRight)
                panel2.Left += 2;
            else
                panel2.Left -= 2;
            if (panel2.Left < 0 || panel2.Left > 196)
                toRight = !toRight;

            this.Opacity -= .005;
            if (this.Opacity == 0) { 
                timer1.Enabled = false;
                Principal main = new Principal();
                main.Show();
                this.Hide();
            }

            //if (loading > 800)
            //{
            //    timer1.Enabled = false;
            //    Principal main = new Principal();
            //    main.Show();
            //    this.Hide();
            //}
        }
    }
}
