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
    public partial class 关于 : Form
    {
        public 关于()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.VisitedLinkColor = Color.Green;
            System.Diagnostics.Process.Start("http://blog.csdn.net/acceptee"); //在浏览器中打开链接
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.VisitedLinkColor = Color.Green;
            System.Diagnostics.Process.Start("http://blog.csdn.net/acceptee"); //在浏览器中打开链接
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.VisitedLinkColor = Color.Green;
            System.Diagnostics.Process.Start("http://blog.csdn.net/acceptee"); //在浏览器中打开链接
        }
    }
}
