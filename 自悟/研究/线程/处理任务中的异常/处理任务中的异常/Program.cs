using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 处理任务中的异常
{
    class Program
    {
        static int TaskMethod(string Name, int Seconds)
        {
            Console.WriteLine($"The Name is {Name} And ThreadID is {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep(TimeSpan.FromSeconds(Seconds));
            throw new Exception("Boom!");//hahaha
            return 42 * Seconds;
        }
        static void Main(string[] args)
        {
            Task<int> task;
            try
            {
                task = Task.Run(() => TaskMethod("Task 1", 2));
                int res = task.Result;
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            try
            {
                task = Task.Run(() => TaskMethod("Task 2", 2));
                int res = task.GetAwaiter().GetResult();
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("-----------------------------------------------");

            var t1 = new Task<int>(() => TaskMethod("Task 3", 3));
            var t2 = new Task<int>(() => TaskMethod("Task 4", 2));

            var complexTask = Task.WhenAll(t1, t2);//都完成

            var exceptionHandler = complexTask.ContinueWith(t => Console.WriteLine(t.Exception), TaskContinuationOptions.OnlyOnFaulted);//注意第二个参数

            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
        /*
        当程序启动时，创建了一个任务并尝试同步获取任务结果。Res属性的Get部分会使当前 线程等待直到该任务完成，
        并将异常传播给当前线程。在这种情况下，通过 catch代码块 可以很容易地捕获异常，但是该异常是一个被封装的异常，叫做 AggregateException。
        第二个例子与第一个非常显示，不同之处是使用了 GetAwaiter 和 GetResult 方法来 访问任务结果。
        在这种情况下 无需封装异常，因为 TPL基础设施会提取该异常。如果只有一个底层任务，那么一次只能获取一个原始异常，这种设施非常合适。
        最后一个例子 展示了两个任务抛出异常的情形。
        现在使用后续动作来处理异常。只有之前的任务 完成前有异常时，该后续操作 才会被执行。
        通过给后续操作传递TaskContinuationOptions.OnlyOnFaulted 选项可以实现该行为。
        结果打印了 AggregateException，其内部封装了 两个任务抛出的异常。
         */
    }
}
