using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_PrintDrawM : Skin_Mac
    {
        public Frm_PrintDrawM()
        {
            InitializeComponent();
        }
        public Model.Draw Draw;
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

        private void Frm_PrintDrawM_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Frm_Main().Show();
        }

        private void Frm_PrintDrawM_Load(object sender, EventArgs e)
        {
            lbl_Name.Text += Draw.CardID;
            lbl_Money.Text += Draw.Cash;
            lbl_Time.Text += Draw.Time;
            lbl_TradeID.Text += Draw.TradeID;
            lbl_Balance.Text += Draw.Balance;
            lbl_Content.Text += "无";
            
        }
    }
}
