using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 原型模式
{
    class ClassCloneC
    {
        public ClassCloneC()
        {
            WriteLine($"正在执行{GetType().Name}的构造函数");
        }
        public int No { get; set; }
        public string Name { get; set; }

        public Sex SA { get; set; } = new Sex();

        static public ClassCloneC NewClass = new ClassCloneC();//在第一次执行 ClassSingle时，就会创建该静态对象
        static public ClassCloneC CreateInstance()
        {
            ClassCloneC NewClone = NewClass.MemberwiseClone() as ClassCloneC;
            NewClone.SA = new Sex();
            return NewClone;
        }
    }
    public class Sex
    {
        public char Key { get; set; }
    }
}
