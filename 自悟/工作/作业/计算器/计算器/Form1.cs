using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class 计算器 : Form
    {
        public 计算器()
        {
            InitializeComponent();
        }
        const int INF = 0x3f3f3f3f;
        public double A, B;//A,B 为操作的数
        public bool Finish, Afuhao,Bfuhao, Adian,Bdian,AgainJudge;
        /*
         * Finish：本次运算完成标志，用于下次清空屏幕
         * Fu:负号使用的标记，当第一次点击±时，会出现负号，第二次会消失
         * Dian：点使用的标记，点只能使用一次
         */
                
        public string Date="";//用于保存所有的当前运算
        public char Key;//确定运算符
        //初始化
        public void Init()
        {
            A = B = INF;
            AgainJudge = Finish = Afuhao = Bfuhao = Adian = Bdian = false;
            if (Result.Text != "")
            { 
                Date += "-----------------------\r\n" + Judge.Text +" = "+ Result.Text+"\r\n";
            }
            Judge.Text = "0";
            Result.Text = "";
           
        }
        //BackSpace
        public void BackSpace()
        {
            if ((Judge.Text != "" && !Finish)|| AgainJudge) Judge.Text = Judge.Text.Remove(Judge.Text.Length - 1);
            
        }
        public void DateBackSpace()
        {
            Date = Date.Remove(Date.Length - 1);
        }
        //Last字符
        public char FirstLast()
        {
            if (Judge.Text.Length > 0) return Judge.Text[Judge.Text.Length - 1];
            else return '0';
            
        }
        public char SecondLast()
        {
            if (Judge.Text.Length > 1) return Judge.Text[Judge.Text.Length - 2];
            else return '0';
        }
        //数字0
        private void Num0_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }//如果已经完成了一次计算，运行下次计算要初始化
            if (A != INF && FirstLast() == ' ') { Judge.Text += '0'; }
            else if (FirstLast() == '0' && SecondLast() == '-') { }
            else if (A == INF)
            {
                if (Judge.Text != "0") { Judge.Text += '0';}
            }
            else if ((FirstLast() > '0' && FirstLast() <= '9') || (FirstLast() == '0' && SecondLast() != ' ')) { Judge.Text += '0'; }
            else if (FirstLast() == '.'||FirstLast()=='-') { Judge.Text += '0'; }
        }
        private void Num0_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num0.BackColor = Color.Gainsboro;
        }

        private void Num0_MouseLeave(object sender, EventArgs e)
        {
            this.Num0.BackColor = TransparencyKey;
        }
        
        //数字1
        private void Num1_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if(Judge.Text=="0")Judge.Text = "1";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '1'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '1'; }
            else Judge.Text += '1';

        }
        private void Num1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num1.BackColor = Color.Gainsboro;
        }

        private void Num1_MouseLeave(object sender, EventArgs e)
        {
            this.Num1.BackColor = TransparencyKey;
        }
        
        //数字2
        private void Num2_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "2";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '2'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '2'; }
            else Judge.Text += '2';
        }

        private void Num2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num2.BackColor = Color.Gainsboro;
        }

        private void Num2_MouseLeave(object sender, EventArgs e)
        {
            this.Num2.BackColor = TransparencyKey;
        }
        
        //数字3
        private void Num3_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "3";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '3'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '3'; }
            else Judge.Text += '3';
        }

        private void Num3_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num3.BackColor = Color.Gainsboro;
        }

        private void Num3_MouseLeave(object sender, EventArgs e)
        {
            this.Num3.BackColor = TransparencyKey;
        }
        //数字4
        private void Num4_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "4";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '4'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '4'; }
            else Judge.Text += '4';
        }
        private void Num4_MouseLeave(object sender, EventArgs e)
        {
            this.Num4.BackColor = Color.Transparent;
        }

        private void Num4_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num4.BackColor = Color.Gainsboro;
        }
        //数字5
        private void Num5_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "5";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '5'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '5'; }
            else Judge.Text += '5';
        }

        private void Num5_MouseLeave(object sender, EventArgs e)
        {
            this.Num5.BackColor = Color.Transparent;
        }

        private void Num5_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num5.BackColor = Color.Gainsboro;
        }
        //数字6
        private void Num6_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "6";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '6'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '6'; }
            else Judge.Text += '6';
        }

        private void Num6_MouseLeave(object sender, EventArgs e)
        {
            this.Num6.BackColor = Color.Transparent;
        }

        private void Num6_MouseMove(object sender, MouseEventArgs e)
        {
            this.Num6.BackColor = Color.Gainsboro;
        }
        //数字7
        private void Num7_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "7";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '7'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '7'; }
            else Judge.Text += '7';
        }

        private void Num7_MouseLeave(object sender, EventArgs e)
        {
            Num7.BackColor = Color.Transparent;
        }

        private void Num7_MouseMove(object sender, MouseEventArgs e)
        {
            Num7.BackColor = Color.Gainsboro;
        }
        //数字8
        private void Num8_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "8";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '8'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '8'; }
            else Judge.Text += '8';
        }

        private void Num8_MouseLeave(object sender, EventArgs e)
        {
            Num8.BackColor = Color.Transparent;
        }

        private void Num8_MouseMove(object sender, MouseEventArgs e)
        {
            Num8.BackColor = Color.Gainsboro;
        }
        //数字9
        private void Num9_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (Judge.Text == "0") Judge.Text = "9";
            else if (FirstLast() == '0' && SecondLast() == '-') { BackSpace(); Judge.Text += '9'; }
            else if (FirstLast() == '0' && SecondLast() == ' ') { BackSpace(); Judge.Text += '9'; }
            else Judge.Text += '9';
        }

        private void Num9_MouseLeave(object sender, EventArgs e)
        {
            Num9.BackColor = Color.Transparent;
        }

        private void Num9_MouseMove(object sender, MouseEventArgs e)
        {
            Num9.BackColor = Color.Gainsboro;
        }
        //正负号
        private void 正负号_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if ((FirstLast() < '0' || FirstLast() > '9') && FirstLast() != '.')//前面不能是任何数字或者 .  ，其他均可
            {
                if (!Afuhao && A == INF)
                {
                    Judge.Text += '-';
                    Afuhao = true;
                }
                else if (!Bfuhao && A != INF)
                {
                    Judge.Text += '-';
                    Bfuhao = true;
                }
            }
            else if (Judge.Text == "0") { Judge.Text = "-"; Afuhao = true; }
        }

        private void 正负号_MouseMove(object sender, MouseEventArgs e)
        {
            this.正负号.BackColor = Color.Gainsboro;
        }

        private void 正负号_MouseLeave(object sender, EventArgs e)
        {
            this.正负号.BackColor = TransparencyKey;
        }
        //点
        private void Dian1_Click(object sender, EventArgs e)
        {
            if (FirstLast()>='0'&&FirstLast()<='9')//不能出现-.
            {
                if (A == INF && !Adian)//如果现在是A，并且 . 没有使用过
                {
                    Judge.Text += '.'; Adian = true;
                }
                if (A != INF && !Bdian)//如果现在是B，并且 . 没有使用过
                {
                    Judge.Text += '.'; Bdian = true;
                }
                //只能使用一次
            }
        }

        private void Dian1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Dian1.BackColor = Color.Gainsboro;
        }

        private void Dian1_MouseLeave(object sender, EventArgs e)
        {
            this.Dian1.BackColor = TransparencyKey;
        }
        //加号
        private void Add_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF && B == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text += " + ";
            }
            else if (A != INF && B != INF)
            {
                Judge.Text += " + ";
                AgainJudge = true;
            }
            Key = '+';
        }

        private void Add_MouseMove(object sender, MouseEventArgs e)
        {
            this.Add.BackColor = Color.Gainsboro;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            this.Add.BackColor = TransparencyKey;
        }
        //减号
        private void Remove_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF && B == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text += " - ";
            }
            else if (A != INF && B != INF)
            {
                Judge.Text += " - ";
                AgainJudge = true;
            }
            Key = '-';
        }

        private void Remove_MouseLeave(object sender, EventArgs e)
        {
            Remove.BackColor = Color.Transparent;
        }

        private void Remove_MouseMove(object sender, MouseEventArgs e)
        {
            Remove.BackColor = Color.Gainsboro;
        }
        //乘号
        private void Multiply_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF && B == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text += " * ";
            }
            else if (A != INF && B != INF)
            {
                Judge.Text += " * ";
                AgainJudge = true;
            }
            Key = '*';
        }

        private void Multiply_MouseLeave(object sender, EventArgs e)
        {
            Multiply.BackColor = Color.Transparent;
        }

        private void Multiply_MouseMove(object sender, MouseEventArgs e)
        {
            Multiply.BackColor = Color.Gainsboro;
        }
        //除号
        private void Divide_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF && B == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text += " ÷ ";
            }
            else if (A != INF && B != INF)
            {
                Judge.Text += " ÷ ";
                AgainJudge = true;
            }
            Key = '÷';
        }
        private void Divide_MouseLeave(object sender, EventArgs e)
        {
            this.Divide.BackColor = Color.Transparent;
        }

        private void Divide_MouseMove(object sender, MouseEventArgs e)
        {
            this.Divide.BackColor = Color.Gainsboro;
        }
        //Mod
        private void 百分_Click_1(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF && B == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text += " % ";
            }
            else if (A != INF && B != INF)
            {
                Judge.Text += " % ";
                AgainJudge = true;
            }
            Key = '%';
        }
        private void 百分_MouseMove(object sender, MouseEventArgs e)
        {
            this.百分.BackColor = Color.Gainsboro;
        }

        private void 百分_MouseLeave(object sender, EventArgs e)
        {
            this.百分.BackColor = Color.Transparent;
        }
        //等于
        private void Dengyu1_Click(object sender, EventArgs e)
        {
            if (A != INF && (FirstLast() >= '0' && FirstLast() <= '9'))
            {
                if (B == INF || AgainJudge)
                {
                    int i = Judge.Text.LastIndexOf(' ') + 1;
                    double Temp = Convert.ToDouble(Judge.Text.Substring(i, Judge.Text.Length - i));
                    if (A!=INF) { if(Temp!=A||!Finish)B = Temp;}
                }
                if (Result.Text == "") { Result.Text = "= "; }
                else Result.Text += " = ";
                switch (Key)
                {
                    case '+': A += B; break;
                    case '-': A -= B; break;
                    case '*': A *= B; break;
                    case '÷': A /= B; break;
                    case '%': A %= B; break;
                }
                Result.Text = A.ToString();
                Finish = true;
            }
        }

        private void Dengyu1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Dengyu1.BackColor = Color.Gainsboro;
        }

        private void Dengyu1_MouseLeave(object sender, EventArgs e)
        {
            this.Dengyu1.BackColor = Color.Transparent;
        }
        //根号
        private void 根号_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text = "√" + A.ToString();
                Result.Text = "= ";
                Result.Text += Convert.ToString(System.Math.Sqrt(A));
                Finish = true;
            }

        }

        private void 根号_MouseMove(object sender, MouseEventArgs e)
        {
            this.根号.BackColor = Color.Gainsboro;
        }

        private void 根号_MouseLeave(object sender, EventArgs e)
        {
            this.根号.BackColor = Color.Transparent;
        }
        //平方
        private void 平方_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text =A.ToString() + " * " + A.ToString();
                Result.Text = "= ";
                Result.Text += Convert.ToString(A * A);
                Finish = true;
            }
        }
        private void 平方_MouseMove(object sender, MouseEventArgs e)
        {
            this.平方.BackColor = Color.Gainsboro;
        }

        private void 平方_MouseLeave(object sender, EventArgs e)
        {
            this.平方.BackColor = Color.Transparent;
        }
        //分号
        private void 分号_Click(object sender, EventArgs e)
        {
            if (Judge.Text != "" && A == INF)
            {
                A = Convert.ToDouble(Judge.Text);
                Judge.Text = "1/" + A.ToString();
                Result.Text = "= ";
                Result.Text += Convert.ToString(1 / A);
                Finish = true;
            }
        }
        private void 分号_MouseMove(object sender, MouseEventArgs e)
        {
            this.分号.BackColor = Color.Gainsboro;
        }

        private void 分号_MouseLeave(object sender, EventArgs e)
        {
            this.分号.BackColor = Color.Transparent;
        }
        //Time
        private void Time_MouseLeave(object sender, EventArgs e)
        {
            Time.Text = "Time";
        }

        private void Time_MouseMove(object sender, MouseEventArgs e)
        {
            Time.Text = System.DateTime.Now.ToString("hh:mm");
        }
        //Exit
        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("您确定要关闭我吗？", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 计算器_Load(object sender, EventArgs e)
        {
            Init();
            Explain.Text = "Mj_Counter";

        }
        //CE
        private void CE_1(object sender, EventArgs e)
        {
            Init();
        }

        private void CE_MouseMove(object sender, MouseEventArgs e)
        {
            this.CE.BackColor = Color.Gainsboro;
        }

        private void CE_MouseLeave(object sender, EventArgs e)
        {
            this.CE.BackColor = Color.Transparent;
        }
        //Random
        Random Temp = new Random(10000);
        private void Random_Click(object sender, EventArgs e)
        {
            if (Finish && !AgainJudge) { Init(); }
            if (!AgainJudge)
            {
                if(Judge.Text!="0")Judge.Text += Temp.Next(10000).ToString();
                else Judge.Text = Temp.Next(10000).ToString();
            }
           
        }
        private void Random_MouseMove(object sender, MouseEventArgs e)
        {
            this.Random.BackColor = Color.Gainsboro;
        }

        private void Random_MouseLeave(object sender, EventArgs e)
        {
            this.Random.BackColor = Color.Transparent;
        }
        //backspace
        private void backspace_Click(object sender, EventArgs e)
        {
            BackSpace();
        }

        private void backspace_MouseMove(object sender, MouseEventArgs e)
        {
            this.backspace.BackColor = Color.Gainsboro;
        }

        private void backspace_MouseLeave(object sender, EventArgs e)
        {
            this.backspace.BackColor = Color.Transparent;
        }
        //颜色栏
        Random Val = new Random(255);
        private void timer1_Tick(object sender, EventArgs e)
        {
            FullColor.BackColor = Color.FromArgb(Val.Next(255), Val.Next(255), Val.Next(255));
            if (!Change)
            {
                Explain.Text = "多次计算\r\n后续计算\r\n送我上去\r\n即可关闭~";
                Change = true;
            }
            else
            {
                Explain.Text = "1+2=3=5\r\n1+2=3*4=\r\n12=48+1=49\r\n=50*2=100~";
                Change = false;
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            MessageBoxButtons Ok=MessageBoxButtons.OK;
            if (Date == "") { MessageBox.Show("您还没有进行任何计算。"); }
            else MessageBox.Show(Date, "查看记录", Ok);
        }
        //Anthor
        private void Anthor_MouseMove(object sender, MouseEventArgs e)
        {
            Anthor.Text = " 马进 "; 
        }

        private void Anthor_MouseLeave(object sender, EventArgs e)
        {
            Anthor.Text = "Anthor";
        }
        //快捷菜单
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Judge.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Judge.Paste();
        }

        private void 裁剪ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Judge.Cut();
        }
        //浮动小标签
        int deltX = 8;
        int deltY = 6;
        bool Change = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //一直摁等号，多线程运行
            Explain.Left += deltX;
            Explain.Top += deltY;
            if (Explain.Top < 0 || Explain.Top + Explain.Height > this.Height-70)
            {
                deltY = -deltY;
            }
            if (Explain.Left < 0 || Explain.Left + Explain.Width > this.Width-10)
            {
                deltX = -deltX;
            }
            
        }
        private void Explain_MouseMove(object sender, MouseEventArgs e)
        {
            Explain.Top -= 2;
        }
    }
}
