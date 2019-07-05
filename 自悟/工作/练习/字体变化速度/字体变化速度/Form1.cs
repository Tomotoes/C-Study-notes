using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 字体变化速度
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int X = 10;
        Random Rc = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(Rc.Next(255), Rc.Next(255), Rc.Next(255));
            if (label1.Left + label1.Width > this.Width||label1.Left<0)
            {
                X = -X;
            }
            label3.Text = System.Math.Abs(X) .ToString();
            label1.Left += X;
            
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
            if (X > 0) X = hScrollBar1.Value+10;
            else X = -hScrollBar1.Value-10;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { label3.Text = "10"; }
            try
            {
                label5.Text = "最高速度：250";
                int T = Convert.ToInt32(textBox1.Text);
                if (System.Math.Abs(T) <= 250)
                {

                    X = Convert.ToInt32(textBox1.Text);
                }
                else
                {
                    label5.Text = "您已经超速了！";
                }
            }
            catch { X = 10; }

        }
    }
}
