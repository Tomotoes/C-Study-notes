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
using System.IO;

namespace PictureDB操作
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
        void Read()
        {
            dataGridView1.Font = new System.Drawing.Font("宋体", 12);
            dataGridView1.DataSource = Set.Tables[0].DefaultView;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ada = new SqlDataAdapter("select * from Information", "server=.;database=StudentPlus;Integrated Security=true");
            Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            CB=new SqlCommandBuilder(Ada);
            Set = new DataSet();
            Ada.Fill(Set);
            Read();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog A = new OpenFileDialog();
            A.Filter = "*.jpg|*.jpg";
            A.ShowDialog();
            if (A.FileName != "")
            {
                this.pictureBox1.Image = Image.FromFile(A.FileName);
            }
        }
    }
}
