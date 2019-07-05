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

namespace ADO课堂练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("server=.;database=Student;integrated security=true");
        SqlCommand Com;
      

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            Com=new SqlCommand("Select * from Information",Con);
            SqlDataReader Reader = Com.ExecuteReader();
            while (Reader.Read())
            {
                textBox1.Text += Reader[0] + " " + Reader.GetString(1) + " " + Reader["Age"] + "\r\n";
            }
            
            Con.Close();
            Reader.Dispose();
            Com.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

            Com.CommandType=CommandType.StoredProcedure;//类型指定 存储过程的类型
            Com.CommandText = "Stu";//查询命令为 存储过程的名字
            Com.Connection = Con;

            SqlParameter No = new SqlParameter("@No", SqlDbType.TinyInt);
            No.Value = 15;

            SqlParameter Name = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            Name.Value = "小E";

            SqlParameter Age = new SqlParameter("@Age", SqlDbType.SmallInt);
            Age.Value = 7;
            
            Com.Parameters.Add(No);
            Com.Parameters.Add(Name);
            Com.Parameters.Add(Age);

            Com.ExecuteNonQuery();

            Con.Close();
            Com.Dispose();
        }
    }
}
