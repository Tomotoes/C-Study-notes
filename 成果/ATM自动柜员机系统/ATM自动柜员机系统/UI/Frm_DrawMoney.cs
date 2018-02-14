using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_DrawMoney : Skin_Mac
    {
        public Frm_DrawMoney()
        {
            InitializeComponent();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void Btn_Five_Click(object sender, EventArgs e)
        {
            if (sender.Equals(Btn_One))
            {
                txt_Result.Text = "100";
            }
            if (sender.Equals(Btn_Three))
            {
                txt_Result.Text = "300";
            }
            if (sender.Equals(Btn_Five))
            {
                txt_Result.Text = "500";
            }
            if (sender.Equals(Btn_Ten))
            {
                txt_Result.Text = "1000";
            }
            if (sender.Equals(Btn_Twl))
            {
                txt_Result.Text = "2000";
            }
            if (sender.Equals(Btn_Fiveth))
            {
                txt_Result.Text = "5000";
            }
        }

        private void Btn_Sure_Click(object sender, EventArgs e)
        {
            if (txt_Result.Text == "")
            {
                MessageBox.Show("金额不许为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((DoMoney = Convert.ToInt32(txt_Result.Text)) % 100 != 0)
            {
                MessageBox.Show("金额必须为100整数倍！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (DoMoney > (UserMoney = BLL.DrawMoney.GetUserMoney(Model.Users.CID)))
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
                    Model.Draw DRAW = new Model.Draw(BLL.DrawMoney.GetTradeID(), Model.Users.CID,DoMoney, DateTime.Now, null, UserMoney - DoMoney);
                    BLL.DrawMoney.SaveNewData(DRAW);
                    MessageBox.Show("取款成功！", "OK", MessageBoxButtons.OK);
                    CloseKey = false;
                    this.Close();
                    new Frm_PrintDrawM() { Draw = DRAW }.Show();
                }
            }
            
        }
        static bool CloseKey = true;
        static float UserMoney;
        static int DoMoney;
        private void Frm_DrawMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseKey) new Frm_Main().Show();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            BLL.Login.FormExit();
        }
    }
}
