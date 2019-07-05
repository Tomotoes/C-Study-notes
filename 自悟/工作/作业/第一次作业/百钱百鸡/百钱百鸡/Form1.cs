using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 百钱百鸡
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                int N = Convert.ToInt32(textBox1.Text);
                int P = 1;
                for (int i = 0; i < N / 5; ++i)
                {
                    for (int j = 0; j < N / 3; ++j)
                    {
                        for (int k = 0; k < N; k += 3)
                        {
                            if (i + j + k == N && 5 * i + 3 * j + k / 3 == N)
                            {
                                textBox2.Text += "方案";
                                textBox2.Text += P.ToString();
                                textBox2.Text += ": ";
                                textBox2.Text += Environment.NewLine;
                                textBox2.Text += "公鸡：";
                                textBox2.Text += i.ToString();
                                textBox2.Text += " ";
                                textBox2.Text += "母鸡：";
                                textBox2.Text += j.ToString();
                                textBox2.Text += " ";
                                textBox2.Text += "小鸡：";
                                textBox2.Text += k.ToString();
                                textBox2.Text += Environment.NewLine;
                                P++;
                            }
                        }
                    }
                }
            }
            catch { textBox2.Text = "您输入的数据类型有误！"; }
          
        }
    }
}
