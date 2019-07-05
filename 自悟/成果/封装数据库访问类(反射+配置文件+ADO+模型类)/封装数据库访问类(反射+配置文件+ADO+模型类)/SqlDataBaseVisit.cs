using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace 封装数据库访问类_反射_配置文件_ADO_模型类_
{
    class SqlDataBaseVisit
    {
        private static string ConnectionStringSQL = ConfigurationManager.ConnectionStrings["Customers"].ConnectionString;

        /// <summary>
        /// FillColumns
        /// </summary>
        /// <typeparam name="T">NewModel</typeparam>
        /// <param name="NoTEXT">No</param>
        /// <returns>FilledModel</returns>
        static public T GetValueFromDB<T>(string NoTEXT)
        {
            Type ModelType = typeof(T);
            T FillModel = (T)Activator.CreateInstance(ModelType);

            /*
            * SELECT [No],[Name],[Sex] FROM [StudentPlus].[dbo].[Information] WHERE No=001
            */
            string ColumnsTEXT = string.Join(",", ModelType.GetProperties().Select(p => string.Format("[{0}]", p.Name)));//p.Name!!差点造成大错！->[No],[Name],[Sex]
            string CommandTEXT = string.Format("SELECT {0} FROM [{1}] WHERE No = {2};", ColumnsTEXT, ModelType.Name, NoTEXT);
            //.Select :将序列中的每个元素投影到新表中，起到加工的作用
            
            using (SqlConnection Con = new SqlConnection(ConnectionStringSQL))
            {
                SqlCommand Com = new SqlCommand(CommandTEXT, Con);
                Con.Open();

                SqlDataReader Reader = Com.ExecuteReader(CommandBehavior.CloseConnection);//查询完之后直接关闭连接

                if (Reader.Read())
                {
                    foreach (var prop in ModelType.GetProperties())
                    {
                        prop.SetValue(FillModel, Reader[prop.Name]);
                        //关键的步骤，把FillModel的每一个字段设置上各自的值，值的来源都是 Reader中的值，我们不可以忘掉Reader根据索引的读取方式，并且我们还要知道 模型类的每个字段对应着数据库中的列名
                    }

                    return FillModel;
                }
            }

            return default(T);
        }
    }
}
