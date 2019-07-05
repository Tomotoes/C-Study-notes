using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托深入
{
    class Program
    {
        public delegate void MyDelegateFirst(int x, int y);//委托是不可以设置为静态
        public delegate string MyDelegateSecond();
        public delegate void MyDelegateThird(int x, int y);
        public static void ShowNumber(int x, int y)
        {
            Console.WriteLine(x + " , " + y);
        }
        
        static void Main(string[] args)
        {
            MyDelegateFirst Wa = (s, d) => Console.WriteLine("AAA");
            Wa += ShowNumber;
            Wa.Invoke(7, 8);
            Console.WriteLine("-----");
            MyDelegateFirst Ac = new MyDelegateFirst(ShowNumber);
            //Ac -= ShowNumber;//相当于 Ac=0，此时调用委托肯定会异常
            Ac += ShowNumber;//多播委托

            Ac += Wa;//委托A += 委托B    就会把委托B 的所有方法给委托A

            Ac += (r,t) => Console.WriteLine("WEQ");//委托A += Lambda表达式,而必须参数相同，返回类型相同

            //事实证明如果委托类型 不同 就不能互相 加！ 必须在同一委托类型才行！
            //MyDelegateThird Q = (Ran,d)=>Console.WriteLine("454");
            //Ac += Q;

            //MyDelegateSecond TLE = () => "AAAABBB";
            //Ac += TLE;

            //总结：委托可以加委托，但是必须确保 同一委托！
            //      委托也可以加 Lambda表达式！但是Lambda表达式的条件（参数类型 返回类型）必须和委托条件相同
            //      
            //      事实证明，无论什么 都必须满足 参数类型，返回类型！只不过Lambda表达式 可以越过委托这一界限！


            Ac(1, 2);//委托的第一种调用模式
            Console.WriteLine("---------");
            Ac.Invoke(1, 2);//委托的第二种调用模式

           // Ac.BeginInvoke(1, 2, null, null);//委托的第三种调用模式 ，是异步调用的形式

            //Ac.GetInvocationList():获取 Ac这个委托中 包括的所有的方法
            foreach (MyDelegateFirst A in Ac.GetInvocationList())
            {
                Console.WriteLine(A.Method.Name);//获取现在方法的名字
                A.Invoke(3, 4);
            }

            //多播委托的价值：一个动作 触发 别的一系列动作
            Console.WriteLine("---***");

            Cat.ShowQWE();

            Cat.QWE = Cat.ShowQWE;
            Cat.QWE();

            MyDelegateFirst AE = null;
            AE += ShowNumber;
            AE(1,2);

        }
    }
}
