using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            F = false;
        }
        static bool F;
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Heart.Form_SizeChanged(this);
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ForMF.ShowBalloonTip(500, "Tip", "点击启动可呼出窗体！", ToolTipIcon.Info);
            }
        }
        private void 退出QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heart.FormExit(e, this, this.ForMF);
        }
        private void 启动SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Heart.ChangeSize(this);
        }
        private void ReadInfo_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }
        private void ReadInfo_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        public void ReadInfo_Click(object sender, EventArgs e)
        {
            Form A=null;
            if (sender.Equals(ReadInfo) || sender.Equals(预览XToolStripMenuItem))
            {
                A = new ReadInfoForm();
            }
            else if (sender.Equals(ManageInfo) || sender.Equals(管理BToolStripMenuItem))
            {
                A = new ManageInfoForm();
            }
            else if (sender.Equals(SearchInfo) || sender.Equals(搜索CToolStripMenuItem))
            {
                A = new SearchInfoForm();
            }
            else if (sender.Equals(Explanation) || sender.Equals(说明DToolStripMenuItem))
            {
                A = new ExplanationForm();
            }
            else if (sender.Equals(Anthor) || sender.Equals(作者EToolStripMenuItem))
            {
                A = new Anthor();
            }
            Thread B=new Thread((ThreadStart)delegate { Application.Run(A); });
            B.SetApartmentState(ApartmentState.STA);
            F = true;
            this.Close(); 
            B.Start();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!F) Heart.FormExit(e, this, this.ForMF);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Heart.CmpCon()&&!Heart.Cmp)
            {
                Heart.ShowError(this);
            }
        }
        int deltX = 8;
        int deltY = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += deltX;
            label1.Top += deltY;
            if (label1.Top < 0 || label1.Top + label1.Height > this.Height - 30)
            {
                deltY = -deltY;
            }
            if (label1.Left < 0 || label1.Left + label1.Width > this.Width - 10)
            {
                deltX = -deltX;
            }
        }
    }
}
