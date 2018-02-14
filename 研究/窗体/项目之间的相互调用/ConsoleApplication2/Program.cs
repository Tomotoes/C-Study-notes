using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program:ConsoleApplication1.Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASD");
            ConsoleApplication1.Program A = new ConsoleApplication1.Program();
            A.Speak();

            Program B = new Program();
            B.Speak();

            /*
             * 如何使用项目之间的相互调用？
             * 
             * 在项目的选项中 找到引用选项，然后右键 添加引用，找到解决方案ConsoleApplication1，然后点勾，点击添加，就可以了！在使用的时候 ，我们也不必写出 using ConsoleApplication1;
             * 但是值得注意的是，使用ConsoleApplication1中的东西时，必须把访问级别降低才行。
             * 
             */
        }
    }
}
