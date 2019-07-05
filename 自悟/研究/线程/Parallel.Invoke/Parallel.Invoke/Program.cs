using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void DoSomething()
        {
            Console.WriteLine("函数所在线程" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(200);
        }
        static void Main(string[] args)
        {
            Action[] actions = { new Action(DoSomething), DoSomething };
            Parallel.Invoke(actions);//并行 执行多个任务，值到完成
            Console.WriteLine("主函数所在线程" + Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }
    }
}
