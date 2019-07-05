using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 学生Score
{
    class Program
    {
         public  struct Student
        {
            public int No;
            public double Math;
            public double English;
            public double Yuwen;
            public double Sum;
            public double Avg;
        };
       
        static void Main(string[] args)
        {
            Student[] Stu = new Student[1000];
            Console.Write("请输入学生总数：");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= N; ++i)
            {
                Console.Write("请输入第" + (i.ToString()) + "学生学号：") ;
                Stu[i].No = Convert.ToInt32(Console.ReadLine());
                Console.Write("请输入该生的数学成绩:");
                Stu[i].Math = Convert.ToDouble(Console.ReadLine());
                Console.Write("请输入该生的语文成绩:");
                Stu[i].Yuwen = Convert.ToDouble(Console.ReadLine());
                Console.Write("请输入该生的英语成绩:");
                Stu[i].English = Convert.ToDouble(Console.ReadLine());
                Stu[i].Sum = Stu[i].Yuwen + Stu[i].Math + Stu[i].English;
                Stu[i].Avg = Stu[i].Sum / 3.0;
                Console.WriteLine();
            }
            for (int i = 2; i <= N; ++i)
            {
                for (int j = 1; j < i; ++j)
                {
                    if (Stu[i].Sum > Stu[j].Sum)
                    {
                        Student Temp;
                        Temp = Stu[i];
                        Stu[i] = Stu[j];
                        Stu[j] = Temp;
                    }
                }
            }
            Console.WriteLine("学号    数学     语文    英语    平均    总分");
            for (int i = 1; i <= N; ++i)
            {
                Console.WriteLine("{0,-8}{1,-8:f1}{2,-8:f1}{3,-8:f1}{4,-8:f1}{5,-8:f1}", Stu[i].No, Stu[i].Math, Stu[i].Yuwen, Stu[i].English, Stu[i].Avg, Stu[i].Sum);
            }
        }
    }
}
