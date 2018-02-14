using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class ClassSingle
    {
        public ClassSingle()
        {
            Console.WriteLine($"正在执行{this.GetType().Name}的构造函数");
        }
        public int No { get; set; }
        public string Name { get; set; }

        static public ClassSingle NewClass=new ClassSingle();//在第一次执行 ClassSingle时，就会创建该静态对象
        static public ClassSingle CreateInstance()
        {
            return NewClass;
        }
    }
}
