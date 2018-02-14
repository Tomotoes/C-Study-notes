using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_Main : Skin_Mac
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }
        static int Count = 0;
        private void Time_Tick(object sender, EventArgs e)
        {
            if ((++Count) > 5)
            {
                Count = 1;
            }
            if (Count == 1)
            {
                pic_First.Visible = lbl_First.Visible = true;
                lbl_Second.Visible = lbl_Third.Visible = lbl_Fourth.Visible = lbl_Fivth.Visible = false;
                pic_Second.Visible = pic_Third.Visible = pic_Fourth.Visible = pic_Fivth.Visible = false;
                lbl_One.BackColor = Color.Black;
                lbl_Three.BackColor = lbl_Four.BackColor = lbl_Five.BackColor = lbl_Two.BackColor = Color.Gray;
            }
            if (Count == 2)
            {
                pic_Second.Visible = lbl_Second.Visible = true;
                lbl_First.Visible = lbl_Third.Visible = lbl_Fourth.Visible = lbl_Fivth.Visible = false;
                pic_First.Visible = pic_Third.Visible = pic_Fourth.Visible = pic_Fivth.Visible = false;
                lbl_Two.BackColor = Color.Black;
                lbl_Three.BackColor = lbl_Four.BackColor = lbl_Five.BackColor = lbl_One.BackColor = Color.Gray;
            }
            if (Count == 3)
            {
                pic_Third.Visible = lbl_Third.Visible = true;
                lbl_Second.Visible = lbl_First.Visible = lbl_Fourth.Visible = lbl_Fivth.Visible = false;
                pic_Second.Visible = pic_First.Visible = pic_Fourth.Visible = pic_Fivth.Visible = false;
                lbl_Three.BackColor = Color.Black;
                lbl_Two.BackColor = lbl_Four.BackColor = lbl_Five.BackColor = lbl_One.BackColor = Color.Gray;
            }
            if (Count == 4)
            {
                pic_Fourth.Visible = lbl_Fourth.Visible = true;

                lbl_Second.Visible = lbl_Third.Visible = lbl_First.Visible = lbl_Fivth.Visible = false;
                pic_Second.Visible = pic_Third.Visible = pic_First.Visible = pic_Fivth.Visible = false;
                lbl_Four.BackColor = Color.Black;
                lbl_Two.BackColor = lbl_Three.BackColor = lbl_Five.BackColor = lbl_One.BackColor = Color.Gray;
            }
            if (Count == 5)
            {
                pic_Fivth.Visible = lbl_Fivth.Visible = true;

                lbl_Second.Visible = lbl_Third.Visible = lbl_Fourth.Visible = lbl_First.Visible = false;
                pic_Second.Visible = pic_Third.Visible = pic_Fourth.Visible = pic_First.Visible = false;
                lbl_Five.BackColor = Color.Black;
                lbl_Two.BackColor = lbl_Three.BackColor = lbl_Four.BackColor = lbl_One.BackColor = Color.Gray;
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.Login.FormExit();
        }

        private void Btn_Bring_Click(object sender, EventArgs e)
        {
            Form A = null;
            if (sender.Equals(Btn_About))
            {
                A = new Frm_About();
            }
            if (sender.Equals(Btn_Bring))
            {
                A = new Frm_BringMoney();
            }
            if (sender.Equals(Btn_Change))
            {
                A = new Frm_ChangePWS();
            }
            if (sender.Equals(Btn_Draw))
            {
                A = new Frm_DrawMoney();
            }
            if (sender.Equals(Btn_SelectData))
            {
                A = new Frm_SelectData();
            }
            if (sender.Equals(Btn_Save))
            {
                A = new Frm_SaveMoney();
            }
            if (sender.Equals(Btn_Select))
            {
                A = new Frm_SelectMoney();
            }
            Time.Stop();
            Hide();A.Show();
        }
    }
}
