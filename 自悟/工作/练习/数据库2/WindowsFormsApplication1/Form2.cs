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
namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        private void Form2_Load(object sender, EventArgs e)
        {
            Bind();
        }

        void Bind()
        {
            if (con.State != ConnectionState.Open )
            {
                con.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                con.Open();
            }
            string str = "select * from studentinfo";

            ////  -1
            //SqlCommand com = new SqlCommand(str, con);

            //SqlDataAdapter ada = new SqlDataAdapter();
            //ada.SelectCommand = com;

            //DataSet dst = new DataSet();
            //ada.Fill(dst,"stu");

            //dataGridView1.DataSource = dst.Tables["stu"];   //绑定

            //-2

            SqlDataAdapter ada = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);  //填充之后，Datatable对象和物理上数据库的结构完全相同
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "学号";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSex.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            dateTimePicker1.Value =Convert.ToDateTime( dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());

            txtPro.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtAddres.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtColle.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtClass.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "update studentinfo set SSex=@SSex,SAge=@SAge,SBirthDate=@SBirthDate,SMajor=@SMajor,SAddress=@SAddress,STel=@STel,SCollege=@SCollege,SClass=@SClass where SNo=@SNo";
            SqlCommand com = new SqlCommand(str, con);

            //为参数进行赋值
            com.Parameters.AddWithValue("@SNo", txtSno.Text);
            com.Parameters.AddWithValue("@SSex", txtSex.Text);
            com.Parameters.AddWithValue("@SAge", txtAge.Text);
            com.Parameters.AddWithValue("@SBirthDate", dateTimePicker1.Value.ToString());
            com.Parameters.AddWithValue("@SMajor", txtPro.Text);
            com.Parameters.AddWithValue("@SAddress", txtAddres.Text);
            com.Parameters.AddWithValue("@STel", txtTel.Text);
            com.Parameters.AddWithValue("@SCollege", txtColle.Text);
            com.Parameters.AddWithValue("@SClass", txtClass.Text);

            com.ExecuteNonQuery();
            Bind();
        }
    }
}
