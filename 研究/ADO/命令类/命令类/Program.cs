using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace 命令类
{
    class Program
    {
        static SqlDependency dependency;
        private static void Update(string conn)
        {
            using ( SqlConnection connection = new SqlConnection(conn))
            {
                //此处 要注意 不能使用*  表名要加[dbo]  否则会出现一直调用执行 OnChange
                string sql = "select agent from [dbo].[info]";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                   
                    dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);
                   
                    //必须要执行一下command
                    command.ExecuteNonQuery();

                    Console.WriteLine(dependency.HasChanges);
                }
            }
        }


        //update insert delete都会进入
        private static void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            Console.WriteLine("onchange方法中：" + dependency.HasChanges);
            Console.WriteLine("数据库数据发生变化时刻：" + DateTime.Now);
            
            //这里要再次调用
            Update("数据库连接串");
        }
    }
}
