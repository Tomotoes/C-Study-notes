using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        /*
        上次，我们学习了单例模式，对于一个类的使用，只实例化一个对象，然后频繁的去使用它。
        
        很明显，这有一个弊端，如果我想把字段A 设成QWE，而其他人在我之后，又把字段A重新赋值了，那么我的数据就会被覆盖。

        这个时候，有没有哪一种设计模式合适呢？答案是有的，它就是 原型模式。
        
        还记得 你曾经学过 浅度复制 与 深度复制吗？

        原型模式便是基于浅度复制，实现对单例模式的一种更新，从而达到需求。
         */
        static void Main(string[] args)
        {
            //单例模式的弊端
            {
                ClassSingle A = ClassSingle.CreateInstance();
                A.No = 1;
                A.Name = "A";

                ClassSingle B = ClassSingle.CreateInstance();
                B.No = 2;
                B.Name = "B";
                //此时 A的No，Name 也随之改变

                Console.WriteLine($"A.No==B.No?{A.No == B.No}");//true
                Console.WriteLine($"A.Name==B.Name?{A.Name == B.Name}");//true
            }
            //原型模式：不重复构造对象，也就是构造函数；多个操作不覆盖，不能是同一个对象。
            {
                ClassClone A = ClassClone.CreateInstance();
                A.No = 1;
                A.Name = "A";

                ClassClone B = ClassClone.CreateInstance();
                B.No = 2;
                B.Name = "B";
                //此时 A的No，Name 不会随之改变
                //因为，A 和 B 都是 NewClass.MemberwiseClone() as ClassClone;来的
                //这个叫做浅表复制，也叫做浅度复制。
                //在单例模式中，两个引用共同指向 同一块内存，所以 造成 “你变我也变的现象”
                //在原型模式中，利用前表复制，开辟一块新的内存，然后把 静态对象的 值类型数据 全部复制一遍，把 引用类型数据 的引用链接复制一遍 ，然后把这些复制全部 放到新的内存中，在进行转换。
                //原型模式 多少有点继承的味道了。
                //另外 性能并不会有太大的损失，就好比在 实例化对象。

                Console.WriteLine($"A.No==B.No?{A.No == B.No}");//false
                Console.WriteLine($"A.Name==B.Name?{A.Name == B.Name}");//false
            }

            //现在 我要说的是，原型模式 是有缺点，有问题的！
            //还记得，我刚才说的吗，原型模式 复制 引用型数据时，复制的是 引用链接！也就可以联想到，单例模式的弊端！
            //又造成了 内存共享的问题！这个时候，深度复制来了！
            {
                ClassCloneC A = ClassCloneC.CreateInstance();
                A.SA.Key = 'A';

                ClassCloneC B = ClassCloneC.CreateInstance();
                B.SA.Key = 'B';

                Console.WriteLine($"A.Key==B.Key?{A.SA.Key == B.SA.Key}");//true!
                //输出结果是 true，证明 原型模式 失败，这个时候 需要 我们在 复制静态对象时 动些手脚。
                /*
                ClassCloneC NewClone = NewClass.MemberwiseClone() as ClassCloneC;
                NewClone.SA = new Sex();
                return NewClone;
                 */
                 //深度复制达成，复制的引用链接 将变成一个全新的对象。

                /*
                浅度复制 就像复制个快捷方式，深度复制 就像复制粘贴文件。
                 */
                 //还有一种 深度复制的方法 就是 序列化。
            }

        }
    }
}
