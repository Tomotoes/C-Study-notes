using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 再续类型
{
    class DataClass
    {
        public int Year;
        public int Month;
        public int Day;
        public DataClass(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public void AddDay()
        {
            Day++;
        }
        public void ShowData()
        {
            Console.WriteLine(Year+"-"+Month+"-"+Day);
        }
    }
    struct DataStruct
    {
        public int Year;
        public int Month;
        public int Day;
        public DataStruct(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public void AddDay()
        {
            Day++;
        }
        public void ShowData()
        {
            Console.WriteLine(Year + "-" + Month + "-" + Day);
        }
        static void Main(string[] args)
        {
            //引用类型 存储在堆里面，默认值为 null ； 当复制时，只会复制引用
            DataClass A, B;
            A = new DataClass(2017, 5, 1);
            B = A;
            A.AddDay();//可以理解为 对象 A 和 对象 B 共同指向了一块地址，其地址上面的权值为 2017 5 1
            //所以无论 是 A自加 还是 B自加     A和B 的值 永远是关联在一起的，永远是一样的
            A.ShowData();
            B.ShowData();
           
            //值类型 存储在栈里面，默认值为 0 ；当复制时，全部复制，复制一切
            //值类型是相互独立的
            DataStruct C, D;
            C = new DataStruct(2017, 5, 1);
            D = C;
            C.AddDay();
            C.ShowData();
            D.ShowData();
        }
    }
}
