using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace 线程安全的集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAl = new ArrayList();
            myAl.AddRange(new String[]{"The","quick","brown","fox"});

            ArrayList mySyncdAl = ArrayList.Synchronized(myAl);//记住此包装方法

            Console.WriteLine(myAl.IsSynchronized);//False
            Console.WriteLine(mySyncdAl.IsSynchronized);//True
        }
    }
}
