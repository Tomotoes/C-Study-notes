using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求奇数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = "";
                int N = Convert.ToInt32(textBox3.Text);
                int[] A = new int[2000];
                int R = 0;
                for (int i = 1; i <= N; ++i)
                {
                    if (i % 2 != 0)
                    {
                        A[R++] = i;
                    }
                }
                for (int i = 0; i < R; ++i)
                {
                    textBox4.Text += A[i].ToString();
                    textBox4.Text += " ";
                }
            }
            catch { textBox4.Text = "您输入的数据类型有误！"; }
        }
    }
}
