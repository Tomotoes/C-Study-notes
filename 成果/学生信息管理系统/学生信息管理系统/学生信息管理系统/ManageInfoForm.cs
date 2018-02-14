using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace 学生信息管理系统
{
    public partial class ManageInfoForm : Form
    {
        public ManageInfoForm()
        {
            InitializeComponent();
        }

        private void ManageInfoForm_Load(object sender, EventArgs e)
        {
            this.Init();
            radioButton1.Checked = true;
        }
        public void Init()
        {
            pictype = null;
            pictureBox1.Image = Image.FromFile("Image/NoPicture.jpg");
            textBox5.Text = textBox1.Text = textBox2.Text = "";
            comboBox1.Text = "男";
            comboBox2.Text = "18";
            Q = false;
        }
        private void ManageInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Heart.ShowMF();
        }

        private void ManageInfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void ManageInfoForm_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
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
                A = new SearchInfoForm();
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

        private void ManageInfoForm_SizeChanged(object sender, EventArgs e)
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
            Heart.FormExit(e, this,this.ForMF);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Init();
                button7.Enabled = textBox1.Enabled = textBox2.Enabled
                = comboBox1.Enabled = comboBox2.Enabled = textBox5.Enabled = true;
                button4.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Init();
                textBox1.Enabled = textBox2.Enabled = button4.Enabled 
                = comboBox1.Enabled = comboBox2.Enabled = textBox5.Enabled = true;
                button7.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Init();
                button4.Enabled = textBox1.Enabled = true;
                button7.Enabled = textBox2.Enabled
                = comboBox1.Enabled = comboBox2.Enabled = textBox5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!dataGridView1.Visible)
            {
                dataGridView1.Visible = true;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Font = new Font(new FontFamily("宋体"), 11);
                
                dataGridView1.DataSource = Heart.GetDataSource().Tables[0].DefaultView;
                button3.Text = "点击关闭";
            }
            else
            {
                dataGridView1.Visible = false;
                button3.Text = "全部信息";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (Heart.Insert(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, textBox5.Text, pictype))
                { MessageBox.Show("添加数据成功！", "Insert", MessageBoxButtons.OK); }
                else { return; }
            }
            else if (radioButton3.Checked)
            {
                if (!Q)
                {
                    MessageBox.Show("请先查找信息,在原信息上进行修改！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Heart.Updata(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, textBox5.Text))
                    { MessageBox.Show("修改数据成功！", "Updata", MessageBoxButtons.OK); }
                    else { return; }
                }
            }
            else if (radioButton2.Checked)
            {
                if (!Q)
                {
                    MessageBox.Show("请先查找信息！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (Heart.Delete(textBox1.Text))
                    { MessageBox.Show("删除数据成功！", "Delete", MessageBoxButtons.OK); }
                    else { return; }
                }
            }
            button3_Click(sender, e);
            Init();
        }
        static byte[] pictype;
        public void SaveImage()
        {
            pictype=null;
            Stream S = null;
            OpenFileDialog A = new OpenFileDialog();
            A.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            if (A.ShowDialog() == DialogResult.OK)
            {
                if (A.FileName != "")
                {
                    S = A.OpenFile();
                    //把图片转为字节数组
                    pictype = new byte[S.Length];
                    S.Position = 0;
                    S.Read(pictype, 0, Convert.ToInt32(S.Length));
                    this.pictureBox1.Image = Image.FromFile(A.FileName);
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init();
        }
        static bool Q = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (Heart.SingleSearch(textBox1.Text,this))
            {
                Q = true;
            }
            else { Q = false; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Heart().BigImage(this.pictureBox1);
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ValueType.ToString()=="System.Byte[]" && 
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=System.DBNull.Value)
            {
                PictureBox P=new PictureBox();
                P.Image=Heart.GetImage((byte[])dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                new Heart().BigImage(P);
            }
        }
    }
}
