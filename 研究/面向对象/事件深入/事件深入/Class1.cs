using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件深入
{
    class Class1
    {
        public delegate void MyDelegate();
        public static event MyDelegate ClassEvent;
        public static void ShowClass1()
        {
            Console.WriteLine("ShowClass1");
        }
    }
}
