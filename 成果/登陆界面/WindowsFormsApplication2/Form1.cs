using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = txtUserName.Text;
            string strPass = txtPassword.Text;
            if(strUserName=="Admin" && strPass=="Admin")
            {
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
                //this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误","提示消息",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Clear();
        }


        List<User> listUser = new List<User>()
        {
            new User(){ Username= "aaa",  Password= "aaaaaaa"},
            new User(){ Username= "bbb",  Password= "bbbbbbb"},
            new User(){ Username= "ccc",  Password= "ccccccc"},
            new User(){ Username= "ddd",  Password= "ddddddd"},
            new User(){ Username= "eee",  Password= "eeeeeee"},
            new User(){ Username= "fff",  Password= "fffffff"}
        };
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtUserName.Text!="")
            {
                string username = txtUserName.Text;
                var v = listUser.Where(m => m.Username == txtUserName.Text).FirstOrDefault();
                if (v != null)
                {
                    txtPassword.Text = v.Password;
                }
                else
                {
                    txtPassword.Clear();
                }
            }
            else
            {

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
