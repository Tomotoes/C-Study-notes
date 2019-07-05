using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 最简单的单例模式
    /// </summary>
    public sealed class Singleton
    {
        private Singleton()
        {
            Console.WriteLine("初始化一次");
        }
        //静态变量在第一次使用这个类型时，就会把对象创建出来。
        private static Singleton Instance = new Singleton();
        public static Singleton CreateInstance()
        {
            return Instance;
        }
    }
}
