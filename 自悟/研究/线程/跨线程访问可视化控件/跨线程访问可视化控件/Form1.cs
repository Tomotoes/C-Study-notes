using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 跨线程访问可视化控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread = new Thread(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    a += i;
                    if (this.label2.InvokeRequired)
                    {
                        //Invoke()方法第一个参数是返回值为void的委托，第二个是给委托对象方法传递的参数，就相当于回调方法的参数
                        this.label2.Invoke(new Action<string>(s => this.label2.Text = s), a.ToString());
                    }
                    Thread.Sleep(200);
                }
            });
            objThread.IsBackground = true;
            objThread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0;
            Thread objThread = new Thread(() =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    a += i;
                    if (this.label4.InvokeRequired)
                    {
                        //Invoke()方法第一个参数是返回值为void的委托，第二个是给委托对象方法传递的参数，就相当于回调方法的参数
                        this.label4.Invoke(new Action<string>(s => this.label4.Text = s), a.ToString());
                    }
                    Thread.Sleep(200);
                }
            });
            objThread.IsBackground = true;
            objThread.Start();
        }
    }
}
