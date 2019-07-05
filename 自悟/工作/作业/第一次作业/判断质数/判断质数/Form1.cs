using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 判断质数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                if (N == 1)
                {
                    textBox2.Text = "不是质数";
                }
                else if (N == 2)
                {
                    textBox2.Text = "是质数";
                }
                bool F = false;
                int M = Convert.ToInt32(System.Math.Sqrt(N));
                for (int i = 3; i <= M; ++i)
                {
                    if (N % i == 0)
                    {
                        textBox2.Text = "不是质数";
                        F = true;
                        break;
                    }

                }
                if (F == false)
                {
                    textBox2.Text = "是质数";

                }
            }
            catch { textBox2.Text = "您输入的数据类型有误！"; }
        }
    }
}
