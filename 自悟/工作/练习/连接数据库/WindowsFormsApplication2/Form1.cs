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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection A = new SqlConnection();
                A.ConnectionString = "server=.;uid=sa;pwd=123456;";
                A.Open();
                if (A.State == ConnectionState.Open)
                {
                    MessageBox.Show("已经连接上了");
                }
                A.Close();
            }
            catch { MessageBox.Show("连接失败"); }

        }
    }
}
