using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_BringMoney : Skin_Mac
    {
        public Frm_BringMoney()
        {
            InitializeComponent();
        }

        private void Frm_BringMoney_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Back_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void Btn_Init_Click(object sender, EventArgs e)
        {
            lbl_Account.Text = lbl_Money.Text = "";
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_BringMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseKey) new Frm_Main().Show();
        }
        static bool CloseKey = true;
        static float UserMoney;
        static int DoMoney;
        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            if (txt_Account.Text == "")
            {
                MessageBox.Show("卡号不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Account.Text.Length != 8)
            {
                MessageBox.Show("卡号长度应为8！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!BLL.Login.ExistCardID(txt_Account.Text))
            {
                MessageBox.Show("该账号不存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Money.Text == "")
            {
                MessageBox.Show("金额不许为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((DoMoney = Convert.ToInt32(txt_Money.Text)) % 100 != 0)
            {
                MessageBox.Show("金额必须为100整数倍！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_Account.Text == Model.Users.CID)
            {
                MessageBox.Show("不能给自己转账！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoMoney > (UserMoney = BLL.DrawMoney.GetUserMoney(Model.Users.CID)))
            {
                MessageBox.Show("所取金额已大于卡里余额！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DoMoney > 1000000)
            {
                MessageBox.Show("所取金额已大于ATM机余额！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BLL.DrawMoney.ChangeUserMoney(Model.Users.CID, DoMoney, false);
                BLL.DrawMoney.ChangeUserMoney(txt_Account.Text, DoMoney, true);
                Model.Transfer TRANSFER = new Model.Transfer(BLL.DrawMoney.GetTradeID(), Model.Users.CID, txt_Account.Text, DoMoney, UserMoney - DoMoney, DateTime.Now, null);
                BLL.BringMoney.SaveNewData(TRANSFER);
                MessageBox.Show("转帐成功！", "OK", MessageBoxButtons.OK);
                CloseKey = false;
                this.Close();
                new Frm_PrintBringM() { Transfer = TRANSFER }.Show();
            }
        }
    }
}
