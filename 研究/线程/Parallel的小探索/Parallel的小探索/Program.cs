using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Parallel的小探索
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我是主线程，线程ID是{0}\n",Thread.CurrentThread.ManagedThreadId);

            //并行的 (系统自动划分 多个‘区’(线程) )
            //Parallel.For(起始值，结束值，委托)
            Parallel.For(0, 100, t => Console.WriteLine("当前的数值是{0}，使用的线程ID是{1}", t, Thread.CurrentThread.ManagedThreadId));
            
            Console.WriteLine("-----------------------------------------");
            
            Parallel.For(0, 100, (t, loop) =>
            {
                Console.WriteLine("当前的数值是{0}，使用的线程ID是{1}", t, Thread.CurrentThread.ManagedThreadId);
                if (t == 25)
                {
                    Console.WriteLine("线程要终止！");//事实证明，线程终止失败！
                    //Thread.Sleep(5000); 并发线程真的没办法终止。。。
                    loop.Break();//无论是 Stop还是 Break方法 都无法终止并发线程
                    //loop.Stop();
                }
            });

            Console.WriteLine("------------设置并行线程数量！------------");

            Parallel.For(0,100,new ParallelOptions(){
                MaxDegreeOfParallelism=Environment.ProcessorCount//设置为最大数量
            },t=>Console.WriteLine("当前的数值是{0}，使用的线程ID是{1}", t, Thread.CurrentThread.ManagedThreadId));
            
            Console.WriteLine("------------Parallel.Foreach------------");

            List<int> list = new List<int>();

            Parallel.For(0, 100, new ParallelOptions() { MaxDegreeOfParallelism=Environment.ProcessorCount},   t => list.Add(t));

            Parallel.ForEach(list, t => Console.WriteLine("当前的数值是{0}，使用的线程ID是{1}", t, Thread.CurrentThread.ManagedThreadId));

            //执行所提供的每个操作，而且尽可能的并行运行，除非用户取消了操作
            Parallel.Invoke(new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount },
                () => Console.WriteLine("asd"), () => Console.WriteLine(45), () => { }, () => { });
            //Parallel.Invoke 的重载很特别，第一个设置并发线程数量，第二个是个Action委托数组

            //值得一提的是，并发编程 非常适用于 ADO的操作，这会使ADO的操作，快数倍！
            //就比如：
            Parallel.Invoke(() =>
            {
                SqlConnection Con = new SqlConnection();
                SqlDataReader Reader = null;
                while (Reader.Read())
                {
                    //Do Something...
                }
            });

        }
    }
}
