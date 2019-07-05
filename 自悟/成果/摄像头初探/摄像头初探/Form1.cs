using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 摄像头初探
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pick pick;
        private void button1_Click(object sender, EventArgs e)
        {
            pick = new Pick(this.pictureBox1.Handle, 0, 0, this.pictureBox1.Width, this.pictureBox1.Height);
            pick.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pick.Stop();
            this.pictureBox1 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pick.GrabImage(@"d:\aa.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pick.Kinescope(@"d:bb.mp4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pick.SetShow();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pick.StopKinescope();
        }
    }
}
