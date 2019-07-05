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

        private void ExplanationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Heart.ShowMF(this);
        }
    }
}
