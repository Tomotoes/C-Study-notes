using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 鞍点
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Max = new int[N];
            int[,] A = new int[N, N];
            for (int i = 0; i < N; ++i)
            {
                int M = 0;
                for (int j = 0; j < N;++j) {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (A[i, j] > M)
                    {
                        M = A[i, j];
                    }
                }
                Max[i] = M;
            }
            int C = 0;
            for(int j=0;j<N;++j){
             int M=10000000;
             for (int i = 0; i < N; ++i)
            {
                if (A[j,i] < M)
                {
                    M = A[j,i];
                }

            }
             if (M == Max[j])
             {
                 C++;
             }

            }
            Console.WriteLine("请输入鞍点的个数：{0}",C);
           
        }
    }
}
