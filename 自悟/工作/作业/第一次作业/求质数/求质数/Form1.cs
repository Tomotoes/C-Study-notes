using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 求质数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool Cmp(int N)
        {
            int M = Convert.ToInt32(System.Math.Sqrt(N));
            for (int i = 3; i <= M; ++i)
            {
                if (N % i == 0)
                    return false;
            }
            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                if (N >= 2)
                {
                    textBox2.Text = "2";
                    for (int i = 3; i <= N; ++i)
                    {
                        if (Cmp(i) == true)
                        {
                            textBox2.Text += " ";
                            textBox2.Text += i.ToString();
                        }
                    }
                }
                else { textBox2.Text += "您的数据中无质数！"; }
            }
            catch { textBox2.Text = "您输入的数据类型有误！"; }
            
        }
    }
}
