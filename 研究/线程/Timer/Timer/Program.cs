using System;
using System.Threading;

namespace Timer类
{
    /// <summary>
    /// 本节将描述如何使用 System.Threading.Timer对象来在线程池中创建周期性调用的异步操作
    /// </summary>
    class Program
    {
        static Timer timer;
        static void TimerOperation(DateTime start)
        {
            TimeSpan elapsed = DateTime.Now - start;
            Console.WriteLine($"{elapsed.Seconds} from {start} + ThreadID : {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            timer = new Timer(_ => TimerOperation(DateTime.Now), null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(2));
            
            try
            {
                Thread.Sleep(6000);//只有主线程睡眠了，其他线程根本不会受影响

                timer.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(4));

                Console.ReadKey();
            }
            catch { timer.Dispose(); }
            /*
            我们首先创建了一个Timer实例。
            第一个参数是一个Lambda表达式，将会在线程池中被执行。
            我们调用TimerOperation方法并给其提供一个起始时间。
            由于无须使用用户状态对象，所以第二个参数为null。
            然后指定了什么时候会第一次运行TimerOperation方法，以及之后再次调用的时间。
            所以第一个值实际上说明一秒后 会启动第一个操作，然后每隔2秒再次运行

            之后等待6秒后修改计时器。
            在调用time.Change 方法一秒后 启动TimerOperation，然后每隔4秒再次运行。
             */

            /*
            计时器还可以更加复杂！
            可以以更复杂的方式使用计时器。
            比如，可以通过 Timeout.Infinite 值来提供给计时器一个间隔参数 来只允许 计时器操作一次。
            然后在计时器异步操作内部，能够 设置下一次计时器操作将被执行的时间。
             */
        }
    }
}
