using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_SelectMoney : Skin_Mac
    {
        public Frm_SelectMoney()
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

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            BLL.Login.FormExit();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SelectMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Frm_Main().Show();
        }

        private void Frm_SelectMoney_Load(object sender, EventArgs e)
        {
            lbl_Money.Text += BLL.DrawMoney.GetUserMoney(Model.Users.CID);
            lbl_Time.Text += DateTime.Now;
            lbl_Username.Text += Model.Users.CID;
        }
    }
}
