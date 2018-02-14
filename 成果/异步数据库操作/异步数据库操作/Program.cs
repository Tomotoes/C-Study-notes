using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace 异步数据库操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDoSQL();  如果是直接调用方法，会有警告出现

            //var Result = ToDoSQL();
            //Result.GetAwaiter().GetResult();

            ToDoSQL().GetAwaiter().GetResult();

        }
        async public static Task ToDoSQL()
        {
            string ConString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            Console.WriteLine(ConString);

            try
            {
                using (SqlConnection Con = new SqlConnection(ConString))
                {
                    await Con.OpenAsync();//记住 现在异步线程的主流便是如此， 
                    //在 async Task Method(){await AsyncMethod();}
                    if (Con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("数据库连接成功");
                    }
                    SqlCommand Com = new SqlCommand("select * from Info", Con);
                    SqlDataReader Red = await Com.ExecuteReaderAsync();

                    if (Red.HasRows)
                    {
                        Console.WriteLine("查询成功！学号公布如下：");

                        while (await Red.ReadAsync())
                        {
                            Console.WriteLine(Red["No"]);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
