using System;
using System.Drawing;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class SearchInfoForm : Form
    {
        public SearchInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heart.MoreSearch(NoText.Text, NameText.Text, SexText.Text, AgeText.Text, DeptText.Text,this); 
        }

        private void SearchInfoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Font = new Font(new FontFamily("宋体"), 11);
            
            bindingSource1.DataSource = Heart.GetDataSource().Tables[0];
            dataGridView1.DataSource = bindingNavigator1.BindingSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.ToString() == "System.Byte[]" &&
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != System.DBNull.Value)
            {
                PictureBox P = new PictureBox();
                P.Image = Heart.GetImage((byte[])dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                new Heart().BigImage(P);
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.ToString() == "System.Drawing.Image" &&
               dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != System.DBNull.Value)
            {
                PictureBox P = new PictureBox();
                P.Image = Heart.GetImage((byte[])dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                new Heart().BigImage(P);
            }
        }

        private void SearchInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Heart.ShowMF(this);
        }
    }
}
