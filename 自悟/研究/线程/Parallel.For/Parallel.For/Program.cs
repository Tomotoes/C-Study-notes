using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ASK.For
{
    class Program
    {
        static double Calc(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; ++i)
            {
                f *= i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => 
            {
                Console.WriteLine("i={0},fac={1},线程od={2}",i,Calc(i),Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            });
            Console.ReadKey();
        }
    }
}
