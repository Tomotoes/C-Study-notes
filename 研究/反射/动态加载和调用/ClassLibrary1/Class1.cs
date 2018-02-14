using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace ClassLibrary1
{
    public class Class1:Interface3
    {
        public Class1()
        {
            Console.WriteLine("这是{0}的无参构造函数",this.GetType().FullName);
        }
        public string Name { get; set; }
        public void Jump()
        {
            Console.WriteLine("Jumping!");
        }
    }
}
