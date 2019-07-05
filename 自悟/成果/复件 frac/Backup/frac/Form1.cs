using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace frac
{
    public partial class screen : Form
    {
        Bitmap bm;// = new Bitmap(@"leaking.bmp");
        public screen()
        {
            InitializeComponent();
           // StreamWriter sw = new StreamWriter("a.txt");
            
            bm = new Bitmap(@"leaking.bmp");//打开Logo文件
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
           // MessageBox.Show("本机器的分辨率是" + rect.Width.ToString() + "*" + rect.Height.ToString());
            pictureBox1.Width = rect.Width;
            pictureBox1.Height = rect.Height;
            this.Width = rect.Width;
            this.Height = rect.Height;
           // MessageBox.Show("本机器的分辨率是" + this.Width.ToString() + "*" + this.Height.ToString());
        }


        #region 公共变量！最好打开看看，否则根本看不懂 未修改

        //一堆公共变量声明

        //画布大小
        private int presetWidth = 640;
        private int presetHeight = 480;


        //四个重要参数，用于放大缩小！描述的是 分形图的逻辑大小，跟实际画布大小完全不一样。
        private static decimal pmin = -2; private static decimal pmax = 2;
        private static decimal qmin = -2; private static decimal qmax = 2;



        //三原色，颜色分量
        private int red; private int green; private int blue;

        //用来指定 绘制图形的 种类，即 绘制哪种图形，取值为 1 2 3 4 5
        private static int method;

 


        #region 以下是牛顿迭代法的专有变量！！！！

        private int RAND_MAX = 0x7fff;

        #region  colorMover的各种变量
        private static double m_kR;  //颜色变化强度
        private static double m_kG;
        private static double m_kB;
        private static double m_R0;  //初始颜色
        private static double m_G0;
        private static double m_B0;

        private static int csMaxColorRoundValue = 512;
        #endregion

        private static double m_ColorK1;
        private static double m_ColorK2;
        private static double m_ColorK3;
        private static bool m_IsExtract3Ex;
        private static long m_ExtractNumber;
        private static bool m_isTanRev;
        private static long m_iteratInc;
        private static int rand = 32000;

        static ulong[] colorRound_table = new ulong[(csMaxColorRoundValue + 1) * 2];


        #endregion

   

        #endregion



        #region 总函数，各种事件，按钮事件，文本框事件，菜单事件 略微修改以适应程序

      
      


        //总函数，最外层，囊括所有算法
        private void PaintFract(int N)
        {


           // SetWindowScale();//初始化画布大小
            Creat_colorRound_table();//初始化“首尾相接”的色环数组！此色环非一般色环

            switch (N)
            {
               
                case 5: DrawNewton_Beta(); break;
                default: MessageBox.Show("您还没选择算法呢吧？如果不是就赶紧通知我"); break;
            }

            
        }


       

        //牛顿迭代参数！！！！！
    




        #endregion




        #region 主要算法，绘制图形用！ 修改过


        static Random rd = new Random();//随机化logo出现的位置

        private void DrawNewton_Beta()
        {
            int xo = rd.Next()%1000, yo = rd.Next()%600;
            presetHeight = pictureBox1.Height;
            presetWidth = pictureBox1.Width;
            Bitmap bmp = new Bitmap(presetWidth, presetHeight);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, ClientRectangle); //初始化，都刷成白色
            Random randrand = new Random();

            double dp = (double)(pmax - pmin) / presetWidth;//很典型的逃逸时间算法，这个是比例因子
            double dq = (double)(qmax - qmin) / presetHeight;
            for (int x = 0; x < presetWidth; ++x)//这两重循环遍历了屏幕上所有点。
            {
                //滚动条功能
               
               // Application.DoEvents();


                double rx0 = x * dp + (double)pmin;
                for (int y = 0; y < presetHeight; ++y)
                {
                    double ry0 = y * dq + (double)qmin;
                    double dL1, dL2, dL3;
                    if (m_IsExtract3Ex)//这个bool变量在update（）里面，我猜测应该是判断否用3次方程迭代
                        getExtractByNewton_3Ex(rx0, ry0, m_iteratInc, out dL1, out dL2, out dL3);//用牛顿三次方程迭代
                    else
                        getExtractByNewton(rx0, ry0, m_ExtractNumber, m_iteratInc, m_isTanRev, out dL1, out dL2, out dL3);//这个N次方程，指定次数的迭代。
                    //得到颜色并且画点！
                    GetColor(dL1, dL2, dL3, out red, out green, out blue);
                    //增加的代码，将Logo混入分形图形中
                    if (x > xo && y > yo)
                    {
                        Color mix = bm.GetPixel((x - xo) % 1200, (y - yo) % 700);
                        red &= mix.R;
                        green &= mix.G;
                        blue &= mix.B;
                    }
                    Color c = Color.FromArgb(red, green, blue);
                    bmp.SetPixel(x, y, c);
                }
                //本来想作出滚屏效果，但是没有实现，可能时因为显示缓冲或编译优化导致失效
                if (x % 100 == 0)
                {
                    pictureBox1.Image = bmp;
                    label1.Text = System.DateTime.Now.ToString();
                   // Thread.Sleep(1000);
                }
            }
           


        }

        #endregion



        #region 牛顿迭代专有的相关函数，包括 复数加减乘除，平方，N次方等等 未修改

        //ColorMover颜色初始值的初始化函数
        void CColorMoverInti(double kMin, double kMax)
        //参数取值！第一个不到50 第二个 不到90  
        {
            //颜色变化强度！
            m_kR = rand * (1.0 / RAND_MAX) * (kMax - kMin) + kMin; //40多到90之间的随机浮点数
            m_kG = rand * (1.0 / RAND_MAX) * (kMax - kMin) + kMin;
            m_kB = rand * (1.0 / RAND_MAX) * (kMax - kMin) + kMin;

            //初始颜色
            m_R0 = rand * (1.0 / RAND_MAX) * csMaxColorRoundValue; //0到512之间的随机浮点数
            m_G0 = rand * (1.0 / RAND_MAX) * csMaxColorRoundValue;
            m_B0 = rand * (1.0 / RAND_MAX) * csMaxColorRoundValue;

        }




        private void Scene_Update(ulong StepTime_ms)//对一大堆随机值 进行更新操作！其中包括 颜色系数，迭代方程的次数
        {

            int[] ExtractNumberCountList = new int[11] { 3, 3, 3, 3, 4, 4, 5, 5, 6, 7, 8 };
            m_ExtractNumber = ExtractNumberCountList[rand % 11];//用于指定方程的次数！！！！居然在这里！
            m_IsExtract3Ex = (m_ExtractNumber == 3) && (rand > (RAND_MAX / 2));//用于指定 方程 是否是 三次方程！ 
            m_ColorK2 = 0.6;
            m_ColorK3 = m_ColorK2;
            m_ColorK1 = m_ColorK2 * m_ColorK2 * m_ColorK2;//这三个变量有关颜色！很神奇的变量，往后看 


            if (rand < (RAND_MAX / 2)) m_ColorK1 *= -1;
            if (rand < (RAND_MAX / 2)) m_ColorK2 *= -1;
            if (rand < (RAND_MAX / 2)) m_ColorK3 *= -1;//随机正负号！

            double r = 1.0 / (double)(1 << (int)(m_ExtractNumber - 3));
            r = Math.Pow(r, 0.095);//r大概在0.8到1之间
            m_ColorK1 *= r;
            m_ColorK2 *= r;
            m_ColorK3 *= r;//这又是干嘛呢？
            CColorMoverInti(50 * r, 90 * r);//初始化颜色        
            m_isTanRev = (rand > (RAND_MAX / 4));//一个概率 真假值，肯定是用于随机事件  
            if (m_isTanRev)//用这个来决定 牛顿迭代的循环次数！！！  
            {
                if (m_ExtractNumber == 3)
                    m_iteratInc = 1 + (rand % 6);
                else
                    m_iteratInc = 1 + (rand % 4);
            }
            else
                m_iteratInc = 1 + (rand % 3);
        }



        #region 复数四则运算和复角运算。永远都不变的函数，不用管
        const double eValue = 0.01;

        //重写Log函数，用于提高运算速度
        private double mLog(double x)
        {
            if (x < eValue)
            {
                x = Math.Pow(x * (1.0 / eValue), 0.3) * eValue;
            }
            return Math.Log(x);
        }


        //平方
        private double sqr(double x) { return x * x; }
        //X的 N次方！
        private double intpow(double x, int N)
        {
            switch (N)
            {
                case 0: { return 1; };
                case 1: { return x; };
                case 2: { return x * x; };
                case 3: { return x * x * x; };
                case 4: { return sqr(x * x); };
                case 5: { return sqr(x * x) * x; };
                case 6: { return sqr(x * x * x); };
                default:
                    {
                        long half = N >> 1;//对应的二进制右移一位！其实就是除以2
                        double xh = sqr(intpow(x, (int)half));
                        if ((N & 1) == 0)
                            return xh;
                        else
                            return xh * x;
                    }
            }
        }


        //意思是把 复述平方！我学复动力系统图形生成之中的逃逸时间算法后才看明白
        void sqr(double x, double y, out double out_x, out double out_y)
        {
            out_x = x * x - y * y;
            out_y = 2 * x * y;
        }


        //复述乘法
        void mul(double x0, double y0, double x1, double y1, out double out_x, out double out_y)
        {
            out_x = x0 * x1 - y0 * y1;
            out_y = x0 * y1 + x1 * y0;
        }


        //复数的N次方！！！
        void pow(double x, double y, long N, out double out_x, out double out_y)
        {
            switch (N)
            {
                case 0: { out_x = 1; out_y = 0; } break;
                case 1: { out_x = x; out_y = y; } break;
                case 2: { sqr(x, y, out out_x, out out_y); } break;
                case 3: { double x1, y1; sqr(x, y, out x1, out y1); mul(x, y, x1, y1, out out_x, out out_y); } break;
                case 4: { double x1, y1; sqr(x, y, out x1, out y1); sqr(x1, y1, out out_x, out out_y); } break;
                case 5: { double x1, y1, x2, y2; sqr(x, y, out x1, out y1); sqr(x1, y1, out x2, out y2); mul(x, y, x2, y2, out out_x, out out_y); } break;
                case 6: { double x1, y1, x2, y2; sqr(x, y, out x1, out y1); sqr(x1, y1, out x2, out y2); mul(x1, y1, x2, y2, out out_x, out out_y); } break;
                default:
                    {
                        long half = N >> 1;
                        double xh, yh;
                        pow(x, y, half, out xh, out yh);
                        if ((N & 1) == 0)
                            sqr(xh, yh, out out_x, out out_y);
                        else
                        {
                            double xsqr, ysqr;
                            sqr(xh, yh, out xsqr, out ysqr);
                            mul(x, y, xsqr, ysqr, out out_x, out out_y);
                        }
                    } break;
            }
        }

        //显然是复数除法运算
        void div(double x0, double y0, double x1, double y1, ref double out_x, ref double out_y)
        {
            double r = 1 / (x1 * x1 + y1 * y1 + 1e-300);
            out_x = (x0 * x1 + y0 * y1) * r;
            out_y = (y0 * x1 - x0 * y1) * r;
        }


        //这个跟 复角有关
        const double PI = 3.1415926535897932384626433832795;
        double asin2(double x, double y, double r)
        {
            double seta = Math.Asin(y / r);
            if (x >= 0)
                return seta;
            else if (y >= 0)
                return PI - seta;
            else
                return -PI - seta;
        }


        //“用牛顿法提取”？？注意，也是 三次方
        void getExtractByNewton_3Ex(double x0, double y0, long iteratInc, out double dL1, out double dL2, out double dL3)
        {
            x0 *= 0.75; y0 *= 0.75;
            //Z^3-1=0
            double x1 = x0, y1 = y0;
            for (long i = 0; i < iteratInc; ++i)
            {
                x0 = x1; y0 = y1;
                getNextPos_3Ex(x0, y0, ref x1, ref y1);//第三重循环
            }
            dL1 = mLog(Math.Abs(x1 - x0) * Math.Abs(y1 - y0)) * 0.6;
            dL2 = mLog(sqr(x1 - x0) + sqr(y1 - y0)) * 0.6;
            getNextPos_3Ex(x1, y1, ref x0, ref y0);
            dL3 = mLog(Math.Abs(x1 - x0) + Math.Abs(y1 - y0)) * 2.0;
        }


        //这是牛顿三次方程的迭代 3Ex表示三次方
        private void getNextPos_3Ex(double x0, double y0, ref double out_x, ref double out_y)
        {
            double x2 = x0 * x0; double y2 = y0 * y0;
            double r = (1.0 / 6) / sqr(x2 + y2 + 1e-300);
            double a = x2 - y2;
            double b = x0 * y0 * 2;
            out_x = -y0 + (a - b) * r;
            out_y = x0 - (a + b) * r;
        }


        //可能是计算下一个坐标的函数
        void getNextPos(double x0, double y0, long N, bool isTanRev, ref double out_x, ref double out_y)
        {
            //Z^N-1=0
            double seta;
            if (isTanRev) seta = Math.Atan2(x0, y0); else seta = Math.Atan2(y0, x0);
            double r = Math.Sqrt(x0 * x0 + y0 * y0);
            r = r * (N - 1) / N;
            double sl = 1.0 / (N * intpow(r, (int)(N - 1)));
            out_x = (r * Math.Cos(seta) + sl * Math.Cos((1 - N) * seta));
            out_y = (r * Math.Sin(seta) + sl * Math.Sin((1 - N) * seta));


        }


        //这个是 N次方程，也是“用牛顿法提取”，提取出dL1 dL2 dL3三个值。
        void getExtractByNewton(double x0, double y0, long N, long iteratInc, bool isTanRev, out double dL1, out double dL2, out double dL3)
        {
            //Z^N-1=0
            double x1 = x0, y1 = y0;
            for (long i = 0; i < iteratInc; ++i)//万恶的第三重循环，原来在这里！
            {
                x0 = x1; y0 = y1;
                getNextPos(x0, y0, N, isTanRev, ref x1, ref y1);//典型的逃逸时间算法的内层循环。
            }//得到x1 y1和x0 y0的值，用于下面的计算

            dL1 = mLog(Math.Abs(x1 - x0) * Math.Abs(y1 - y0)) * 0.6;
            dL2 = mLog(sqr(x1 - x0) + sqr(y1 - y0)) * 0.6;

            getNextPos(x1, y1, N, isTanRev, ref x0, ref y0);
            dL3 = mLog(Math.Abs(x1 - x0) + Math.Abs(y1 - y0)) * 2.0;
        }



        #endregion


        //通过dL1 dL2 dL3得到 相对应的颜色信息，这是最具艺术性的一个函数。
        //请问！！这个是虚函数吗？一直没用过，只是在传说中看到过
        private void GetColor(double dL1, double dL2, double dL3, out int red, out int green, out int blue)
        {
            double kR = dL1 * m_ColorK1 + dL2 * m_ColorK2 - dL3 * m_ColorK3;//这个配比很奇怪！不懂为啥这样
            double kG = dL1 * m_ColorK1 - dL2 * m_ColorK2 + dL3 * m_ColorK3;
            double kB = -dL1 * m_ColorK1 + dL2 * m_ColorK2 + dL3 * m_ColorK3;

            red = (int)(getColor(m_R0, m_kR, kR));
            green = (int)(getColor(m_G0, m_kG, kG));
            blue = (int)getColor(m_B0, m_kB, kB);

        }


        private static ulong getColor(double Color0, double k, double Gene)
        {

            uint rd = (uint)(Color0 + k * Gene);
            rd = rd % (uint)csMaxColorRoundValue;

            ulong temp = colorRound_table[rd];//返回的正好是 0到255之间的数，见数组的初始化函数！
            return temp;
        }



        private long round_color(int x)
        {
            if (x < 0) x = -x;//取值变成  513到0，再到512。首尾相接
            while (x > csMaxColorRoundValue) x -= csMaxColorRoundValue;//最后x范围是 1 512 到0 再到512
            const double PI = 3.1415926535897932384626433832795;
            double rd = (Math.Sin(x * (2.0 * PI / csMaxColorRoundValue)) + 1.1) / 2.1;//色环！正好2pi转了一圈！
            //rd取值从 -0.1到1到0.1到1到-0.1
            long ri = (long)(rd * 255 + 0.5);
            //long ri=abs(x-csMaxColorRoundValue/2);
            if (ri < 0) return 0;
            else if (ri > 255) return 255;
            else return ri;
        }


        private void Creat_colorRound_table()
        {
            for (int i = 0; i < (csMaxColorRoundValue + 1) * 2; i++)//首尾相接！为了柔和！太强大了！哈哈，明白了
                colorRound_table[i] = (ulong)round_color(i - (csMaxColorRoundValue + 1));//取值是 -513到+510！！太强大了！
        }//i是0到1023


        #endregion

   
    
         private void draw()
        {

            //这一部分为添加代码，每次绘制之前需要重置这些变量，否则永远时一个图形
                qmin = (decimal)-1.37;
                qmax = (decimal)-qmin + (decimal)0.000001;
                pmin = (qmax * (decimal)pictureBox1.Width) / (decimal)pictureBox1.Height;
                pmax = (decimal)-pmin + (decimal)0.000002;
                method = 5;
                Random randrand = new Random();
                rand = randrand.Next(0, 0x7fff);
                Scene_Update(0);
          
            PaintFract(method);
        }
      


      

        private void pictureBox1_Click(object sender, EventArgs e)
        {//鼠标单击结束程序
            System.Environment.Exit(0);
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {//Timer空间 
            label1.Text = System.DateTime.Now.ToString();
            draw();
            i++;
            string s = "NO"+i+"";
            //如果需要保存结果请去掉下面这一行的注释
            //pictureBox1.Image.Save(s, System.Drawing.Imaging.ImageFormat.Bmp); 
        }
    }
}
