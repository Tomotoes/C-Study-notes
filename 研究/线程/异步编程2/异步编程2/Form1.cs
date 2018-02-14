using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace 异步编程2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //根据Lambda表达式定义委托
        Func<int, int, int> Ex = (Num, Ms) =>
        {
            Thread.Sleep(Ms);
            return Num * Num;
        };
        Action<int> Q = P => Console.WriteLine("This is P!");
        AsyncCallback A = new AsyncCallback(d => Console.WriteLine("QWERTY"));
        //此时强烈建议你去对着AsyncCallback 摁F12，是一个委托，并且该委托的参数是 IAsyncResult类型！类似空
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; ++i)
            {
                //开始异步编程，并封装回调函数,每个BeginInvoke都只能有一个 EndInvoke
                Ex.BeginInvoke(10 * i, 1000 * i, MyCallback, i);//仔细观察这一步，回调函数是如何使用的，直接写一个方法的名字即可，并且不用写相关参数

                Q.BeginInvoke(5, t => Console.WriteLine("{0}", t.AsyncState), "qwe");
                Action E = new Action(() => Console.WriteLine("ASDF"));
                E.BeginInvoke(A, null);

                //最后一个参数 i 给回调函数的字段AsyncState赋值，如果数据很多，可以传递集合或者类，毕竟object类型，传什么都可以
            }
           
        }
        //先来介绍一下IAsyncResult接口中AsyncState的含义：获取用户定义的对象，它限定或包含关于异步操作的信息

        //回调函数的定义:在回调函数中 IsCompleted 一定是 true！
        public void MyCallback(IAsyncResult Result)//事实证明 回调函数的参数类型最好就是 IAsyncResult类型的
        {
            int o = Ex.EndInvoke(Result);//等待异步的结束，获取调用的结果，效果表现为：卡住当前线程
            Console.WriteLine("This is {0} and Result is {1}", Result.AsyncState, o);//此时Result.AsyncState就是上面函数传下来的 i

        }

        /*
         * 异步编程总结：
         * 1.异步编程是建立在委托基础之上的编程方法。
         * 2.异步调用的每个方法都是在独立的线程中执行的。因此，本质上就是一种多线程，也可以说是一个“简化的多线程”
         * 3.比较适合在后台运行较为耗费时间的《简单任务》，并且要求任务之间是独立的，任务中不要有直接访问可视化控件的内容。
         * 4.如果后台任务要求必须按照特定顺序执行，或者访问特定的共享资源，异步编程不太适合，而应该选择多线程开发技术。
         */

        /*
         * 异步编程的特点：
         * 1.同步方法卡住界面，异步方法不卡界面，原因是 异步启动了多个线程执行计算任务，而主线程没被占用
         * 2.同步方法慢，异步方法快，原因是异步启动多个线程，使用了更多的资源在计算
         * 3.异步执行是无序的，是随机顺序，原因是线程的启动是无序的，然后执行同一任务的时间也是不同的
         */

    }
}
