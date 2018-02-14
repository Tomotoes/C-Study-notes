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

        private void tabControl1_Click(object sender, EventArgs e)
        {
            string msg ="";
            foreach (Control c in tabPage1.Controls)//每一个相当于一个控件
            {
                if(c.GetType().Name.Equals("CheckBox"))
                {
                    if (((CheckBox)c).Checked)
                        msg += ((CheckBox)c).Text + " ";
                }
            }
            if (msg=="")
                msg = "NO Box is Checked in page1";
            else
                msg += " are checked in page1.  ";
            textBox1.Text = msg;
            msg = "";
            foreach (Control c in tabPage2.Controls)
            {
                if (c.GetType().Name.Equals("RadioButton"))
                {
                    if (((RadioButton)c).Checked)
                    {
                        msg += ((RadioButton)c).Text;
                        break;
                    }
                }
            }
            if (msg == "")
                msg = "no radiobutton is checked in page2.";
            else
                msg += " is checked in page2.";
            textBox1.Text+=msg;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}