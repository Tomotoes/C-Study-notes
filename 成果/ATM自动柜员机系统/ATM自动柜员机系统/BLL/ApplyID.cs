using System;
using System.Windows.Forms;

namespace BLL
{
    public class ApplyID
    {
        static public bool InfoIsOk(Model.Users User)
        {
            if (User.UserName == "")
            {
                MessageBox.Show("姓名不可以为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.CardID == "")
            {
                MessageBox.Show("卡号不可以为空！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (User.CardID.Length != 8)
            {
                MessageBox.Show("卡号长度为8位！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (User.Password == "")
            {
                MessageBox.Show("密码不可以为空！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.Password.Length != 6)
            {
                MessageBox.Show("密码长度为6位！", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (User.UserID == "")
            {
                MessageBox.Show("身份证号不可以为空！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (User.UserID.Length != 18)
            {
                MessageBox.Show("身份证号码长度为18位！", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            if (User.Question == "")
            {
                MessageBox.Show("密保问题不可以为空！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (User.Answer == "")
            {
                MessageBox.Show("密保答案不可以为空！", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        static public void SaveNewUser(Model.Users User)
        {
            DAL.Users.SaveNewUser(User);
            MessageBox.Show("注册用户成功！", "Insert", MessageBoxButtons.OK);
        }
    }
}
