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

namespace DB基本操作
{
    public partial class DB基本操作 : Form
    {
        public DB基本操作()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("server=.;database=student;uid=sa;pwd=123456");
        SqlCommand Com=new SqlCommand();
        private void Form1_Load(object sender, EventArgs e)
        {
            Con.Open();
            if (Con.State == ConnectionState.Open)
            {
                textBox6.Text += "数据库连接成功!" + "\r\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Com = new SqlCommand("insert into student (sno,sname,ssex,sage,sdept) values (" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ")", Con);
                if (Com.ExecuteNonQuery() > 0)
                {
                    textBox6.Text += "增加成功!" + "\r\n";
                }
            }
            catch (SqlException A)
            {
                MessageBox.Show(A.Message);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Con.Close();
            Com.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Com = new SqlCommand("delete from student where sno="+textBox1.Text+"", Con);
                if (Com.ExecuteNonQuery() >0)
                {
                    textBox6.Text += "删除成功!" + "\r\n";
                }
            }
            catch (SqlException A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Com.CommandText = "select count(sno) from student where sno=" + textBox1.Text + "";
                Com.Connection = Con;
                if ((int)Com.ExecuteScalar() == 0)
                {
                    MessageBox.Show("没有找到！");
                }
                else
                {
                    Com.CommandText="update student set sname="+textBox2.Text+",ssex="+textBox3.Text+",sage="+textBox4.Text+",sdept="+textBox5.Text+"where sno="+textBox1.Text+"";
                    if (Com.ExecuteNonQuery() >0)
                    {
                    textBox6.Text += "修改成功!" + "\r\n";
                    }

                }
            }
            catch (SqlException A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader Reader = new SqlCommand("select * from student ", Con).ExecuteReader();
                string OutPut = "";
                while (Reader.Read())
                {
                    try
                    {
                        for (int i = 0; ; ++i)
                        {
                            OutPut += Reader[i].ToString() + ' ';
                        }
                    }
                    catch
                    {
                        OutPut += "\r\n\r\n";
                    }
                    
                }
                MessageBox.Show(OutPut);
                Reader.Close();
            }
            catch (SqlException A)
            {
                MessageBox.Show(A.Message);
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("嘿嘿");
        }
    }
}
