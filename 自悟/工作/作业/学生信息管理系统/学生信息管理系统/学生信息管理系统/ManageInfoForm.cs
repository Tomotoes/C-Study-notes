using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

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
            pictureBox1.Image = Image.FromFile("Image/NoPicture.jpg");
            textBox5.Text = textBox1.Text = textBox2.Text = "";
            comboBox1.Text = "男";
            comboBox2.Text = "18";
            Q = false;
        }
        private void ManageInfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void ManageInfoForm_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
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
            bool P = false;
            if (radioButton1.Checked)
            {
                var IB = Heart.ChangeByte(this.pictureBox1.Image);
                
                if (Heart.Insert(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, textBox5.Text,IB))
                { MessageBox.Show("添加数据成功！", "Insert", MessageBoxButtons.OK); P = true; }
            }
            else if (radioButton3.Checked)
            {
                if (!Q)
                {
                    MessageBox.Show("请先查找信息,在原信息上进行修改！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Heart.Updata(textBox1.Text, textBox2.Text, comboBox1.Text, comboBox2.Text, textBox5.Text))
                    { MessageBox.Show("修改数据成功！", "Updata", MessageBoxButtons.OK); P = true; }
                }
            }
            else if (radioButton2.Checked)
            {
                if (!Q)
                {
                    MessageBox.Show("请先查找信息！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Heart.Delete(textBox1.Text))
                    { MessageBox.Show("删除数据成功！", "Delete", MessageBoxButtons.OK); P = true; }
                }
            }
            if (P)
            {
                button3_Click(sender, e);
                Init();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < this.Controls.Count; ++i)
            {
                this.Controls[i].Enabled = false;
            }
            button5.Enabled = button8.Enabled = pictureBox2.Enabled = true;
            Heart.InsertImageForm(false,this);
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

        private void ManageInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Heart.ShowMF(this);
        }
    }
}
