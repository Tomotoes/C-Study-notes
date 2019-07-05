using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 集合6._0新特性
{
    class Program
    {
        public Dictionary<string, int> OldMethod()
        {
            Dictionary<string, int> student = new Dictionary<string, int>();
            student.Add("张三", 25);
            student.Add("李四", 26);
            student.Add("王五", 27);
            return student;
        }

        public Dictionary<string, int> NewMethod()
        {
            Dictionary<string, int> student = new Dictionary<string, int>()
            {
                ["张三"] = 25,
                ["李四"] = 26,
                ["王五"] = 27,
            };
            
            return student;
        }

        static void Main(string[] args)
        {

        }
    }
}
