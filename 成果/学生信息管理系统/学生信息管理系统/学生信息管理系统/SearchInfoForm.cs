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

        private void SearchInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Heart.ShowMF();
        }

        private void 作者EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form A = null;
            if (sender.Equals(预览XToolStripMenuItem))
            {
                A = new MainForm();
            }
            else if (sender.Equals(管理BToolStripMenuItem))
            {
                A = new ReadInfoForm();
            }
            else if (sender.Equals(搜索CToolStripMenuItem))
            {
                A = new ManageInfoForm();
            }
            else if (sender.Equals(说明DToolStripMenuItem))
            {
                A = new ExplanationForm();
            }
            else if (sender.Equals(作者EToolStripMenuItem))
            {
                A = new Anthor();
            }
            this.ForMF.Dispose();
            this.Hide();
            A.Show();
        }

        private void SearchInfoForm_SizeChanged(object sender, EventArgs e)
        {
            Heart.Form_SizeChanged(this);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ForMF.ShowBalloonTip(500, "Tip", "点击启动可呼出窗体！", ToolTipIcon.Info);
            }
        }

        private void 启动SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heart.ChangeSize(this);
        }

        private void 设置QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heart.FormExit(e, this, this.ForMF);
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
    }
}
