using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace ProgressBar
{    public partial class Form1 : Form
    {        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            //progressBar1.Value++;
            progressBar1.PerformStep();//此方法 用于处理进度条的进度 核心方法
            if (progressBar1.Value == progressBar1.Maximum)
            {               
                button2_Click(sender, e);//可以通过像函数一样 去调用事件  当然 必须参数匹配
                MessageBox.Show(i*0.1 + "secondes");
                progressBar1.Value = 0;
               // i = 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
    }
}