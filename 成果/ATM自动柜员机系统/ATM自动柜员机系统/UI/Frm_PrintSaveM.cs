using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_PrintSaveM : Skin_Mac
    {
        public Frm_PrintSaveM()
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

        private void Frm_PrintSaveM_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Frm_Main().Show();

        }
        public Model.Save Save;
        private void Frm_PrintSaveM_Load(object sender, EventArgs e)
        {
            lbl_Name.Text += Save.CardID;
            lbl_Money.Text += Save.Cash;
            lbl_Time.Text += Save.Time;
            lbl_TradeID.Text += Save.TradeID;
            lbl_Balance.Text += Save.Balance;
            lbl_Content.Text += "无";
        }
    }
}
