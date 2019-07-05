using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Parallel的进阶
{
    class Program
    {
        static string EmulateProcessing(string taskName)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds(new Random(DateTime.Now.Millisecond).Next(250, 350)));

            Console.WriteLine("TaskName is {0} and The ThreadID is {1}", taskName, Thread.CurrentThread.ManagedThreadId);

            return taskName;
        }
        static void Main(string[] args)
        {
            //程序会并发地执行
            Parallel.Invoke(
                () => EmulateProcessing("Task 1"),
                () => EmulateProcessing("Task 2"),
                () => EmulateProcessing("Task 3")
                );
            /*
             * 与在任务并行库中定义任务的方式相比，调用Invoke方法可以免去 很多麻烦就可实现并行地运行多个任务。
             * Invoke方法会阻塞其他线程 直到所有的任务 都被完成。
             */

            //实例化 取消命令类
            CancellationTokenSource cts = new CancellationTokenSource();

            int Count = 0;//用来测量 迭代次数

            //定义结果接收其最终状态
            //第一个参数是个数组：Enumerable.Range：生成指定范围内的整数的序列。
            //第二个参数：new ParallelOptions()：配置操作行为，其中有三个属性，也都一一列出
            //第三个参数 是个委托方法，其中第一个参数 是遍历使用的变量，第二个是有关 循环设置变量，然而在并发的面前，并没有什么卵用
            ParallelLoopResult Res = Parallel.ForEach(Enumerable.Range(1, 30), new ParallelOptions()
            {
                CancellationToken = cts.Token,
                MaxDegreeOfParallelism = Environment.ProcessorCount,
                TaskScheduler = TaskScheduler.Default
            }, (i, state) =>
            {
                Count++;
                Console.WriteLine(i);
                if (i == 20)
                {
                    state.Break();
                    Console.WriteLine("Loop is Stopped:{0}", state.IsStopped);//Fase
                }
            });
            //可以给ForEach方法提供一个ParallelOptions类的实例 来控制运行 并行循环。其允许 我们使用CancellationToken取消循环，限制最大并行度（并行运行的最大操作数），还可以提供一个自定义的TaskScheduler类 来调度任务。
            //Action可以接受一个附加的ParallerLoopState参数，可用于从循环中跳出 或者 检查当前循环状态

            Console.WriteLine("运行次数：{0}",Count);
            Console.WriteLine();

            Console.WriteLine("IsCompleted:{0}",Res.IsCompleted);//Fase
            // 摘要: 
            //     获取该循环是否已运行完成（即，该循环的所有迭代均已执行，并且该循环没有收到提前结束的请求）。
            //
            // 返回结果: 
            //     如果该循环已运行完成，则为 true；否则为 false。
            Console.WriteLine("Lowest break iteration:{0}",Res.LowestBreakIteration);
        }
    }
}
