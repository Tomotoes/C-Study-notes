using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 将APM模式转换为任务
{
    class Program
    {
        delegate string AsynchronousTask(string threadName);
        delegate string IncompatibleAsynchronousTask(out int threadId);

        static void Callback(IAsyncResult ar)
        {
            Console.WriteLine("Starting a callback");
            Console.WriteLine("State passed to a callback :{0}",ar.AsyncState);
            Console.WriteLine("Is thread pool thread :{0}",Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread pool worker thread id:{0}",Thread.CurrentThread.ManagedThreadId);
        }

        static string Test(string threadName)
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Is thread pool thread :{0}",Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Thread.CurrentThread.Name = threadName;
            return string.Format("Thread name is {0}", Thread.CurrentThread.Name);
        }

        static string Test(out int threadId)
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Is thread pool thread :{0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            threadId = Thread.CurrentThread.ManagedThreadId;
            return string.Format("Thread pool worker thread id was{0}", threadId);
        }
        static void Main(string[] args)
        {
            int threadId;
            AsynchronousTask d = Test;
            IncompatibleAsynchronousTask e = Test;

            Console.WriteLine("Option 1");

            Task<string> task = Task<string>.Factory.FromAsync(d.BeginInvoke("AsyncTaskThread", Callback, "a delegate asynchronous call"), d.EndInvoke);

            task.ContinueWith(t => Console.WriteLine("Callbackback is finished,now running a continuation! Result:{0}", t.Result));

            while (!task.IsCompleted)
            {
                Console.WriteLine(task.Status);
                Thread.Sleep(500);
            }
            Console.WriteLine(task.Status);
            Thread.Sleep(1000);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Option 2");

            task = Task<string>.Factory.FromAsync(d.BeginInvoke, d.EndInvoke, "AsyncTaskThread", "a delegate asynchronous call");
            
            task.ContinueWith(t => Console.WriteLine("Task is finished,now running a continuation! Result:{0}", t.Result));

            while (!task.IsCompleted)
            {
                Console.WriteLine(task.Status);
                Thread.Sleep(500);
            }
            Console.WriteLine(task.Status);
            Thread.Sleep(1000);

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Option 3");

            IAsyncResult ar = e.BeginInvoke(out threadId, Callback, "a delegate asynchronous call");

            task = Task<string>.Factory.FromAsync(ar, _=>e.EndInvoke(out threadId,ar));

            task.ContinueWith(t => Console.WriteLine("Task is completed,now running a continuation! Result:{0},ThreadId:{1}", t.Result,threadId));

            while (!task.IsCompleted)
            {
                Console.WriteLine(task.Status);
                Thread.Sleep(500);
            }
            Console.WriteLine(task.Status);
            Thread.Sleep(1000);
        }
        /*
         * 工作原理：
         * 我们定义了两种委托。其中一个使用了 out参数，因此在将APM模式转换为任务时，与标准的TPL API是不兼容的。这样的转换有三个示例。
         * 将APM转换为TPL的关键点是Task<T>.Factory.FromAsync方法，T是异步操作结果的类型。该方法有数个重载。
         * 在第一个例子中传入了IAsyncResult 和 Func<IAsyncResult,string>,这里一个将 IAsyncResult的实现作为参数并返回一个字符串的方法。
         * 由于第一个委托类型提供的EndMethod 与该签名是 兼容的，所以将该委托的异步调用转换为任务 没有任何问题。
         * 第二个例子做的事和第一个非常相似，但是使用了不同的 FromAsync方法重载，该重载并不允许指定一个将会在异步委托调用完成后被调用的回调函数。
         * 但我们可以使用后续操作替代它。但如果回调函数很重要，可以使用第一个例子所示方法。
         * 最后一个例子展示了一个小的技巧。这次 IncompatibleAsynchronousTask委托的EndMethod使用了 out参数，与FromAsync方法重载并不兼容。
         * 然而可以很容易地将EndMethod调用封装到一个Lambda表达式中，从而适合任务工厂方法。
         * 可以再等待异步操作结果过程中打印出任务状态，从而了解底层任务的运行情况。
         * 可以看到第一个任务的状态为 WaitingForActivation，这意味着TPL基础设施实际上还未启动该任务。
         */
    }
}
