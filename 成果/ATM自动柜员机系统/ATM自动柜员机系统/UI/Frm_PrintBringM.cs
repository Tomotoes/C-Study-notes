using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_PrintBringM : Skin_Mac
    {
        public Frm_PrintBringM()
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

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_PrintBringM_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Frm_Main().Show();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }
        public Model.Transfer Transfer;

        private void Frm_PrintBringM_Load(object sender, EventArgs e)
        {
            lbl_TradeID.Text += Transfer.TradeID;
            lbl_ZName.Text += Transfer.SourceCardID;
            lbl_SName.Text += Transfer.TargetCardID;
            lbl_Money.Text += Transfer.Cash;
            lbl_Time.Text += Transfer.Time;
            lbl_Balance.Text += Transfer.Balance;
            lbl_Content.Text += "无";
        }
    }
}
