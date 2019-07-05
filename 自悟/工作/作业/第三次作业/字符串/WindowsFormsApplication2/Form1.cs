using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = textBox1.Text;
            textBox2.Text = A.ToUpper();
            int Z=0, S=0, Q=0;
            textBox3.Clear();
            for (int i = A.Length - 1; i >= 0; --i){
                textBox3.Text += A[i];
                if (A[i] >= 'A' && A[i] <= 'Z' || A[i]>='a' && A[i]<='z'){Z++;}
                else if (A[i] >= '0' && A[i] <= '9'){S++;}
                else{Q++;}                                                            
            }
            textBox4.Text = A.Length >= 3 ? A.Insert(3, "ABC") : "字符串的长度有限";
            textBox5.Text = Z.ToString();textBox6.Text = S.ToString();
            textBox7.Text = Q.ToString(); textBox8.Text = A==textBox3.Text ? "Yes" : "No";
            textBox9.Text=A.IndexOf("abc")==-1?"未找到":Convert.ToString(A.IndexOf("abc"));
        }
    }
}
