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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlDataAdapter Ada;
        SqlCommandBuilder CB;
        DataSet Set;
        BindingManagerBase B;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Ada = new SqlDataAdapter("select * from Information", "server=.;database=StudentPlus;integrated security=true");
                Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                CB = new SqlCommandBuilder(Ada);
                Set = new DataSet();
                Ada.Fill(Set);
                dataGridView1.DataSource = Set.Tables[0];
                
                B = this.BindingContext[Set]; //注意此方法 用来绑定 BindingManageerBase 导航的内容
            }
            catch { MessageBox.Show("数据库连接失败！请检查您的数据库！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); System.Environment.Exit(0); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            B.Position = 0;//现在的位置

            int i = B.Count;//B.Count 用来获取 Set中 信息 的总个数
            this.textBox1.Text = Set.Tables[0].Rows[B.Position][0].ToString();

            if (++B.Position == B.Count)
            {
                B.Position = 0;
            }
            if (--B.Position < 0)
            {
                B.Position = B.Count - 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
