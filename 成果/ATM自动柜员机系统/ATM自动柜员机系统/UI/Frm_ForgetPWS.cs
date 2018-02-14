using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_ForgetPWS : Skin_Mac
    {
        public Frm_ForgetPWS()
        {
            InitializeComponent();
            
        }

        private void Frm_ForgetPWS_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Frm_Login().Show();
        }

        private void Btn_Sure_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Sure_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;

        }
        public string Answer = null;
        public string CardID = null;
        private void Frm_ForgetPWS_Load(object sender, EventArgs e)
        {
            txt_Question.Text = BLL.ForGetPWS.GetQuestion(this.CardID);
            this.Answer = BLL.ForGetPWS.GetAnswer(this.CardID);
        }

        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            if (txt_Answer.Text == Answer)
            {
                Frm_ChangePWS This = new Frm_ChangePWS() { CardID=this.CardID};
                this.Hide();
                This.Show();
            }
            else
            {
                MessageBox.Show("回答错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
