using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体之间的通信
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ShowString(string Count)
        {
            this.label2.Text = Count;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
