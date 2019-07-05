using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TimeZone.CurrentTimeZone.DaylightName);//猜猜输出什么？中国标准时间！
            //TimeSpan:表示一个时间间隔
            Console.WriteLine(TimeSpan.MaxValue);
            Console.WriteLine(TimeSpan.MinValue);
            Console.WriteLine(TimeSpan.TicksPerMinute);

            //下面介绍如何设置时间
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("2秒等待完成");
            System.Threading.Thread.Sleep(TimeSpan.FromDays(2));
            Console.WriteLine("2天等待完成");
        }
    }
}
