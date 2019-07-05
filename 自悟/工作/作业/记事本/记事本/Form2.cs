using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        public 记事本 B;
        private void SelectText_TextChanged(object sender, EventArgs e)
        {
            if (SelectText.Text != "") { StartPos = 0; Find.Enabled = true; }
        }
        static int StartPos ;
        private void Find_Click(object sender, EventArgs e)
        {
            int Pos;
            if (StartPos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (!DXX.Checked)
                {
                    if (!UPS.Checked)
                        Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
                    else
                        Pos = B.Main.Text.LastIndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
                }

                else
                {
                    if (!UPS.Checked)
                        Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos);
                    else
                        Pos = B.Main.Text.LastIndexOf(SelectText.Text, StartPos);

                }
                if (Pos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    B.Main.Select(Pos, SelectText.TextLength);
                    if (!UPS.Checked)
                        StartPos = Pos + SelectText.TextLength;
                    else
                    {
                        StartPos = Pos - SelectText.TextLength;
                        if (StartPos < 0) { StartPos = -1; }
                    }

                    B.Main.Focus();
                }
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            StartPos = 0;
        }

        private void UPS_CheckedChanged(object sender, EventArgs e)
        {
            if(StartPos==-1)StartPos = 0;
        }
    }
}
