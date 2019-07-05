using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataAdapter Ada = new SqlDataAdapter("select * from Info", "server=.;database=Stu;integrated security=true");
            SqlCommandBuilder CB = new SqlCommandBuilder(Ada);
            Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;//设置主键
            //hahaha 原来是写在 填充数据库的前面，
            DataSet Set = new DataSet();
            Ada.Fill(Set);
           
            Set.Tables[0].Rows.Find("002       ").Delete();
            
            //for (int i = Set.Tables[0].Rows.Count - 1; i >= 0; --i)
            //{
            //    if (Set.Tables[0].Rows[i][0].ToString() == "004       ")
            //    {
            //        Set.Tables[0].Rows[i].Delete();
            //        break;
            //    }
            //}
            
            Ada.Update(Set);

            foreach (DataTable table in Set.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object Field in row.ItemArray)
                    {
                        Console.Write(Field);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
