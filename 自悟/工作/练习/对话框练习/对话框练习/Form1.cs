using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 对话框练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "文本文件|*.txt";
            OF.ShowDialog();
            richTextBox1.LoadFile(OF.FileName,RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.ShowDialog();
            richTextBox1.Font = FD.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog CD = new ColorDialog();
            CD.ShowDialog();
            richTextBox1.ForeColor = CD.Color;
            richTextBox1.SelectionColor = CD.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog SF = new SaveFileDialog();
            SF.Filter = "文本文件|*.txt";
            SF.ShowDialog();
            richTextBox1.SaveFile(SF.FileName,RichTextBoxStreamType.PlainText);
        }
    }
}
