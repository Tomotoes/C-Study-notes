using System;
using System.Collections.Generic;
using System.Linq;

namespace 并发集合之PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = Enumerable.Range(-5, 10);

            var Query = from number in numbers select 100 / number;

            try
            {
                foreach(var n in Query)
                {
                    Console.WriteLine(n);
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divided by zero!");
            }

            Console.WriteLine("--");

            var parallelQuery = from number in numbers.AsParallel() select 100 / number;
            Console.WriteLine(parallelQuery.GetType());

            try
            {
                //这个方法 吊不吊。。。指定的操作中每个元素并行调用 source
                parallelQuery.ForAll(Console.WriteLine);
            }
            catch(AggregateException e)
            {
                e.Flatten().Handle(ex =>
                {
                    if (ex is DivideByZeroException)
                    {
                        Console.WriteLine("Divided by zero!!!!!!!!!!");
                        return true;
                    }
                    return false;
                });
            }
        }
    }
}
