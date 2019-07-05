using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 车牌号
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool F = false;
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 1; j <= 9; ++j)
                {
                    int T = i * 1000 + i * 100 + j * 10 + j;
                    int M = Convert.ToInt32(System.Math.Sqrt(T));
                    if (T == M * M)
                    {
                        textBox1.Text = T.ToString();
                        F = true; break;
                    }
                }
                if (F == true) { break; }
            }
        }
    }
}
