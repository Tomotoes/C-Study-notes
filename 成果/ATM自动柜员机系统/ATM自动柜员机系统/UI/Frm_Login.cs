using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_Login : Skin_Mac
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Login_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

            if (sender.Equals(Btn_ApplyID))
            {
                Hide();
                new Frm_CardID().Show();
            }
            else
            {
                if (txt_Account.Text.Length != 8)
                {
                    MessageBox.Show("卡号长度应为8！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_Password.Text.Length != 6 && (!sender.Equals(Btn_ForgetPWS)))
                {
                    MessageBox.Show("密码长度应为6！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!BLL.Login.ExistCardID(txt_Account.Text))
                {
                    MessageBox.Show("该账号不存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sender.Equals(Btn_ForgetPWS))
                {
                    Frm_ForgetPWS This = new Frm_ForgetPWS()
                    {
                        CardID = txt_Account.Text
                    };
                    Hide();
                    This.Show();
                }
                else
                {
                    if (BLL.Login.GetAccountFrozen(txt_Account.Text))
                    {
                        MessageBox.Show("账号已冻结，已尝试‘忘记密码’", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (BLL.Login.ExitstAccountPWS(txt_Account.Text, txt_Password.Text))
                    {
                        Model.Users.CID = txt_Account.Text;
                        Hide();
                        new Frm_Main().Show();
                    }
                    else
                    {
                        MessageBox.Show("密码不正确，错误三次将冻结账号！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if ((++ErrorCount) > 2)
                        {
                            BLL.Login.ChangeAccountFrozen(txt_Account.Text, true);
                            MessageBox.Show("账号已冻结，已尝试‘忘记密码’", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        static int ErrorCount = 0;

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.Login.FormExit();
        }
    }
}
