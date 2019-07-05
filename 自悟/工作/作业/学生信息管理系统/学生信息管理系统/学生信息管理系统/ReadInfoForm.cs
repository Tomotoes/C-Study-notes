using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class ReadInfoForm : Form
    {
        static int ImageIndex;
        static int InfoIndex;
        public ReadInfoForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Heart.ChangeInfoIndex(1,ref InfoIndex,ref ImageIndex,this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Heart.ChangeInfoIndex(2, ref InfoIndex, ref ImageIndex, this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Heart.ChangeInfoIndex(4, ref InfoIndex, ref ImageIndex, this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Heart.ChangeInfoIndex(3, ref InfoIndex, ref ImageIndex, this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Heart.ChangeImageIndex(true, InfoIndex, ref ImageIndex, this);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Heart.DeleteImage(InfoIndex, ImageIndex,this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (F)
            {
                F = timer1.Enabled = false;
                button9.Text = "自动播放";
            }
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled=button5.Enabled = button6.Enabled = button8.Enabled = button9.Enabled = button7.Enabled = false;
            Heart.InsertImage(InfoIndex, ImageIndex, this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Heart.ChangeImageIndex(false, InfoIndex, ref ImageIndex, this);
        }
        static bool F = false;
        private void button9_Click(object sender, EventArgs e)
        {
            if (!F)
            {
                F=timer1.Enabled = true;
                button9.Text = "点击暂停";
            }
            else
            {
                F = timer1.Enabled = false;
                button9.Text = "自动播放";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Heart.ChangeImageIndex(true, InfoIndex, ref ImageIndex, this);
        }
        private void ReadInfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void ReadInfoForm_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                new Heart().BigImage(this.pictureBox1);
            }
        }
        private void ReadInfoForm_Load(object sender, EventArgs e)
        {
            Heart.Read(InfoIndex = 0, ImageIndex = 5, this);
        }

        private void ReadInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Heart.ShowMF(this);
        }
    }
}
