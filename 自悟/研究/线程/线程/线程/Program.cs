using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程
{
    class Program
    {
        static public void Method()
        {
           
            for (int i = 0; i < 2; ++i)
            {
                Console.Write(".");
            }
            
            Console.WriteLine(Thread.CurrentThread.Name.ToString());
        }
        static void Main(string[] args)
        {
            Task A = new Task(new Action(() => Console.WriteLine("A")));
            A.Start();
            Task B = new Task(Method);
            //B.Start();

            Thread C = new Thread(Method);
            C.Name = "C";
            C.Start();

            Thread D = new Thread(new ThreadStart(Method));//其中 ThreadStart 是一个委托
            D.Name = "D";
            D.Start();
            
         

            Console.WriteLine("-------------------");
            
            Program p1 = new Program();
            Thread A1 = new Thread(new ThreadStart(p1.Count));
            A1.Name = "A1";
            Program p2 = new Program();
            Thread A2 = new Thread(new ThreadStart(p2.Count));
            A2.Name = "A2";
            Program p3 = new Program();
            Thread A3 = new Thread(new ThreadStart(p1.Count));
            A3.Name = "A3";

            A1.Start();
            A2.Start();
            A3.Start();

            //当为每个线程创建专用的对象时，多线程的作用没有发挥极致：三个线程同时共享相同的c
            //当每个线程共用一个对象时，会发生很奇妙的事情，
                //就像是一件事三个人做，但这三个人没有联系,所以出现 多数字少数字的情况
            //当对象数量为2个 被三个线程分享时，就会出现交替的情况

            //Timer Q = new Timer(,);
        }
        //3个代码 没有练习: 画图 Timer Windows界面更新


        private int c = 0;
        private void Count()
        {
            while (c < 10)
            {
                ++c;
                Console.WriteLine(Thread.CurrentThread.Name+"数到"+c);
                Thread.Sleep(500);//单位毫米 运行起来 你就会发现 是每间隔一秒就会蹦出三个输出
                
            }
        }
    }
}
