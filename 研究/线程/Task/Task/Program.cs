using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ASK
{
    class Program
    {
        static double SomeFun()
        {
            Thread.Sleep(50);
            return 0;
        }
        static void Main(string[] args)
        {
            Task<double>[] tasks = { Task.Run(() => SomeFun()), Task.Run(() => SomeFun()) };
            Thread.Sleep(1);
            Console.WriteLine(tasks[0].Result);
            for (int i = 0; i < tasks.Length; ++i)
            {
                Console.WriteLine(tasks[i].Status);
                Console.WriteLine(tasks[i].Result);
            }
            
            Task.WaitAll(tasks);//等待 tasks数组的task 都执行完成
        }
    }
}
