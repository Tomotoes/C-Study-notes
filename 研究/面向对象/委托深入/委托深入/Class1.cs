using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托深入
{

    class Cat//监控模式类！我们触发这个方法时，不知道会发生什么，所以我们要判断！
    {                     
        public delegate void OPP();
        public static OPP QWE;
        public static void ShowQWE()
        {                 
            Console.WriteLine("QWE");
            if (QWE != null)
            {             
                Console.WriteLine("监控者模式启动！");
                Console.WriteLine("******************");
            }             
        }                 
                          
    }                     
}
