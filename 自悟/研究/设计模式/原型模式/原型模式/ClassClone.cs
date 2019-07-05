using System;

namespace 原型模式
{
    class ClassClone
    {
        public ClassClone()
        {
            Console.WriteLine($"正在执行{this.GetType().Name}的构造函数");
        }

        public int No { get; set; }

        public string Name { get; set; }

        static public ClassClone NewClass = new ClassClone();//在第一次执行 ClassSingle时，就会创建该静态对象
        static public ClassClone CreateInstance()
        {
            ClassClone NewClone = NewClass.MemberwiseClone() as ClassClone;
            //NewClone.No = 1;
            NewClone.No = 1;
            return NewClone;
        }
    }
}
