using System;
using System.Drawing;
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

        private void ReadInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Heart.ShowMF();
        }

        private void ReadInfoForm_Load(object sender, EventArgs e)
        {
            Heart.Read(InfoIndex=0,ImageIndex=5,this);
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
        private void 作者EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form A = null;
            if (sender.Equals(预览XToolStripMenuItem))
            {
                A = new MainForm();
            }
            else if (sender.Equals(管理BToolStripMenuItem))
            {
                A = new ManageInfoForm();
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

        private void ReadInfoForm_SizeChanged(object sender, EventArgs e)
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                new Heart().BigImage(this.pictureBox1);
            }
        }
    }
}
