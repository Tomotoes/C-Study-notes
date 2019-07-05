using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 更改字体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float MyFontSize;
        public FontFamily MyFontStyle;
        void Init()
        {
            MyFontSize = textBox1.Font.Size;
            MyFontStyle = textBox1.Font.FontFamily;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font("宋书",MyFontSize);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font("隶书",MyFontSize);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font("黑体", MyFontSize);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, 12);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, 18);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, MyFontSize, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, MyFontSize, textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, MyFontSize, textBox1.Font.Style ^ FontStyle.Underline);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Init();
            textBox1.Font = new Font(MyFontStyle, MyFontSize, textBox1.Font.Style ^ FontStyle.Strikeout);
        }
    }
}
