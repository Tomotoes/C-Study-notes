using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Program.Speak();
            Program.Jump();
        }
        static void Speak()
        {
            Console.WriteLine("Speak!");
        }
    }
    partial class Program
    {
        static void Jump()
        {
            Console.WriteLine("Jump!");
        }
    }
    //什么叫分部类，就是把一个类分成多个部分来完成！
}
