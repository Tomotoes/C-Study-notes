using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.MultiColumn = radioButton1.Checked == true ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.FindString(textBox1.Text);
            /*
             * 因为 SelectedIndex 是一个属性 扳手形状 而 FindString 方法又返回一个 索引值，所以两者结合 查找并选中。
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
