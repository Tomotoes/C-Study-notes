using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace 记事本
{
    public partial class 记事本 : Form
    {
        public 记事本()
        {
            InitializeComponent();
        }
/*-对象-*/  
   
        OpenFileDialog OpenFile = new OpenFileDialog();//打开文本实例化对象
        SaveFileDialog SaveFile = new SaveFileDialog();//保存文本实例化对象
        public string FileText;//保存打开文件的文本
        public string FilePath;//保存打开文件的路径
        public bool RTL;//判断RightToLeft的可操作性
        static int Count ;
        public string ExistSign;
        public bool CmpDraw;
        public bool Build;

        /*关键方法*/

        //加载窗体时，进行初始化
        private void 记事本_Load(object sender, EventArgs e)
        {
            Init(); 
            Main.Font = new Font(new FontFamily("宋体"),14,FontStyle.Regular);
            ExistSign = "‘'“”〈〉！＂（）／：；？﹕,·。" + '\n';
        }
        public void Init()
        {
            FilePath = FileText = "";
            Build = false;
            CO = Color.Black;
            Ca = false;
            CmpDraw = false;
            Draw.Enabled = false;
            Draw.Visible = false;
            RTL = false;
            Count = 0;
            FontSize = 2;
        }
        //判断是否用于保存文件
        public bool JudgeText()
        {
            if (Main.Text != "")//如果文本框存在文字
            {
                if (FileText != "")//如果文本框的文字是通过打开文本所得
                {
                    if (Main.Text != FileText)//如果修改了打开文本的文字
                    {
                        return true;
                    }
                    else return false;//如果没有修改
                }
                else return true;//如果文本框的文字是新建的
            }
            else return false;//如果文本框里没有字
        }
        public void Save()
        {
            SaveFile.FileName = "";
            SaveFile.RestoreDirectory = true;
            SaveFile.Filter = "文本文档(*.txt)|*.txt;*.xlsx|所有文件|*.*";
            SaveFile.ShowDialog();
            if (SaveFile.FileName != "")
            {
                Main.SaveFile(SaveFile.FileName, RichTextBoxStreamType.PlainText);
                FileText = Main.Text;
            }
        }
    
        public bool First()
        {
            if (JudgeText())
            {
                DialogResult D;
                //如果文本框的文字是通过新建所得，文本路径就指向当前文本路径
                FilePath = FilePath == "" ? System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) : FilePath;

                if (FilePath == System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop))
                {D = MessageBox.Show("是否将更改保存到" + FilePath + "\\无标题" + '?', "记事本", MessageBoxButtons.YesNoCancel);}
                else { D = MessageBox.Show("是否将更改保存到" + FilePath + '?', "记事本", MessageBoxButtons.YesNoCancel); }

                if (D == DialogResult.Yes)//选择保存
                {
                    //如果文本框的文字是新建所得，所以要选择文件名
                    if (FilePath == System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop))
                    { Save(); }
                    //如果文本框的文字是 打开文件所得，保存文件时，要保存到原来的文件
                    else {
                        Main.SaveFile(FilePath, RichTextBoxStreamType.PlainText);
                        FileText = Main.Text;
                    }
                    Build = true;
                    return false; 
                }
                else { if (D == DialogResult.Cancel)
                       {Build = true;return true;}
                       else { Build = false; return false; }
                }
            }return false;
        }

/*-文件选项-*/
       
        //新建
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            First();
            if (!Build||!JudgeText()) { if (!Build) { Init(); Main.Text = ""; } }
            if (Build) Build = false;
        }
        
        //打开
        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!First())
            {
                OpenFile.FileName = "";
                OpenFile.RestoreDirectory = true;
                OpenFile.Filter = "文本文档(*.txt)|*.txt;*.xlsx|所有文件|*.*";
                OpenFile.ShowDialog();
                if (OpenFile.FileName != "")
                {
                    Main.LoadFile(OpenFile.FileName, RichTextBoxStreamType.PlainText);
                    FilePath = OpenFile.FileName;
                    FileText = Main.Text;
                }
            }
           
        }
        
        //保存
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main.Text != "" && FileText == ""){Save();}
            else { First(); }
        }

        //另存为
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Main.Text!="")Save();
        }

        //退出
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


/*-编辑选项-*/

        //编辑选项打开时，进行不可选标记操作
        private void 编辑EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            撤消UToolStripMenuItem.Enabled = Main.CanUndo ? true : false;
            剪切TToolStripMenuItem.Enabled = Main.SelectedText != "" ? true : false;
            复制CToolStripMenuItem.Enabled = Main.SelectedText != "" ? true : false;
            删除AToolStripMenuItem.Enabled = Main.SelectedText != "" ? true : false;
            查找ToolStripMenuItem.Enabled = Main.Text != "" ? true : false;
            转到ToolStripMenuItem.Enabled = Main.Text != "" ? true : false;
            替换ToolStripMenuItem.Enabled = Main.Text != "" ? true : false;
        }
        
        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Undo();
        }
        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Cut();
        }
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Copy();
        }
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Paste();
        }
        private void 删除AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.Text = Main.Text.Remove(Main.SelectionStart, Main.SelectionLength);
        }
        private void 全选AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Main.SelectAll();
        }
        
        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main.Text != "")
            {
                SelectForm A = new SelectForm();
                A.B = this;
                A.TopMost = true;
                A.Show();
            }
        }


/*-右键菜单-*/

        //右键菜单打开时，进行不可选标记操作
        private void 右键菜单_Opening(object sender, CancelEventArgs e)
        {
            撤销ToolStripMenuItem.Enabled = Main.CanUndo ? true : false;
            剪切ToolStripMenuItem.Enabled = Main.SelectedText != "" ? true : false;
            复制CToolStripMenuItem1.Enabled = Main.SelectedText != "" ? true : false;
            删除DToolStripMenuItem.Enabled = Main.SelectedText != "" ? true : false;
            全选AToolStripMenuItem2.Enabled = Main.Text != "" ? true : false;
        }
        
        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Undo();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Main.Cut();
        }

        private void 复制CToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Main.Copy();
        }

        private void 粘贴PToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Main.Paste();
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.Text = Main.Text.Remove(Main.SelectionStart,Main.SelectionLength);
        }

        private void 全选AToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Main.SelectAll();
        }

        private void 从右到左阅读顺序RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!RTL) 
            { 
                Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                RTL = true;
            }
            else
            {
                Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
                RTL = false;
            }
        }
        bool Flag;
        char ch;
        private void Main_TextChanged(object sender, EventArgs e)
        {
            if (索引IToolStripMenuItem.Checked)
            {
                if (Main.Text == "")
                {
                    label1.Text = "行号: 0";
                    label2.Text = "列号: 0";
                    label3.Text = "字数: 0";
                }
                else
                {
                    Flag = false;
                    ch = Main.Text.Last();
                    foreach (var item in ExistSign)
                    {
                        if (ch == item) { Flag = true; break; }
                    }
                    if (!Flag) Count++;
                    label1.Text = "行号: " + Main.Lines.Count();
                    int index = Main.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
                    int col = Main.SelectionStart - index ;//SelectionStart得到光标所在位置的索引 减去 当前行第一个字符的索引 = 光标所在的列数（从0开始)
                    label2.Text = "列号: " + col.ToString();
                    label3.Text = "字数: " + Count.ToString();
                }
            }
        }

        //关闭窗体
        private void 记事本_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (First()) { e.Cancel = true; }
        }

        private void 时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, System.DateTime.Now.ToString());
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                Clipboard.SetData(DataFormats.Text, System.DateTime.Now.ToString());
                Main.Paste();
            }
        }

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.ShowDialog();
            if (Main.SelectedText != ""){Main.SelectionFont = FD.Font;}
            else { Main.Font = FD.Font; }
        }

        private void 自定义CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自定义CToolStripMenuItem.Checked)
            {
                Main.WordWrap  = 自定义CToolStripMenuItem.Checked = false;
                索引IToolStripMenuItem.Enabled  = true;
            }
            else
            {
                Main.WordWrap = 自定义CToolStripMenuItem.Checked = true;
                label3.Visible = label1.Visible = label2.Visible = false;
                索引IToolStripMenuItem.Enabled = 索引IToolStripMenuItem.Checked = false;
            } 
        }
     
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cd.ShowDialog();
            if (Main.SelectedText != "") { Main.SelectionColor = Cd.Color; }
            else { Main.ForeColor = Cd.Color; }
        }

        private void 背景颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cd.ShowDialog();
            Main.BackColor = Cd.Color;
        }

        private void 替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Main.Text != "")
            {
                ReplaceFrom A = new ReplaceFrom();
                A.B = this;
                A.TopMost = true;
                A.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //设置pageSetupDialog控件的Document属性，设置操作文档
            页面设置.Document = 打印;
            //启用边距
            this.页面设置.AllowMargins = true;
            //启用对话框的方向部分
            this.页面设置.AllowOrientation = true;
            //启用对话框的纸张部分
            this.页面设置.AllowPaper = true;
            //启用“打印机”按钮
            this.页面设置.AllowPrinter = true;
            //显示页面设置对话框
            this.页面设置.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PrintDialog A = new PrintDialog();
            A.ShowDialog();
        }
        static float FontSize ;
        Pen A = new Pen(Color.Black,FontSize);
        Image myImage = new Bitmap(504, 602); //根据pictureBox 大小
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CmpDraw)
            {
                if (Ca) A = new Pen(Draw.BackColor, FontSize);
                else A = new Pen(CO, FontSize);
                Graphics g = Graphics.FromImage(myImage);
                g.DrawRectangle(A, e.X, e.Y, 2, 2);
                Draw.Image = myImage;
            }
            
        }
        Button C = new Button();
        Button D = new Button();
        Button F = new Button();
        Button G = new Button();
        Button H = new Button();
        Button K = new Button();
        Button J = new Button();
        Label E = new Label();
        private void 绘画ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (绘画ToolStripMenuItem.Checked == false) { 绘画ToolStripMenuItem.Checked = true;}
            else { 绘画ToolStripMenuItem.Checked = false; End(); }
            if(绘画ToolStripMenuItem.Checked == true)
            {
                Init();
                Draw.Enabled = true;
                Draw.Visible = true;

                //背景颜色按钮
                C.Location = new Point(0, 487);
                C.Text = "背景颜色";
                C.ForeColor = Color.Black;
                C.BackColor = Color.Transparent;
                C.Click += C_Click;
                this.Controls.Add(C);
                C.BringToFront();

                //取消绘画
                D.Location = new Point(282, 487);
                D.Text = "退出绘画";
                D.ForeColor = Color.Black;
                D.BackColor = Color.Transparent;
                D.Click += D_Click;
                this.Controls.Add(D);
                D.BringToFront();

                //重绘
                G.Location = new Point(215, 487);
                G.Text = "清空画板";
                G.ForeColor = Color.Black;
                G.BackColor = Color.Transparent;
                G.Click += G_Click;
                this.Controls.Add(G);
                G.BringToFront();


                //下拉
                E.Location = new Point(153, 29);
                E.Text = "---点我下拉---";
                E.BackColor = Color.Transparent;
                E.ForeColor = Color.Black;
                E.Click += E_Click;
                E.MouseMove += E_MouseMove;
                E.MouseLeave += E_MouseLeave;
                this.Controls.Add(E);
                E.BringToFront();

                //画笔颜色
                F.Location = new Point(70, 487);
                F.Text = "画笔颜色";
                F.ForeColor = Color.Black;
                F.BackColor = Color.Transparent;
                F.Click += F_Click;
                this.Controls.Add(F);
                F.BringToFront();

                //画笔大小
                H.Location = new Point(145, 487);
                H.Text = "画笔大小";
                H.ForeColor = Color.Black;
                H.BackColor = Color.Transparent;
                H.Click += H_Click;
                this.Controls.Add(H);
                H.BringToFront();

                //旋转图像
                J.Location = new Point(282, 465);
                J.Text = "旋转图像";
                J.ForeColor = Color.Black;
                J.BackColor = Color.Transparent;
                J.Click += J_Click;
                this.Controls.Add(J);
                J.BringToFront();

                //橡皮擦
                K.Location = new Point(0, 465);
                K.Text = "橡皮擦";
                K.ForeColor = Color.Black;
                K.BackColor = Color.Transparent;
                K.Click += K_Click;
                this.Controls.Add(K);
                K.BringToFront();

            }

        }

        private void E_MouseLeave(object sender, EventArgs e)
        {
            E.BackColor = Draw.BackColor;
        }

        private void E_MouseMove(object sender, MouseEventArgs e)
        {
            E.BackColor = Color.Gainsboro;
        }

        private void J_Click(object sender, EventArgs e)
        {
            myImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        static bool Ca;
        Color CO;
        private void K_Click(object sender, EventArgs e)
        {
            if (!Ca) { if (A.Color != Draw.BackColor) { CO = A.Color;} Ca = true; K.Text = "取消橡皮擦"; }
            else { Ca = false; K.Text = "橡皮擦"; }
        }

        private void H_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("请输入画笔大小", "The Pen's Size", "2", -1, -1);
            if (str == "") { str = "2"; }
            try
            {
                FontSize = Convert.ToInt32(str);
                A = new Pen(A.Color, FontSize);
            }
            catch { MessageBox.Show("您输入的值无效!", "Wrong Step", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void F_Click(object sender, EventArgs e)
        {
            if (Ca) { MessageBox.Show("请取消橡皮擦模式!"); }
            else
            {
                Cd.ShowDialog();
                CO = Cd.Color;
            }
        }

        private void G_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("确定清空画板吗？", "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                myImage = new Bitmap(504, 602);
                Draw.Image = myImage;
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            Main.Height = this.Height - Draw.Height-30;
            E.Location = new Point(153, E.Location.Y + 30);
            Draw.Height -= 30;
            Draw.Location = new Point(0, Draw.Location.Y + 30);
            
        }

        private void D_Click(object sender, EventArgs e)
        {
            End();
        }
        public void End()
        {
            Main.Height = this.Height;
            Init();
            this.Controls.Remove(C);
            this.Controls.Remove(D);
            this.Controls.Remove(E);
            this.Controls.Remove(G);
            this.Controls.Remove(F);
            this.Controls.Remove(H);
            this.Controls.Remove(J);
            this.Controls.Remove(K);
        }

        private void C_Click(object sender, EventArgs e)
        {
            Cd.ShowDialog();
            Draw.BackColor = Cd.Color;
        }

        private void Draw_MouseDown(object sender, MouseEventArgs e)
        {
            CmpDraw = true;
        }

        private void Draw_MouseUp(object sender, MouseEventArgs e)
        {
            CmpDraw = false;
        }
        private void 恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileText != "")
            {
                DialogResult D = MessageBox.Show("恢复文件到最后一次保存的状态吗？你的更改将会全部丢失！", "恢复", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (D == DialogResult.Yes)
                {
                    Main.Text = FileText;
                }
            }
        }
        private void 背景GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileText == ""||FileText==Main.Text) 恢复ToolStripMenuItem.Enabled = false;
            else 恢复ToolStripMenuItem.Enabled = true;
            if (this.Opacity != 1.0) 绘画ToolStripMenuItem.Enabled = false;
            else 绘画ToolStripMenuItem.Enabled = true;
        }

        private void 启动新窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            记事本 A = new 记事本();
            A.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            A.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            转到 A = new 转到();
            A.B = this;
            A.TopMost = true;
            A.Show();
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 关于().Show();
        }

        private void 关于记事本AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new 事项说明().Show();
        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (索引IToolStripMenuItem.Checked)
            {
                索引IToolStripMenuItem.Checked = false;
                label3.Visible = label1.Visible = label2.Visible = false;
            }
            else
            {
                索引IToolStripMenuItem.Checked = true;
                label3.Visible = label1.Visible = label2.Visible = true;
            }
        }
    }
}
