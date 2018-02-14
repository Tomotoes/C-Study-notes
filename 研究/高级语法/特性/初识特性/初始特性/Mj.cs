using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初始特性
{
    public class MjAttribute:Attribute
    {
        public string Liulin { get; set; }
        public MjAttribute(string A)
        {
            Console.WriteLine("AA");
        }
        public  void Jump()
        {
            Console.WriteLine("Jumping!");
        }
    }

    //两个花括号-扩展方法

    public class LiulinAtt : Attribute
    {

    }
}
