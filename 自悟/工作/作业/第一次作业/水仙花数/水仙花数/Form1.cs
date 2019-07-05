using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 水仙花数
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                if (N < 100 || N >= 1000)
                {
                    textBox2.Text = "您输入的数据超出范围！";
                }
                else
                {
                    int a, b, c, R = 0;
                    int[] A = new int[20];
                    for (int i = 100; i <= N; ++i)
                    {
                        a = (i % 100) / 10;
                        b = i / 100;
                        c = i % 10;
                        if (a * a * a + b * b * b + c * c * c == i)
                        {
                            A[R++] = i;
                        }
                    }
                    if (R == 0)
                    {
                        textBox2.Text = "您输入的数据中不存在水仙花数！";
                    }
                    else
                    {
                        for (int i = 0; i < R; ++i)
                        {
                            textBox2.Text += A[i].ToString();
                            textBox2.Text += " ";
                        }
                    }
                    
                }
            }
            catch { textBox2.Text = "您输入的数据类型有误！"; }
            
        }
    }
}
