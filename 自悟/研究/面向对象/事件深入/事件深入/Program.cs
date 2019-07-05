using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件深入
{
    class Program
    {
        public delegate void MyDelegate();
        public static MyDelegate MyDeOPP;//委托实例
        public static event MyDelegate MyDeOPPEvent;//定义事件 现在仔细看这几条语句。
        //声明事件：事件的本质就是委托的一个实例，加了event关键字。
        //委托是类型，事件是委托类型的实例。
        static void Main(string[] args)
        {
            Console.WriteLine("--------委托--------");
            MyDeOPP = new MyDelegate(Class1.ShowClass1);
            MyDeOPP += Class1.ShowClass1;
            MyDeOPP += Class2.ShowClass2;
            MyDeOPP += Class3.ShowClass3;
            MyDeOPP();
           
            Console.WriteLine("--------事件--------");
            
  //          Class1.ClassEvent = new Class1.MyDelegate(Class1.ShowClass1);//1.不能被初始化
  //          Class1.ClassEvent = Class1.ShowClass1;//防止外面直接赋值为null，导致注册失败
  //          Class1.ClassEvent();//2.不能被外部调用
            
   //         事件"事件深入.Class1.ClassEvent"只能出现在 += 或 -= 的左边
  //          (从类型"事件深入.Class1.ClassEvent"中使用时除外)

            //总结：事件是一种权限的控制

            Class1.ClassEvent += Class1.ShowClass1;
            Class1.ClassEvent += Class2.ShowClass2;
            Class1.ClassEvent += Class3.ShowClass3;

            MyDeOPPEvent = new MyDelegate(Class1.ShowClass1);
            MyDeOPPEvent += Class1.ShowClass1;
            MyDeOPPEvent += Class2.ShowClass2;
            MyDeOPPEvent += Class3.ShowClass3;
            MyDeOPPEvent();

            //还记得WinForm 的种种事件定义吗？每个事件都是定义在 自己类的里面，而调用也是在自己类的里面

            //这个时候 你可能会问，为什么不直接用接口实例(多播委托) 来代替事件呢。
            //刚才我们说过事件 是一种权限控制，也就是一种 带有特殊权限的委托，这种权限不等同于 private 因为事件 可以注册，删除 事件 ， 这是 private 多播委托无法替代的。

            //事件：就是委托的实例，加上了 event关键字
            
            //委托和事件的关系和区别？
            //委托是一种类型，事件是委托的实例，加上了event关键字
            //会限制实例的操作，不能直接 Invoke和赋值，只能内部调用和赋值
            
        }
    }
}
