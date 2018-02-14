using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class A
    {
        public A()
        {
            Console.WriteLine("in A()");
            PrintFields();
        }
        public virtual void PrintFields()
        {
            Console.WriteLine("in A.PrintFields()");
        }
    }
    class B : A
    {
        int x = 1;
        int y;
        public B()
            : this(0)
        {
            Console.WriteLine("in B()");
            y = -1;
        }
        public B(int i)
        {
            Console.WriteLine("in B("+i+")");
        }
        public override void PrintFields()
        {
            Console.WriteLine("in B.PrintField()");
            Console.WriteLine("x = {0} , y = {1}",x,y);
        }
    }
    class C
    {
        static void Main(string[] args)
        {
            B b = new B();
            /*
             * 下面 我来解析一下执行顺序
             * 1.public B()
             * 2.public B(int i)
             * 3.B:base() 也就是 public A()
             * 4.输出 in A()
             * 5.B.PrintFields() 并输出 in B.PrintFields() x=1,y=0 此时 B:base() 执行完毕
             * 6.现在 执行 public B(int i) 输出 in B(0) 此时 public B(int i)执行完毕
             * 7.现在执行 public B() 输出in B() 并把 字段 y赋值为-1
             */

            //以上都很清楚 ， 然后发现唯一的麻烦 就是 虚方法 不知道 调用哪一个，
            //本以为 是调用 A的虚方法 因为 那个时候 B的对象根本没有构造成功
            //就按照虚方法那样去理解吧
        }
    }
}
