using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 封装数据库访问类_反射_配置文件_ADO_模型类_
{
    class Program
    {
        static void Main(string[] args)
        {
            Information MODEL = SqlDataBaseVisit.GetValueFromDB<Information>("001");
            Console.WriteLine(MODEL.Name);
        }
    }
}
