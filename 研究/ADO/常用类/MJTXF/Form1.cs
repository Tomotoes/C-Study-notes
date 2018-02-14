using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace MJTXF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("data source=.;database=Student;integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            
            /*事实证明 用windows用户方式连接数据库 没有那么难
                1.数据来源 要为本地
                2.验证方式的属性值为true
                3.老哥 我误会了 原来 database 是一个数据库的名字。。。
             */
            Con.Open();
            if (Con.State == ConnectionState.Open)
            {
                textBox1.Text += "已经连接上数据库";
            }
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand Com=new SqlCommand("select * from StudentInfo",Con);
            SqlCommand Com2 = new SqlCommand("delete from StudentInfo where SNo='2012200290'",Con);
            Con.Open();
            Com2.ExecuteNonQuery();
            //果真没了 另外 还发现 SqlCommand 没有Close方法
            Con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            SqlDataReader Read = new SqlDataReader();//构造函数只有一个重载
                你能信，SqlDataReadr类 居然 没有构造函数 连 实例化 的事情 都做不了
            */
            SqlCommand Com3 = new SqlCommand("select * from StudentInfo", Con);
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            //看见Command类的ExecuteReader方法的类型 是SqlCommand
            SqlDataReader Reader = Com3.ExecuteReader();
            //用DataRead类的实例 接收！这时候 会产生问题 如果命令不是查询呢。
            //那我告诉你 只有查询命令才会返回这一堆数据！
            
            //如果你想返回单一的值 请用Com3.ExecuteScalar 就比如 Count，Min这类的命令
            if (Reader.HasRows)
            {
                textBox1.Text += "查询到记录";
            }
           
            /*
             * 好吧 对于DataReader 先把唐大仕教授的话 摘抄一下：
             * 使用 Command来获取 DataReader
             * 使用 Command来获取一个数据
             * 直接使用数据库命令
             * 
             * 其对象 有Read方法 每调用一次 就会走到下一行的数据
            */
            
            while (Reader.Read())
            {
                
                //第一种输出数据的方式 ： 依靠DataReader的Get方法
                textBox1.Text += "\r\n ";
                //学号
                textBox1.Text += Reader.GetInt64(0);
                //姓名
                textBox1.Text += ' '+string.Format("{0}", Reader.GetString(1)) + ' ';
                //性别
                textBox1.Text += string.Format("{0}", Reader.GetString(2)) + ' ';
                
                //第二种输出数据的方式：依靠表中的列名，让其列名成为Reader的索引
                //其实我们可以理解为 Reader得到SqlCommand命令，并且是查询命令

                //第一种索引 以列名 作为索引
                //年龄
                textBox1.Text += Reader["SAge"].ToString() + ' ';
                //班级
                textBox1.Text += Reader["SClass"].ToString() + ' ';
               
                //第二种索引 以下标 作为索引
                //出生日期
                textBox1.Text += Reader[4].ToString() + ' ';
                //专业
                textBox1.Text += Reader[5].ToString() + ' ';
            }
            //在这里要说一下 ，
            //执行完这个循环 Reader的Read方法 已经到了没有数据可以读取的位置了
            //所以 嘿嘿 你懂的

            /*
             * 介绍下 Command的 三大方法
             
             * * 1.Com2.ExecuteNonQuery(); 可以理解为执行步奏
             *   执行Sql语句或存储过程指定操作，通常不返回数据集的操作
             *   比如Update，Insert，Delete
             *   返回被影响的数据记录的条数
             *   
             * 2.Com3.ExecuteReader();
             * 执行Sql语句或存储过程指定的查询操作，比如Select语句 
             * 返回只向前的数据的读取器。
             * 
             * 3.Com3.ExecuteScalar
             * 执行一个查询操作，并返回查询所返回的结果集中第一行的一列的数据，
             * 忽略其他列或行

            */
            Reader.Close();//必须先关闭 ，不然如下

            Com3.CommandText = "select count(*) from StudentInfo where SSex='男'";
            //其中数据库命令 中的变量 必须 用单引号 括起来！

            int Count = (int)Com3.ExecuteScalar();//强制转换为 int 在我们确定其类型的前提下
            MessageBox.Show(Count.ToString());

           // Reader.Close();//已有打开的与此 Command 相关联的DataReader，必须首先将它关闭

            Com3.CommandText = "delete from StudentInfo where SNo='2012200291'";
            int Del = Com3.ExecuteNonQuery();//返回被影响的行数 其值为 int型，增删改的操作
            MessageBox.Show(Del.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             * DataAdapter对象是DataSet对象和数据源之间联系的桥梁，
             * 主要功能是从数据源中检索数据，填充DataSet对象中的表
             * 把用户对DataSet对象做出的更改写入到数据源。
             */

            /*
             * 先来书上说的一段话 说得特别好
             * 许多数据操作要求用户只是读取一串数据。
             * DataReader对象允许用户获得从Command对象的Select语句得到的结果。
             * 考虑性能的因素，从DataReader返回的数据都是快速的且是“向前”的数据流。
             * 这意味着用户只能按照一定的顺序从数据流中取出数据。这对于速度来说 是有好处的，
             * 但是用户需要操作数据，更好的办法是使用DataSet
             */

            /*
             * DataAdapter 和 DataSet
             * 1.使用 DataAdapter 来填充DataSet
             * 2.取得DataSet中的数据
             * 3.修改DataSet中的数据
             * 4.添加和删除行
             * 5.在DataTable中查找数据
             * 6.接受和拒绝更改
             * 7.保存堆DataSet的改变并返回数据库
            */
          
            
            
            /*
             * SqlCommandBuilder CB = new SqlCommandBuilder(new SqlDataAdapter());
             * 其注释：自动生成单表命令 ，用于将DataSet所做的更改与关联的 SQLServer数据库的更改更协调
             *  
             * 说下 我对其类的认识 更新数据源 就是 更改数据库 必须用到 它，
             * 它 一直是默默无闻的 ，从不显示自己  但没有它不行！它工作于内部。
             * 实际上没有用到 其实是在 内部建立相关的命令
             * 省略的情况：只查询数据 不更新数据
             */

            //DataSet A = new DataSet();
            //发现了没有 DataSet居然不用加前缀！

            /*
             * DataSet及相关对象
             * 1.DataSet
             * 2.DataTable    代表 创建在DataSet中的表
             * 3.DataRow      代表DataTable中的记录
             * 4.DataColumn   代表有列有关的信息，包括列的名称，类型和属性
             * 5.DataRelation 代表 两个表之间的关系。关系建立在具有相同数据类型的列上，但列不必有相同的精确度
             * 约束
             * 除了以上对象以外，DataSet中还有几个集合对象：包含DataTable对象的集合Tables
             * 和包含了DataRelation对象的集合 Relations
             * 另外 DataTable对象还包括行的集合 Rows  列的集合Columns
             * 和数据关系的集合 ChildRelations 和 ParentRelations
             * 
             * 有一张图片叫做：DataSet对象模型 然后 你就会发现 DataSet那些成员 不就是个 典型的数据库嘛。
             */

            /*
             * ADO.NET 和 XML
             * DataSet可以直接的串列化为XML，同时 XML也可以直接的反串列化为DataSet对象
             * 1.ReadXml()方法
             * 2.WriteXml()方法
             * SqlCommand.ExecuteXmlReader() 返回一个XmlReader对象
             */
            

            //下面是创建 SqlDataAdapter对象的两种方式 
          //  SqlDataAdapter DA = new SqlDataAdapter("select * from StudentInfo", Con);
            SqlDataAdapter DA = new SqlDataAdapter("select * from StudentInfo order by SAge", "data source=.;database=Student;integrated security=true");
            //看来 SqlDataAdapter可以完全独立。
           
            //SqlCommand CM = new SqlCommand();
            //CM.CommandText = "select * from StudentInfo";
            //CM.Connection = Con;
            //SqlDataAdapter DA = new SqlDataAdapter();
            //DA.SelectCommand = CM;
            
            //if (Con.State == ConnectionState.Closed)
            //{
            //    Con.Open();
            //}
            //填充数据
            DataSet Set = new DataSet();
            DA.Fill(Set,"Mj");//5个重载 每个重载都很有趣
            //其中 Mj 是表的名字 我们下面用 Tables[0]  也可以用 Tables["Mj"]

            
            //访问数据
            foreach (DataTable table in Set.Tables)//1张表
            {
                foreach (DataRow row in table.Rows)//表中有51个成员 正好有51行！
                {
                    foreach (object field in row.ItemArray)//此object类型 可以匹配所有的类型,10个字段
                    {
                        //textBox1.Text += field.ToString()+"\r\n";
                    }
                }
            }
         

            MessageBox.Show(Set.Tables[0].Rows[2].ItemArray[0].ToString());
            //解析一下，其中Set不用多说 Tables便是 StudentInfo（查询的表），而Rows是表中的行（51个成员，所以51行）
            //而ItemArray 是每一行的字段 就是数据库的列（比如 学号 姓名之类）
            //所以说，Set.表[n].成员[n].列[n]

            MessageBox.Show(Set.Tables[0].Rows[0][1].ToString());
            //我们只解析 Rows[n][m] 现在 你可以打开SQL 查看一个表 然后查询出来 仔细盯，然后行列就全对了，没了。

            MessageBox.Show(Set.Tables["Mj"].Rows[1]["SName"].ToString());

            //在表中查询数据
            DataRow[]Rows = Set.Tables[0].Select("SAge='17'");//注意查询字符串的格式
            foreach (DataRow Row in Rows)
            {
                foreach (object F in Row.ItemArray)
                {
                    textBox1.Text += F.ToString() + "\r\n";
                }
            }
            for (int i = 0; i < Rows.Length; ++i)
            {
                textBox1.Text += Rows[i][1].ToString() + "\r\n";
            }

            //接下来 介绍一下 修改数据
            //1.直接在表中暴力更改
            SqlCommandBuilder CB = new SqlCommandBuilder(DA);
            Set.Tables[0].Rows[0][1] = "马进";
            if (Set.HasChanges() == true)
            {
                DA.Update(Set, "Mj");//必须和上面 填充的形式一模一样
                Set.AcceptChanges();//记住 此顺序 先请求更新 在接受改变！
                MessageBox.Show("已经更变数据");
            }

            //2.在内存中更改数据
            DataRow D = Set.Tables[0].Rows[0];
            D.BeginEdit();
            D[0] = 1755811882;
            D[1] = "西蒙";
            D[2] = "男";
            D[3] = 18;
            D[4] = 1997;
            D[5] = "软件技术";
            D[6] = "河北秦皇岛";
            D[7] = null;
            D[8] = "CCUT";
            D[9] = "31616";
            D.EndEdit();
            D.AcceptChanges();
         //   DA.Update(Set, "Mj");//必须和上面 填充的形式一模一样
         //   Set.AcceptChanges();//记住 此顺序 先请求更新 在接受改变！
            MessageBox.Show(Set.Tables[0].Rows[0][1].ToString());
            //真的只是在内存中修改了数据 在数据中不会进行改变 也就是说 上面的两行代码 没什么实质作用

            //Set.Tables[0].RejectChanges(); //取消改变，回滚
            //Set.Tables[0].Reset();//初始化
           
            //修改 查找说完了 下面说下 增加
            DataRow R = Set.Tables[0].NewRow();//注意选择在哪个表中！
            R[0] = 175581188274546546;//不知道为什么学号设置不了 应该是数据库的问题
            R[1] = "西蒙";
            R[2] = "男";
            R[3] = 18;
            R[4] = 1997;
            R[5] = "软件技术";
            R[6] = "河北秦皇岛";
            R[7] = null;
            R[8] = "CCUT";
            R[9] = "31616";
            Set.Tables[0].Rows.Add(R);
            //Set.Tables[0].Rows.InsertAt(R, 5);
            //Set.Tables[0].Rows.RemoveAt(5);
              DA.Update(Set, "Mj");//别忘了下面两行
              Set.AcceptChanges();
             
              SqlDataAdapter Ac = new SqlDataAdapter("select * from StudentInfo", "data source=.;database=Student;integrated security=true");
              SqlCommandBuilder B = new SqlCommandBuilder(Ac);
              DataSet AC = new DataSet();
              Ac.Fill(AC);
              for (int i = AC.Tables[0].Rows.Count - 1; i >= 0; --i)
              {
                  if (AC.Tables[0].Rows[i]["SName"].ToString() == "马进")
                  {
                      AC.Tables[0].Rows[i].Delete();
                  }
              }
              Ac.Update(AC);
              AC.AcceptChanges();
            //现在用此代码 成功删除！


          ////  Set.Tables[0].Rows.RemoveAt(50);
             // DA.Update(Set, "Mj");//别忘了下面两行
             // Set.AcceptChanges();

            //Ok,在这里卡了近一个小时，怎么删除都删除不了！！！Simon , I hate you .
        }
    }
}
