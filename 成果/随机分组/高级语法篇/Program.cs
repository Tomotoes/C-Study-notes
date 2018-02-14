using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace 高级语法篇
{
    class MyClass1
    {
        Random A = new Random();
        bool[] C = new bool[9];
        string[] M = new string[9];
        static void Main(string[] args)
        {
            MyClass1 I = new MyClass1();
            I.M[0] = "王文杰";
            I.M[1] = "魏岩";
            I.M[2] = "梁寅航";
            I.M[3] = "刘洁";
            I.M[4] = "张召";
            I.M[5] = "康瑞";
            I.M[6] = "马进";
            I.M[7] = "周盛";
            I.M[8] = "朱东海";
            int i = 0;
            while (i<9)
            {
                int Temp = I.A.Next(9);
                if (!I.C[Temp])
                {
                    I.C[Temp] = true;
                    Console.Write(I.M[Temp]+' ');
                    i++;
                    if (i % 3 == 0) { Console.WriteLine(); }
                }
            }
        }
       
    }
}
