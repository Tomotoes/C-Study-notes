using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using CCWin;

namespace UI
{
    public partial class Frm_CardID : Skin_Mac
    {
        public Frm_CardID()
        {
            InitializeComponent();
        }

        private void Frm_ApplyID_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            Model.Users User = new Users(txt_CardID.Text, txt_UserID.Text, txt_UserName.Text, txt_Password.Text, System.DateTime.Now, 0, false, null, cbox_PWSQuestion.Text, txt_PWSAnswer.Text);
            if (BLL.Login.ExistCardID(txt_CardID.Text))
            {
                MessageBox.Show("该账号已存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BLL.Login.ExistUserID(txt_UserID.Text))
            {
                MessageBox.Show("该身份证号码已存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BLL.ApplyID.InfoIsOk(User))
            {
                BLL.ApplyID.SaveNewUser(User);
                this.Close();
            }
        }
    }
}
