using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int [][] A= new int [N][];
            
            for (int i = 0; i < N; ++i)
            {
                A[i] = new int[i + 1];
                A[i][0] = 1;
                A[i][i] = 1;
            }
            for (int i = 2; i < N; ++i)
            {
                for (int j = 1; j < i; ++j)
                {
                    A[i][j] = A[i - 1][j] + A[i - 1][j - 1];
                }
            }
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Console.Write(A[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
