using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class 转到 : Form
    {
        public 转到()
        {
            InitializeComponent();
        }
        public 记事本 B;
        int X, Y;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool Start = true;
            try
            {
                if (textBox1.Text == "") X = 0;
                else X = Convert.ToInt32(textBox1.Text);
            }
            catch { MessageBox.Show("您输入行值无效！");Start = false; }
            try
            {
                if (textBox2.Text == "") Y = 0;
                else Y = Convert.ToInt32(textBox2.Text);
            }
            catch { MessageBox.Show("您输入列值无效！");Start = false; }
            if (Start)
            {
                int CountHang = 1;
                int CountWord = Y;
                for(int i = 0; i < B.Main.TextLength; ++i)
                {
                    CountWord++;
                    if (CountHang == X) { break; }
                    if (B.Main.Text[i] == '\n')
                    {
                        CountHang++;
                    }
                }
                B.Main.Select(CountWord-2, 1);
            }
        }
    }
}
