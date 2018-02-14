using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace UI
{
    public partial class Frm_SelectData : Skin_Mac
    {
        public Frm_SelectData()
        {
            InitializeComponent();
        }

        private void Btn_Print_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as Button).ForeColor = Color.Blue;
        }

        private void Btn_Print_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.Black;
        }

        private void Frm_SelectData_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Frm_Main().Show();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            BLL.Login.FormExit();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDialog.ShowDialog();
        }

        private void Frm_SelectData_Load(object sender, EventArgs e)
        {
            rBtn_Save.Checked = true;
        }

        private void rBtn_Save_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Save.Checked)
            {
                dgv_Save.Visible = true;
                dgv_Save.AutoGenerateColumns = false;
                dgv_Save.Font = new Font(new FontFamily("宋体"), 11);
                dgv_Save.DataSource = BLL.SelectData.GetSaveInfo().Tables[0];
                dgv_Bring.Visible = dgv_Draw.Visible = false;
            }

        }

        private void rBtn_Draw_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Draw.Checked)
            {
                dgv_Draw.Visible = true;
                dgv_Draw.AutoGenerateColumns = false;
                dgv_Draw.Font = new Font(new FontFamily("宋体"), 11);
                dgv_Draw.DataSource = BLL.SelectData.GetDrawInfo().Tables[0];
                dgv_Bring.Visible = dgv_Save.Visible = false;
            }
        }

        private void rBtn_Bring_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn_Bring.Checked)
            {
                dgv_Bring.Visible = true;
                dgv_Bring.AutoGenerateColumns = false;
                dgv_Bring.Font = new Font(new FontFamily("宋体"), 11);
                dgv_Bring.DataSource = BLL.SelectData.GetTransferInfo().Tables[0];
                dgv_Draw.Visible = dgv_Save.Visible = false;
            }
        }
    }
}
