using System;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class ExplanationForm : Form
    {
        public ExplanationForm()
        {
            InitializeComponent();
        }

        private void ExplanationForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ExplanationForm_SizeChanged(object sender, EventArgs e)
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

        private void ExplanationForm_Load(object sender, EventArgs e)
        {
            label1.Text += "\n\n\n\n\n\n\n\n\n\n\n\n     史上最无用的功能 没有之一。。\r\n\r\n     温馨提示：笔记本运行效果不如一体机";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
