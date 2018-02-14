using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数传递
{
    class Program
    {
        public int Q;
        static void Main(string[] args)
        {
            int E = 0;
            Add(E);
            Console.WriteLine(E);

            int[] R = new int[5];
            Add(R[1]);
            Console.WriteLine(R[1]);

            Add(R);
            Console.WriteLine(R[1]);

            Program P = new Program();
            Add(ref P);
            Console.WriteLine(P.Q);
        }
        static public void Add(int i)
        {
            ++i;
        }
        static public void Add(int [] S)
        {
            S[1]++;
            S = new int[5];
        }
        static public void Add(ref Program P)
        {
            P.Q++;
            P = new Program();
        }
    }
}
