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
    public partial class ReplaceFrom : Form
    {
        public ReplaceFrom()
        {
            InitializeComponent();
        }
        public 记事本 B;
        public int Record;
        public void FindWord()
        {
            int Pos;
            if (StartPos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                if (!DXX.Checked)
                    Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
                else
                    Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos);

                if (Pos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    B.Main.Select(Pos, SelectText.TextLength);
                    StartPos = Pos + SelectText.TextLength;
                    B.Main.Focus();
                }
            }
        }
        public bool ReplaceWord()
        {
            int Pos;
            if (StartPos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            else
            {
                if (!DXX.Checked)
                    Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
                else
                    Pos = B.Main.Text.IndexOf(SelectText.Text, StartPos);

                if (Pos == -1) { MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);return false; }
                else
                {
                    Record = StartPos;
                    B.Main.Select(Pos, SelectText.TextLength);
                    int AC = textBox2.TextLength == 0 ? 1 : textBox2.TextLength;
                    StartPos = Pos + AC;
                    B.Main.Focus();
                    return true;
                }
            }
        }
        private void ToSelect_TextChanged(object sender, EventArgs e)
        {
            if (SelectText.Text != "")
            {
                Find.Enabled = button2.Enabled = button3.Enabled = true;
            }
            StartPos = 0;
        }

        static int StartPos;
        private void Find_Click(object sender, EventArgs e)
        {
            FindWord();
        }

        private void ReplaceFrom_Load(object sender, EventArgs e)
        {
            Record = StartPos = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPos = Record;
            if (ReplaceWord())
            {
                B.Main.SelectedText = textBox2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int Ac = 0,Wa=0;

            if (!DXX.Checked)
                Ac = B.Main.Text.IndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
            else
                Ac = B.Main.Text.IndexOf(SelectText.Text, StartPos);

            if (Ac == -1)
            {
                MessageBox.Show("找不到 " + SelectText.Text, "Find", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Wa = -1;
            }
            if (Wa != -1)
            {
                
                while (Wa<B.Main.TextLength)
                {
                    if (!DXX.Checked)
                        Ac = B.Main.Text.IndexOf(SelectText.Text, StartPos, StringComparison.CurrentCultureIgnoreCase);
                    else
                        Ac = B.Main.Text.IndexOf(SelectText.Text, StartPos);
                    if (Ac == -1) { break; }
                    B.Main.Select(Ac,SelectText.TextLength) ;
                    B.Main.SelectedText = textBox2.Text;
                    Wa = Ac + textBox2.TextLength;
                }
            
            }
           
        }
    }
}
