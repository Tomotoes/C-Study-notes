using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 兔子生子
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Data = Convert.ToInt32(textBox1.Text);
            int [] A= new int [200];
            A[0] = 1; A[1] = 1; A[2] = 2;
            int M = Data / 3;
            for (int i = 3; i <= M; ++i)
            {
                A[i] = A[i - 1] + A[i - 2];
            }
            textBox2.Text = A[M].ToString();
        }
    }
}
