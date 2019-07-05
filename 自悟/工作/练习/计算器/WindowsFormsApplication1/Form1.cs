using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double num1 = 0.0;
        public double num2 = 0.0;
        public string OP = "";
        public bool IsDot = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            btn0.Click += btn_Click;
            btn1.Click += btn_Click;
            btn2.Click += btn_Click;
            btn3.Click += btn_Click;
            btn4.Click += btn_Click;
            btn5.Click += btn_Click;
            btn6.Click += btn_Click;
            btn7.Click += btn_Click;
            btn8.Click += btn_Click;
            btn9.Click += btn_Click;
            

            btnAdd.Click+=btnOP_Click;
            btnSub.Click += btnOP_Click;
            btnMul.Click += btnOP_Click;
            btnDiv.Click += btnOP_Click;
        }

        void btnOP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                
                num1 = Convert.ToDouble(textBox1.Text);
                OP = (sender as Button).Text;
                textBox1.Text = "";
                IsDot = false;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = sender as Button;
            textBox1.Text += btn.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                double result = 0;
                switch(OP)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/": result = num1 / num2; break;
                }
                textBox1.Text = result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsDot == false)
            {
                if (textBox1.Text != "")
                {
                    textBox1.Text += ".";
                    IsDot = true;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W:
                    button2.Location = new Point(button2.Location.X, button2.Location.Y-5);
                    ; break;
                case Keys.A:
                    button2.Location = new Point(button2.Location.X-5, button2.Location.Y);
                    ; break;
                case Keys.S:
                    button2.Location = new Point(button2.Location.X, button2.Location.Y + 5);
                    ; break;
                case Keys.D:
                   
                    btnOK.Location=Tui(button2.Location, btnOK.Location);
                    button2.Location = new Point(button2.Location.X + 5, button2.Location.Y);
                    ; break;
            }
        } 
        public Point Tui(Point lPoint,Point xPoint)
        {
            int x = lPoint.X + button2.Width;
            if (x >= xPoint.X && lPoint.Y >= btnOK.Location.Y && lPoint.Y + button2.Height <= lPoint.Y + btnOK.Height)
            {
                xPoint.X=xPoint.X + 5;
            }
            return xPoint;
        }
    }
}
