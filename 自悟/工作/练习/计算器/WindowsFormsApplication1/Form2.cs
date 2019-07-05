using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rb2.Checked = true;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if(rb2.Checked==true)
            {
                textBox1.Text = "女";
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if(rb1.Checked==true)
            {
                textBox1.Text = "男";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textBox1.Text = checkBox1.Text;
            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
