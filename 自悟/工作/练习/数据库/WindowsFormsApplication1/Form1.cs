using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            con.Open();
            if(con.State==ConnectionState.Open )
            {
                this.Text = "open";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //第一种无参构造函数，为Command对象的三个属性分别赋值
            //字符串的拼接

            string str = "insert into StudentInfo values('" + txtName.Text + "','" + txtSex.Text + "'," + txtAge.Text + ",'" + dateTimePicker1.Value + "','" + txtPro.Text + "','" + txtAddres.Text + "','" + txtTel.Text + "','" + txtColle.Text + "','"+txtClass.Text+"')";
            SqlCommand com = new SqlCommand();
            com.CommandText = str;
            com.Connection = con;
            com.CommandType = CommandType.Text;  //要执行的是SQL语句 ,默认值
            //com.CommandType = CommandType.StoredProcedure;   //要执行的是存储过程

            com.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "update studentinfo set SAge=" + txtAge.Text + ",ssex='" + txtSex.Text + "' where sname='" + txtName.Text + "'";
            SqlCommand com = new SqlCommand(str);
            com.Connection = con;
            com.CommandType = CommandType.Text;  //要执行的是SQL语句 ,默认值
            com.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "delete from studentinfo where sname='"+txtName.Text+"'";
            SqlCommand com = new SqlCommand(str, con);
            int i = com.ExecuteNonQuery();
            MessageBox.Show(i.ToString ());
        }
    }
}
