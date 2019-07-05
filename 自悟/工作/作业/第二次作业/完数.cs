using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 完数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            int S = 0;
            for (int i = 1; i <=N/2; ++i)
            {
                if (N % i == 0)
                {
                    S += i;
                }
            }
            if (S == N) { textBox2.Text = "是完数！"; }
            else { textBox2.Text = "不是完数！"; }
        }
    }
}
