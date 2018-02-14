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

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter Ada = new SqlDataAdapter("select * from Information", "server=.;database=StudentPlus;integrated security=true");
            DataSet Set = new DataSet();
            Ada.Fill(Set);

            this.dataGridView1.DataSource = Set.Tables[0].DesignMode;
        }
        static bool F = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!F)
            {
                dataGridView1.Columns[0].DisplayIndex ^= dataGridView1.Columns[1].DisplayIndex;
                dataGridView1.Columns[1].DisplayIndex ^= dataGridView1.Columns[0].DisplayIndex;
                dataGridView1.Columns[0].DisplayIndex ^= dataGridView1.Columns[1].DisplayIndex;
                F = true;
            }
            else
            {
                dataGridView1.Columns[1].DisplayIndex ^= dataGridView1.Columns[0].DisplayIndex;
                dataGridView1.Columns[0].DisplayIndex ^= dataGridView1.Columns[1].DisplayIndex;
                dataGridView1.Columns[1].DisplayIndex ^= dataGridView1.Columns[0].DisplayIndex;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = !dataGridView1.Columns[0].Visible;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
