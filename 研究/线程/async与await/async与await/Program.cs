using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace async与await
{
    class Program
    {
        static Task AsynchronyWithTPL()
        {
            Task<string> t = GetInfoAsync("Task 1");
            Task t2 = t.ContinueWith(task => Console.WriteLine(t.Result), TaskContinuationOptions.NotOnCanceled);
            Task t3 = t.ContinueWith(task => Console.WriteLine(t.Exception.InnerException), TaskContinuationOptions.OnlyOnFaulted);

            return Task.WhenAny(t2, t3);
        }
        static async Task AsyncronyWhitAwait()
        {
            try
            {
                string result = await GetInfoAsync("Task 2");//记住使用方法，在async中，使用 await
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static async Task<string> GetInfoAsync(string Name)
        {
            await Task.Delay(2000);
            return string.Format("Name is{0} and ThreadId is {1}", Name, Thread.CurrentThread.ManagedThreadId);
        }
        async Task<int> Method()//加了async 便可以直接返回 Task中泛型的值。
        {
            return 10;
        }
        static void Main(string[] args)
        {
            Task t = AsynchronyWithTPL();
            t.Wait();

            t = AsyncronyWhitAwait();
            t.Wait();

        }
        /*
         * 当程序运行时，运行了两个异步操作。
         * 其中一个是标准的TPL模式的代码，第二个使用了C#的新特性async和await。
         * AsynchronyWithTPL方法启动了一个任务，运行两秒后 返回关于工作者线程信息的字符串。
         * 然后 我们定义了一个后续动作，用于在异步操作完成后打印出该操作结果，
         * 还有一个后续动作，用于万一有错误发生时，打印出异常细节。
         * 最终返回了一个代表其中一个后续操作任务的任务，并等待其在Main函数中完成。
         * p87
         */
    }
}
