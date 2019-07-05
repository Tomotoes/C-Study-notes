using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class 事项说明 : Form
    {
        public 事项说明()
        {
            InitializeComponent();
        }

        private void 事项说明_Load(object sender, EventArgs e)
        {
            Index = 0;
            timer1.Start();
        }
        static string TheFunction = "The notebook is so cool!Do you think so ?The creator is MJThe creator's blog :The notebook has plenty of functions!It's your turn now.";
        static int Index = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text += TheFunction[Index++];
            if(TheFunction[Index-1]== '?'|| TheFunction[Index - 1] == 'J'||TheFunction[Index-1]=='!')
            {
                label1.Text += "\r\n\n";
            }
            if(TheFunction[Index - 1] == 'J')
            {
                this.Text = "MJ's World!";
            }
           
            if(TheFunction[Index - 1] == ':')
            {
                
                label1.Text += "  \r\n\n";
                linkLabel1.Visible = true;
            }
            if (TheFunction[Index - 1] == '.')
            {
                timer1.Stop();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.VisitedLinkColor = Color.Green;
            System.Diagnostics.Process.Start("http://blog.csdn.net/acceptee"); //在浏览器中打开链接
        }
    }
}
