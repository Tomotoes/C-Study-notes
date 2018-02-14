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

namespace DB断开操作
{
    public partial class DB断开操作 : Form
    {
        public DB断开操作()
        {
            InitializeComponent();
        }
        SqlDataAdapter Ada;
        DataSet Set;
        SqlCommandBuilder CB;
        void Init()
        {
            Ada = new SqlDataAdapter("select * from Info", "server=.;database=Stu;uid=sa;pwd=123456");
            CB = new SqlCommandBuilder(Ada);
            Set = new DataSet();
            Ada.Fill(Set);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Init();
            DataRow R = Set.Tables[0].NewRow();
            R[0] = textBox3.Text;
            R[1] = textBox4.Text;
            R[2] = Convert.ToInt16(textBox5.Text);
            R[3] = textBox6.Text;
            Set.Tables[0].Rows.Add(R);
            textBox1.Text += "增加数据成功\r\n";
            Show();
            End();
        }
        void End()
        {
            Ada.Dispose();
            CB.Dispose();
            Set.Dispose();
        }

        private void DB断开操作_Load(object sender, EventArgs e)
        {
            textBox1.Text += "数据库连接成功\r\n";
        }
        DataRow Find()
        {
           
            for (int i = Set.Tables[0].Rows.Count-1; i >= 0; --i)
            {
                if (Set.Tables[0].Rows[i][0].ToString() == textBox3.Text)
                {
                    return Set.Tables[0].Rows[i];
                }
            }
            
            return null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            Find().Delete();
            textBox1.Text += "删除数据成功\r\n";
            Show();
            End();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Init();
            DataRow R = Find();
            R[1] = textBox4.Text;
            R[2] = Convert.ToInt16(textBox5.Text);
            R[3] = textBox6.Text;
            textBox1.Text += "修改数据成功\r\n";
            Show();
            End();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Init();
            Show();
            End();
        }
        void Show()
        {
            Ada.Update(Set);
            textBox1.Text = "";
            foreach (DataTable table in Set.Tables)
            {
                foreach (DataRow Row in table.Rows)
                {
                    foreach (object Field in Row.ItemArray)
                    {
                        textBox1.Text += Field.ToString() + " ";
                    }
                    textBox1.Text += "\r\n";
                }
            }
        }

        private void DB断开操作_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ada.Dispose();
            CB.Dispose();
            Set.Dispose();
        }
    }
}
