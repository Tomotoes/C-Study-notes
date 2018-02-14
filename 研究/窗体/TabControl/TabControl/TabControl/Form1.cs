using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s1="", s2="";
        private void tabControl1_Click(object sender, EventArgs e)
        {
            s1 = "";
            foreach (Control c in tabPage1.Controls)//每一个相当于一个控件
            {
                if(c.GetType().Name.Equals("CheckBox"))
                {
                    if (((CheckBox)c).Checked)
                       s1 += ((CheckBox)c).Text + " ";
                }
            }
            if (s1 == "")
                s1 = "NO Box is Checked in page1";
            else
                s1 += " are checked in page1.  ";
           
            s2 = "";
            foreach (Control c in tabPage2.Controls)
            {
                if (c.GetType().Name.Equals("RadioButton"))
                {
                    if (((RadioButton)c).Checked)
                    {
                        s2 += ((RadioButton)c).Text;
                        break;
                    }
                }
            }
            if (s2 == "")
               s2 = "no radiobutton is checked in page2.";
            else
                s2 += " is checked in page2.";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = s1 + s2;
          
        }

       

       
    }
}