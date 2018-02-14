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

namespace 异步编程1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Ex1(10).ToString();
            label2.Text = Ex2(10).ToString();
        }
        public int Ex1(int Num)
        {
            return Num * Num;
        }
        public int Ex2(int Num)
        {
            Thread.Sleep(5000);
            return Num * Num;
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Func<int,int> Ac = Ex2;
            //异步调用任务
            IAsyncResult Res = Ac.BeginInvoke(10, null, null);
            //通过委托异步调用方法
            //委托类型BeginInvoke(<输入和输出变量>,AsyncCallback callback,object asyncState) 方法：异步调用的核心
            //第一个参数10，表示委托对应的实参
            //第二个参数 callback：回调函数，表示异步调用后自动调用的函数
            //第三个参数 asyncState，用于向回调函数提供参数信息
            //返回值：IAsyncResult -> 异步操作状态接口，封装了异步执行中的参数

            //同时执行其他任务  14-33
            label1.Text = Ex1(10).ToString();

            //获取异步执行的结果
            label2.Text = Ac.EndInvoke(Res).ToString();
            //委托类型的EndInvoke()方法：就相当于 一直监视着方法是否执行完毕！
            //借助IAsyncResult接口对象：不断的查询异步调用是否结束。该方法指导异步调用方法的所有参数，所以，异步调用完毕后，取出异步调用的结果作为返回值。
        }
    }
}
