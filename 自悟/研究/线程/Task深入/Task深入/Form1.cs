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

namespace Task深入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Task> listask = new List<Task>();

            TaskFactory taskFactory = new TaskFactory();

            Action at1 = new Action(() => Coding("A"));
            Action at2 = new Action(() => Coding("B"));
            Action at3 = new Action(() => Coding("C"));
            Action at4 = new Action(() => Coding("D"));
            Action at5 = new Action(() => Coding("E"));

            listask.Add(taskFactory.StartNew(at1));
            listask.Add(taskFactory.StartNew(at2));
            listask.Add(taskFactory.StartNew(at3));
            listask.Add(taskFactory.StartNew(at4));
            listask.Add(taskFactory.StartNew(at5));

            Action<Task[]> Acts=new Action<Task[]>(t=>Console.WriteLine("这是完成的后续动作！"));

            Task Con = taskFactory.ContinueWhenAll(listask.ToArray(), Acts);

            listask.Add(Con);

            //等待所有编码完成
            Task.WaitAny(listask.ToArray());//在主线程里面
            Console.WriteLine("已经有任务完成了！");

            Task.WaitAll(listask.ToArray());

            Console.WriteLine("所有任务都完成了！");

        }
        public void Coding(string name)
        {
            Thread.Sleep(new Random().Next(2000, 5000));
            Console.WriteLine("My Name is {0}",name);
        }
    }
}
