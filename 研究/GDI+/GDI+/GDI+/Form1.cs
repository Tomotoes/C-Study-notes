using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (Graphics G = this.CreateGraphics())
            //{

            //    Pen pen = new Pen(Color.Red, 2);

            //    pen.DashCap= DashCap.Round;

            //    pen.DashStyle = DashStyle.DashDot;

            //    pen.Alignment = PenAlignment.Center;

            //    pen.StartCap = LineCap.Round;

            //    pen.EndCap = LineCap.Square;

            //    G.DrawLine(pen, new Point(0, 10), new Point(200, 300));

            //    Brush brush = new SolidBrush(Color.FromName("Red"));

            //    Brush brush1 = new HatchBrush(HatchStyle.Cross, Color.Purple);

            //    G.DrawString("LLasdasdsad", new Font("宋体", 12, FontStyle.Bold), brush1, new PointF(40, 50));

            //    G.DrawEllipse(pen, new Rectangle(new Point(10, 20), new Size(10, 20)));

            //    Rectangle Juxing = new Rectangle(new Point(1, 2), new Size(4, 5));

            //    Point F = new Point(new Size(10, 20));

            //    //需要注意的每次 使用GDI+时 都要自己手动释放 不然会占用大量资源
            //    //并且 我发现 使用using 定义多个需要释放的对象 是件折磨人的事情
            //}
            ////也可以手动释放 G.Dispose();  或者 使用 try{} catch{G.Dispose(); 

            using (Graphics G = this.CreateGraphics())
            {
                FontFamily[] families = FontFamily.GetFamilies(G);
                Font font;
                string S;
                float Space = 0;
                foreach (FontFamily family in families)
                {
                    try
                    {
                        font = new Font(family, 16, FontStyle.Bold);
                        S = "This is the " + family.Name + "\r\n";
                        G.DrawString(S, font, Brushes.Red, new PointF(0, Space));
                        Space += font.Height+5;
                    }

                    catch { }
                }


            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);

            float x = g.VisibleClipBounds.Width;
            float y = g.VisibleClipBounds.Height;
            PointF[] pts = 
            { 
                new PointF(0,0), new PointF(x/2,0), 
                new PointF(x/2,y/2), new PointF(0,y/2)
            };
            Pen pen = new Pen(Color.Blue, 1.0F);
            g.ScaleTransform(0.8F, 0.8F);
            g.TranslateTransform(x / 2, y / 2 + 20);
            for (int i = 0; i < 36; i++)
            {
                g.DrawBeziers(pen, pts);
                g.DrawRectangle(pen, -x / 12, -y / 12, x / 6, y / 6);
                g.DrawEllipse(pen, -x / 4, -y / 3, x / 2, y * 2 / 3);
                g.RotateTransform(10);
            }
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddString(
                "字体轮廓",
                new FontFamily("方正舒体"),
                (int)FontStyle.Regular,
                80,
                new PointF(10, 20),
                new StringFormat());

            Brush brush = new LinearGradientBrush(
                    new PointF(0, 0), new PointF(Width, Height),
                    Color.Red, Color.Yellow);

            e.Graphics.DrawPath(Pens.Black, gp);
            e.Graphics.FillPath(brush, gp);

          //  Graphics g = e.Graphics;

      
            Point point = new Point(10, 10);
            Size sizeLine = new Size(0, 150);
            Size sizeOff = new Size(30, 0);

            pen = Pens.LimeGreen;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = SystemPens.MenuText;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = new Pen(Color.Red);
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen = new Pen(Color.Red, 8);
            g.DrawLine(pen, point += sizeOff, point + sizeLine);

            pen.DashStyle = DashStyle.Dash;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.DashStyle = DashStyle.Dot;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);

            pen.DashStyle = DashStyle.Solid;
            pen.StartCap = LineCap.Round;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
            pen.EndCap = LineCap.Triangle;
            g.DrawLine(pen, point += sizeOff, point + sizeLine);

            pen.DashPattern = new float[] { 0.5f, 1f, 1, 5f, 2f, 2.5f };
            g.DrawLine(pen, point += sizeOff, point + sizeLine);
        }

    }
}
