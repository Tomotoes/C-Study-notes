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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 A = new Form1();
            Ac = A.ShowString;
            A.Show();
        }
        public delegate void JudgeMydelegate(string Count);
        public JudgeMydelegate Ac;
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int Count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Ac((++Count).ToString());
        }
    }
}
