using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("无参函数名");
        }
        public Program(string Q)
        {
            Console.WriteLine("有参函数名"+Q);
        }
        static void Main(string[] args)
        {
            Program A = new Program();
            Program S = new Program("Mj");
        }
    }
}
