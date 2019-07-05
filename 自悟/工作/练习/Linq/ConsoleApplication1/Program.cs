using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace ConsoleApplication1
{
    class Program
    {
        static List<Student> listStu = new List<Student>();
        static void GenerateInitStuList()
        {
            //模拟从数据中取数据的过程
            listStu.Add(new Student() {  SNO="0001", SName="aaa", SAge=20, SSex="F", SProfession="软件技术" });
            listStu.Add(new Student() { SNO = "0002", SName = "bbb", SAge = 21, SSex = "M", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0003", SName = "ccc", SAge = 22, SSex = "F", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0004", SName = "ddd", SAge = 19, SSex = "M", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0005", SName = "eee", SAge = 20, SSex = "F", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0006", SName = "fff", SAge = 21, SSex = "M", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0007", SName = "ggg", SAge = 20, SSex = "F", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0008", SName = "hhh", SAge = 22, SSex = "F", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0009", SName = "iii", SAge = 20, SSex = "M", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0010", SName = "jjj", SAge = 22, SSex = "F", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0011", SName = "kkk", SAge = 20, SSex = "M", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0012", SName = "lll", SAge = 22, SSex = "M", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0013", SName = "mmm", SAge = 21, SSex = "M", SProfession = "软件技术" });
            listStu.Add(new Student() { SNO = "0014", SName = "nnn", SAge = 20, SSex = "F", SProfession = "计算机应用技术" });
            listStu.Add(new Student() { SNO = "0015", SName = "ppp", SAge = 19, SSex = "F", SProfession = "软件技术" });
        }
        static void Main(string[] args)
        {
            GenerateInitStuList();
            //匿名类型，根据=右侧运行时的类型，推断变量具体的类型
            //var v = listStu;
            //var v1 = 2;
            //var v2 = "sdf";

            //LINQ ：一种从数据源中查询数据的技术
            //LINQ使用时有两种办法，第一种查询字句，第二种查询函数

            //第一种查询字句的方式，这种方式要求以select字句或者以group by字句为结尾
            //1、查询数据源中全部信息
            //var v = (from m in listStu
            //        select m).ToList();
            //2、带有条件的查询
            //var v=(from m in listStu
            //       where m.SAge<20
            //       select m).ToList ();

            //var v = (from m in listStu
            //         orderby m.SAge descending
            //         select m).ToList();

            //var v=(from m in listStu
            //       group m by m.SProfession=="软件技术"
            //       ).ToList();


            //select sno as 学号, sname as 姓名 from 表 where
            //var v = (from m in listStu
            //         where m.SProfession == "软件技术"
            //         select new { 学号 = m.SNO, 姓名 = m.SName }).ToList();
            //foreach(var temp in v)
            //{
            //    Console.WriteLine("{0},{1}",temp.学号,temp.姓名);
            //}




            foreach (var temp in v)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", temp.SNO, temp.SName, temp.SAge, temp.SProfession, temp.SSex);
            }


            Console.ReadKey();

        }
    }
}
