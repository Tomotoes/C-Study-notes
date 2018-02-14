using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_ChangePWS : Skin_Mac
    {
        public Frm_ChangePWS()
        {
            InitializeComponent();
        }

        private void Btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Back_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void Frm_ChangePWS_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CardID == null) { new Frm_Main().Show(); }
            else new Frm_Login().Show();
        }

        private void Btn_Init_Click(object sender, EventArgs e)
        {
            txt_NewPWS.Text = txt_ReNewPWS.Text = "";
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string CardID=null;
        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            if (txt_NewPWS.Text.Length != 6)
            {
                MessageBox.Show("密码长度为6位！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_NewPWS.Text != txt_ReNewPWS.Text)
            {
                MessageBox.Show("密码输入不一致！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CardID == null) CardID = Model.Users.CID;
                BLL.ChangePWS.SaveNewPWS(CardID, txt_NewPWS.Text);
                BLL.Login.ChangeAccountFrozen(CardID, false);
                this.Close();
            }
        }
    }
}
