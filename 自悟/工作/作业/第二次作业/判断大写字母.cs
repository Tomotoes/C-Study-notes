using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 判断大写字母
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = textBox1.Text;
            int len = 0,i;
            for (i = 0; i < A.Length; ++i)
            {
                if (A[i] >= 'A' && A[i] <= 'Z')
                {
                    len++;
                }
            }
            if (len == i)
            {
                textBox2.Text = "全是大写!";
            }
            else
            {
                textBox2.Text="不全是大写!";
            }
        }
    }
}
