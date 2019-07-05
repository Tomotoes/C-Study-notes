using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static public bool Cmp(char[]Q)
        {
            int L = Q.Length;
            for (int i = 0; i < L; ++i)
            {
                if (Q[i] < '0' || Q[i] > '9')
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string V = Console.ReadLine();
            char[] Q = V.ToCharArray();
            Array.Sort(Q);
            if (Cmp(Q)){
                Console.WriteLine(Q);
            }
                
            else
            {
                //事实证明，数组名的方法 没有 数组的方法好用，因为 在调用后 数组名的方法 还要定义变量接收
                Q.Reverse();
                //Array.Reverse(Q);
                //Q = (Q.Reverse()).ToArray();
                Console.WriteLine(Q);
            }
        }
    }
}
