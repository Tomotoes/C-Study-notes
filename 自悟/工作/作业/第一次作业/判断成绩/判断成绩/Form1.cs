using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 判断成绩
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double N = Convert.ToDouble(textBox1.Text);
                if (N > 100 || N < 0) { textBox2.Text = "您输入的成绩有误！"; }
                else
                {
                    int M = Convert.ToInt32(N);
                    switch (M / 10)
                    {
                        case 10: textBox2.Text = "- A -"; break;
                        case 9: textBox2.Text = "- A -"; break;
                        case 8: textBox2.Text = "- B -"; break;
                        case 7: textBox2.Text = "- C -"; break;
                        case 6: textBox2.Text = "- D -"; break;
                        default: textBox2.Text = "- E -"; break;
                    }
                }
            }
            catch { textBox2.Text = "您的输入数据有误！"; }
        }
    }
}
