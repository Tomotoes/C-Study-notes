using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 选中字符操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Select(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            for (int i = textBox1.SelectedText.Length-1; i >= 0; textBox4.Text += textBox1.SelectedText[i--]) ;
            textBox4.SelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "现在时刻:"+System.DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            timer1.Start();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出吗?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
