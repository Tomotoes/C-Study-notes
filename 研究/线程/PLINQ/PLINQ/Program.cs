using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Collections.Generic;

using System.Linq;

class Program
{
    const int count = 1000000;
    static void Main(string[] args)
    {
        var dic = LoadData();
        Stopwatch watch = new Stopwatch();
        watch.Start();
        //串行运算
        var query1 = (from n in dic.Values
                      where n.Age > 20 && n.Age < 25
                      select n).ToList();
        watch.Stop();
        Console.WriteLine("串行计算耗费时间：{0}", watch.ElapsedMilliseconds);
        watch.Restart();
        //并行运算
        var query2 = (from n in dic.Values.AsParallel()
                      where n.Age > 20 && n.Age < 25
                      select n).ToList();
        watch.Stop();
        Console.WriteLine("并行计算耗费时间：{0}", watch.ElapsedMilliseconds);
        Console.Read();
    }
    public static ConcurrentDictionary<int, Student> LoadData()
    {
        ConcurrentDictionary<int, Student> dic =
            new ConcurrentDictionary<int, Student>();

        Parallel.For(0, count, (i) =>
        {
            var single = new Student()
            {
                ID = i,
                Name = "n" + i,
                Age = i % 151,
                //CreateTime = DateTime.Now.AddSeconds(i)
            };
            dic.TryAdd(i, single);
        });
        return dic;
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
