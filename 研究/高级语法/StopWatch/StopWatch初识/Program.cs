using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace 初识
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch SW = new Stopwatch();
            SW.Start();
            Thread.Sleep(1000);
            Console.WriteLine("现在计时器是否运行  {0}",SW.IsRunning);
            Console.WriteLine(SW.Elapsed);//获取当前实例测量得出的总运行时间
            Console.WriteLine(SW.ElapsedMilliseconds);////获取当前实例测量得出的总运行时间(以毫秒为单位)
            Console.WriteLine(SW.ElapsedTicks);
            SW.Stop();
            Console.WriteLine("现在计时器是否运行  {0}", SW.IsRunning);

            SW.Reset();//停止时间间隔测量。将运行时间重置为零

            SW.Restart();//停止时间间隔测量。将运行时间重置为零，然后开始测量运行时间

            Stopwatch sw  =  Stopwatch.StartNew();//得到一个新的 Stopwatch的对象 并自动调用 Start 方法
            Thread.Sleep(100);
            Console.WriteLine(sw.ElapsedMilliseconds);
            
        }
    }
}
