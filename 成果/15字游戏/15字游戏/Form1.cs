using System;
using System.Windows.Forms;

namespace _15字游戏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int N = 4; //按钮的行、列数
        Button[,] buttons = new Button[N, N]; //按钮的数组


        static int Count = 0;
        //打乱顺序
        void Shuffle()
        {
            //多次随机交换两个按钮
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(N);
                int b = rnd.Next(N);
                int c = rnd.Next(N);
                int d = rnd.Next(N);
                Swap(buttons[a, b], buttons[c, d]);
            }
        }
        //生成所有的按钮
        void GenerateAllButtons()
        {
            int x0 = 100, y0 = 10, w = 45, d = 50;
            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                {
                    int num = r * N + c;
                    Button btn = new Button();
                    btn.Text = (num + 1).ToString();
                    btn.Top = y0 + r * d;
                    btn.Left = x0 + c * d;
                    btn.Width = w;
                    btn.Height = w+50;
                    btn.Visible = true;
                    btn.Tag = r * N + c; //这个数据用来表示它所在行列位置

                    //注册事件
                    btn.Click += Btn_Click;

                    buttons[r, c] = btn; //放到数组中
                    this.Controls.Add(btn); //加到界面上
                }
            buttons[N - 1, N - 1].Visible = false; //最后一个不可见
                                                   //打乱顺序
            Shuffle();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; //当前点中的按钮
            Button blank = FindHiddenButton(); //空白按钮

            //判断是否与空白块相邻，如果是，则交换
            if (IsNeighbor(btn, blank))
            {
                Swap(btn, blank);
                blank.Focus();
            }

            //判断是否完成了
            if (ResultOk())
            {
                MessageBox.Show("ok");
            }
        }

        //交换两个按钮
        void Swap(Button btna, Button btnb)
        {
            string t = btna.Text;
            btna.Text = btnb.Text;
            btnb.Text = t;

            bool v = btna.Visible;
            btna.Visible = btnb.Visible;
            btnb.Visible = v;
        }
        //按钮点击事件处理
      
        Button FindHiddenButton()
        {
            for (int r = 0; r < N; ++r)
            {
                for (int c = 0; c < N; ++c)
                {
                    if (!buttons[r, c].Visible)
                    {
                        return buttons[r, c];
                    }
                }
            }
            return null;
        }
        //判断是否相邻
        bool IsNeighbor(Button btnA, Button btnB)
        {
            int a = (int)btnA.Tag; //Tag中记录是行列位置
            int b = (int)btnB.Tag;
            int r1 = a / N, c1 = a % N;
            int r2 = b / N, c2 = b % N;

            if (r1 == r2 && (c1 == c2 - 1 || c1 == c2 + 1) //左右相邻
                            || c1 == c2 && (r1 == r2 - 1 || r1 == r2 + 1))
                return true;
            return false;
        }
        bool ResultOk()
        {
            for (int r = 0; r < N; ++r)
            {
                for (int c = 0; c < N; ++c)
                {
                    if (buttons[r, c].Text!= (r * N + c + 1).ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
       
      

        private void Form1_Load(object sender, EventArgs e)
        {
            //产生所有按钮
            GenerateAllButtons();
        }

       
    }
}
