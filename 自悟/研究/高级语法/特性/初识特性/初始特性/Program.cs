using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初始特性
{
    class Program
    {
        [Mj("")]
        static void Main(string[] args)
        {
            Student A = new Student();
            /*
             * 注释编译后 是一个 xml文件
             * 
             * 能不能读到注释：在任何情况都读不到，注释在一个单独的 xml文件里
             * 
             * 注释呢，是编写代码时，由VS识别和使用的
             * 特性呢，代码编译/使用时，可能产生影响
             * 
             * 特性是一个类，是 Attribute的子类
             * 
             * 特性 通常以 Attribute结尾，在使用特性 时，可以去掉 Attribute 当然也可以全拼
             * 
             * [Obsolete("已经过时了！你不能用！", true)] 其中" (xxx) "括号起来 就是调用 其特性(该类)的构造函数
             * 
             * 特性 会编辑成 IL文件的
             * 
             * 我们声明一个特性 就是建一个类，让其继承自 Attribute
             * 
             * XXXAttribute
             * 
             * 使用时就是[XXX] 或 [XXXAttribute]
             * 
             * XXXAQW
             * 
             * 使用时就是全名[XXXAQW]
             * 
             * 特性 全部是 基于反射来完成的，没有反射，特性是不会产生作用的
             * 要使用特性，一定要有反射
             * 
             * 因为特性编译后 会产生一个 metada的东西，本身和我们的代码没有关系
             * 
             * 而metada 只能通过反射来访问到
             * 
             * 注释是找不到的，特性可以找到
             * 
             */
            new Program().Method();

            {
                //如何在程序的使用中，使用Attribute ： 利用反射机制

                //找到 Student的类型
                Type StudentType = typeof(Student);

                //找到 Student使用的特性，并且查看有没有使用 MjAtrribute特性，返回一个 object[]
                object[] AttributeArray = StudentType.GetCustomAttributes(typeof(MjAttribute), true);

                if (AttributeArray != null && AttributeArray.Length > 0)
                {
                    ((MjAttribute)AttributeArray[0]).Jump();
                }
            }

            {
                Action action = new Action();
            }

            {


                //********使用特性检测*********

                Type StudentType = typeof(Action);

                object[] AttributeArray = StudentType.GetCustomAttributes(typeof(MjAttribute), true);

                if (AttributeArray != null && AttributeArray.Length > 0)
                {
                    Action action = new Action();
                    action.ShowQWE();
                }
                else
                {
                    //Attribute - MVC filler
                    Console.WriteLine("没有合适的Action处理您的请求");
                }

            }

            Console.WriteLine("*****************特性的具体使用******************");
            Console.WriteLine(UserState.Deleted.GetRemark("Name"));
            Console.WriteLine(UserState.Frozen.GetRemark("QWE"));

        }
       [Obsolete]
        [Mj("ShaZi", Liulin = "")]//在特性的构造函数的参数列表中 可以找到 属性=  这一项
        // [LiulinAtt]
        void Method() { }
    }
}
