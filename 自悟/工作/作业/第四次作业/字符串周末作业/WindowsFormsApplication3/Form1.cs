using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Score=0;
            string[] S = textBox1.Text.Trim().ToLower().Split(',');
            try
            {
                for (int i = 0; ; i++)
                {
                    switch (S[i])
                    {
                        case "apple": Score++; break;
                        case "book": Score++; break;
                        case "car": Score++; break;
                        case "cat": Score++; break;
                        case "red": Score++; break;
                        case "sky": Score++; break;
                        case "school": Score++; break;
                        case "box": Score++; break;
                        case "bag": Score++; break;
                        case "bike": Score++; break;
                    }
                }
            }
            catch { textBox2.Text = Score.ToString(); }
        }
    }
}
