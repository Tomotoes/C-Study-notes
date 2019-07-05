using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LINQ
{
    class Program
    {
        static public void Output(IEnumerable Item)
        {
            foreach (var B in Item)
            {
                Console.WriteLine(B);
            }
        }
        static void Main(string[] args)
        {
            int[] Set = new int[] { 78, 152, 65, 421, 87, 12, 9871, 124, 12 };
            var Ac = Set.Average();//聚合函数 全位于 linq 命令中
            Console.WriteLine(Ac);
            Console.WriteLine(Set.Sum(n => (long)n));
            Console.WriteLine(Set.Distinct());

            var WE = Set.Where(n => n > 100);
            Console.WriteLine(WE);//输出的是类型
            Output(WE);
            var RE = from n in Set where n > 100 select n;
            Output(RE);
            string[] Str = { "Simon", "SFop", "SNoAc", "Acz", "Mjk" };
            var Q = Str.Where(n => n.StartsWith("S"));
            //不加Lambda表达式，不会出现扩展方法
            Output(Q);
            var T = from n in Str where n.Contains("S") select n;
            Output(T);
        }
    }
}
