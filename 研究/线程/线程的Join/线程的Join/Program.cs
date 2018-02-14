using System;
using System.Threading;

namespace 线程的Join
{
    class Runner
    {
        public void run()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Runner r = new Runner();
            Thread thread = new Thread(r.run);

            thread.Start();

            // thread.Join();//在此期间只能用 此线程 直到此线程结束，才能用其他线程，又让我想起了试衣间

            //主线程调用了 thread线程的 Join方法
            //主线程必须等待 thread线程结束 才会向下执行

            // thread.Join(TimeSpan.FromDays(99));//
            thread.Join(600);//等待600毫秒后，就会向下执行

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("\t" + i);
                Thread.Sleep(500);
            }
        }
    }
}
