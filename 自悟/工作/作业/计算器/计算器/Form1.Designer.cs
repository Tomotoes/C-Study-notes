namespace 计算器
{
    partial class 计算器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Judge = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.裁剪ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Time = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num3 = new System.Windows.Forms.Label();
            this.正负号 = new System.Windows.Forms.Label();
            this.Num0 = new System.Windows.Forms.Label();
            this.Dian1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Label();
            this.Dengyu1 = new System.Windows.Forms.Label();
            this.Num4 = new System.Windows.Forms.Label();
            this.Num5 = new System.Windows.Forms.Label();
            this.Num6 = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Label();
            this.Num7 = new System.Windows.Forms.Label();
            this.Num8 = new System.Windows.Forms.Label();
            this.Num9 = new System.Windows.Forms.Label();
            this.Multiply = new System.Windows.Forms.Label();
            this.CE = new System.Windows.Forms.Label();
            this.backspace = new System.Windows.Forms.Label();
            this.Divide = new System.Windows.Forms.Label();
            this.百分 = new System.Windows.Forms.Label();
            this.根号 = new System.Windows.Forms.Label();
            this.平方 = new System.Windows.Forms.Label();
            this.分号 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FullColor = new System.Windows.Forms.StatusStrip();
            this.History = new System.Windows.Forms.Label();
            this.Anthor = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.Label();
            this.Explain = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Result = new System.Windows.Forms.TextBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.Menu.SuspendLayout();
            this.FullColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // Judge
            // 
            this.Judge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Judge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Judge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Judge.ContextMenuStrip = this.Menu;
            this.Judge.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Judge.Location = new System.Drawing.Point(1, 23);
            this.Judge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Judge.Multiline = true;
            this.Judge.Name = "Judge";
            this.Judge.ReadOnly = true;
            this.Judge.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Judge.Size = new System.Drawing.Size(221, 85);
            this.Judge.TabIndex = 1;
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.裁剪ToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(101, 70);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 裁剪ToolStripMenuItem
            // 
            this.裁剪ToolStripMenuItem.Name = "裁剪ToolStripMenuItem";
            this.裁剪ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.裁剪ToolStripMenuItem.Text = "裁剪";
            this.裁剪ToolStripMenuItem.Click += new System.EventHandler(this.裁剪ToolStripMenuItem_Click);
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Time.Location = new System.Drawing.Point(73, 1);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(43, 17);
            this.Time.TabIndex = 3;
            this.Time.Text = "Time";
            this.Time.MouseLeave += new System.EventHandler(this.Time_MouseLeave);
            this.Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Time_MouseMove);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(184, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 17);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Num1
            // 
            this.Num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num1.Location = new System.Drawing.Point(11, 286);
            this.Num1.Margin = new System.Windows.Forms.Padding(2);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(46, 24);
            this.Num1.TabIndex = 5;
            this.Num1.Text = " 1 ";
            this.Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            this.Num1.MouseLeave += new System.EventHandler(this.Num1_MouseLeave);
            this.Num1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num1_MouseMove);
            // 
            // Num2
            // 
            this.Num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num2.Location = new System.Drawing.Point(61, 286);
            this.Num2.Margin = new System.Windows.Forms.Padding(2);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(46, 24);
            this.Num2.TabIndex = 6;
            this.Num2.Text = " 2 ";
            this.Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            this.Num2.MouseLeave += new System.EventHandler(this.Num2_MouseLeave);
            this.Num2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num2_MouseMove);
            // 
            // Num3
            // 
            this.Num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num3.AutoSize = true;
            this.Num3.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num3.Location = new System.Drawing.Point(111, 286);
            this.Num3.Margin = new System.Windows.Forms.Padding(2);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(46, 24);
            this.Num3.TabIndex = 7;
            this.Num3.Text = " 3 ";
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            this.Num3.MouseLeave += new System.EventHandler(this.Num3_MouseLeave);
            this.Num3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num3_MouseMove);
            // 
            // 正负号
            // 
            this.正负号.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.正负号.AutoSize = true;
            this.正负号.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.正负号.Location = new System.Drawing.Point(11, 317);
            this.正负号.Margin = new System.Windows.Forms.Padding(2);
            this.正负号.Name = "正负号";
            this.正负号.Size = new System.Drawing.Size(43, 21);
            this.正负号.TabIndex = 8;
            this.正负号.Text = " ±";
            this.正负号.Click += new System.EventHandler(this.正负号_Click);
            this.正负号.MouseLeave += new System.EventHandler(this.正负号_MouseLeave);
            this.正负号.MouseMove += new System.Windows.Forms.MouseEventHandler(this.正负号_MouseMove);
            // 
            // Num0
            // 
            this.Num0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num0.AutoSize = true;
            this.Num0.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num0.Location = new System.Drawing.Point(61, 314);
            this.Num0.Margin = new System.Windows.Forms.Padding(2);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(46, 24);
            this.Num0.TabIndex = 9;
            this.Num0.Text = " 0 ";
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            this.Num0.MouseLeave += new System.EventHandler(this.Num0_MouseLeave);
            this.Num0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num0_MouseMove);
            // 
            // Dian1
            // 
            this.Dian1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dian1.AutoSize = true;
            this.Dian1.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dian1.Location = new System.Drawing.Point(111, 314);
            this.Dian1.Margin = new System.Windows.Forms.Padding(2);
            this.Dian1.Name = "Dian1";
            this.Dian1.Size = new System.Drawing.Size(46, 24);
            this.Dian1.TabIndex = 10;
            this.Dian1.Text = " . ";
            this.Dian1.Click += new System.EventHandler(this.Dian1_Click);
            this.Dian1.MouseLeave += new System.EventHandler(this.Dian1_MouseLeave);
            this.Dian1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dian1_MouseMove);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Add.Location = new System.Drawing.Point(164, 286);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(46, 24);
            this.Add.TabIndex = 11;
            this.Add.Text = " + ";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            this.Add.MouseLeave += new System.EventHandler(this.Add_MouseLeave);
            this.Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Add_MouseMove);
            // 
            // Dengyu1
            // 
            this.Dengyu1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dengyu1.AutoSize = true;
            this.Dengyu1.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Dengyu1.Location = new System.Drawing.Point(162, 314);
            this.Dengyu1.Margin = new System.Windows.Forms.Padding(2);
            this.Dengyu1.Name = "Dengyu1";
            this.Dengyu1.Size = new System.Drawing.Size(46, 24);
            this.Dengyu1.TabIndex = 12;
            this.Dengyu1.Text = " = ";
            this.Dengyu1.Click += new System.EventHandler(this.Dengyu1_Click);
            this.Dengyu1.MouseLeave += new System.EventHandler(this.Dengyu1_MouseLeave);
            this.Dengyu1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dengyu1_MouseMove);
            // 
            // Num4
            // 
            this.Num4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num4.AutoSize = true;
            this.Num4.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num4.Location = new System.Drawing.Point(11, 255);
            this.Num4.Margin = new System.Windows.Forms.Padding(2);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(46, 24);
            this.Num4.TabIndex = 5;
            this.Num4.Text = " 4 ";
            this.Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            this.Num4.MouseLeave += new System.EventHandler(this.Num4_MouseLeave);
            this.Num4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num4_MouseMove);
            // 
            // Num5
            // 
            this.Num5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num5.AutoSize = true;
            this.Num5.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num5.Location = new System.Drawing.Point(61, 255);
            this.Num5.Margin = new System.Windows.Forms.Padding(2);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(46, 24);
            this.Num5.TabIndex = 6;
            this.Num5.Text = " 5 ";
            this.Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            this.Num5.MouseLeave += new System.EventHandler(this.Num5_MouseLeave);
            this.Num5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num5_MouseMove);
            // 
            // Num6
            // 
            this.Num6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num6.AutoSize = true;
            this.Num6.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num6.Location = new System.Drawing.Point(111, 255);
            this.Num6.Margin = new System.Windows.Forms.Padding(2);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(46, 24);
            this.Num6.TabIndex = 7;
            this.Num6.Text = " 6 ";
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            this.Num6.MouseLeave += new System.EventHandler(this.Num6_MouseLeave);
            this.Num6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num6_MouseMove);
            // 
            // Remove
            // 
            this.Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove.AutoSize = true;
            this.Remove.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Remove.Location = new System.Drawing.Point(164, 255);
            this.Remove.Margin = new System.Windows.Forms.Padding(2);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(46, 24);
            this.Remove.TabIndex = 11;
            this.Remove.Text = " - ";
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            this.Remove.MouseLeave += new System.EventHandler(this.Remove_MouseLeave);
            this.Remove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Remove_MouseMove);
            // 
            // Num7
            // 
            this.Num7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num7.AutoSize = true;
            this.Num7.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num7.Location = new System.Drawing.Point(11, 227);
            this.Num7.Margin = new System.Windows.Forms.Padding(2);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(46, 24);
            this.Num7.TabIndex = 5;
            this.Num7.Text = " 7 ";
            this.Num7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            this.Num7.MouseLeave += new System.EventHandler(this.Num7_MouseLeave);
            this.Num7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num7_MouseMove);
            // 
            // Num8
            // 
            this.Num8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num8.AutoSize = true;
            this.Num8.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num8.Location = new System.Drawing.Point(61, 227);
            this.Num8.Margin = new System.Windows.Forms.Padding(2);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(46, 24);
            this.Num8.TabIndex = 6;
            this.Num8.Text = " 8 ";
            this.Num8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            this.Num8.MouseLeave += new System.EventHandler(this.Num8_MouseLeave);
            this.Num8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num8_MouseMove);
            // 
            // Num9
            // 
            this.Num9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Num9.AutoSize = true;
            this.Num9.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Num9.Location = new System.Drawing.Point(111, 227);
            this.Num9.Margin = new System.Windows.Forms.Padding(2);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(46, 24);
            this.Num9.TabIndex = 7;
            this.Num9.Text = " 9 ";
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            this.Num9.MouseLeave += new System.EventHandler(this.Num9_MouseLeave);
            this.Num9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Num9_MouseMove);
            // 
            // Multiply
            // 
            this.Multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Multiply.AutoSize = true;
            this.Multiply.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Multiply.Location = new System.Drawing.Point(164, 227);
            this.Multiply.Margin = new System.Windows.Forms.Padding(2);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(46, 24);
            this.Multiply.TabIndex = 11;
            this.Multiply.Text = " * ";
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            this.Multiply.MouseLeave += new System.EventHandler(this.Multiply_MouseLeave);
            this.Multiply.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Multiply_MouseMove);
            // 
            // CE
            // 
            this.CE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CE.AutoSize = true;
            this.CE.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CE.Location = new System.Drawing.Point(11, 202);
            this.CE.Margin = new System.Windows.Forms.Padding(2);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(54, 21);
            this.CE.TabIndex = 13;
            this.CE.Text = " CE ";
            this.CE.Click += new System.EventHandler(this.CE_1);
            this.CE.MouseLeave += new System.EventHandler(this.CE_MouseLeave);
            this.CE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CE_MouseMove);
            // 
            // backspace
            // 
            this.backspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backspace.AutoSize = true;
            this.backspace.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backspace.Location = new System.Drawing.Point(114, 202);
            this.backspace.Margin = new System.Windows.Forms.Padding(2);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(43, 21);
            this.backspace.TabIndex = 15;
            this.backspace.Text = "<- ";
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            this.backspace.MouseLeave += new System.EventHandler(this.backspace_MouseLeave);
            this.backspace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.backspace_MouseMove);
            // 
            // Divide
            // 
            this.Divide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Divide.AutoSize = true;
            this.Divide.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Divide.Location = new System.Drawing.Point(162, 202);
            this.Divide.Margin = new System.Windows.Forms.Padding(2);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(43, 21);
            this.Divide.TabIndex = 16;
            this.Divide.Text = " ÷";
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            this.Divide.MouseLeave += new System.EventHandler(this.Divide_MouseLeave);
            this.Divide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Divide_MouseMove);
            // 
            // 百分
            // 
            this.百分.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.百分.AutoSize = true;
            this.百分.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.百分.Location = new System.Drawing.Point(11, 174);
            this.百分.Margin = new System.Windows.Forms.Padding(2);
            this.百分.Name = "百分";
            this.百分.Size = new System.Drawing.Size(46, 24);
            this.百分.TabIndex = 13;
            this.百分.Text = " % ";
            this.百分.Click += new System.EventHandler(this.百分_Click_1);
            this.百分.MouseLeave += new System.EventHandler(this.百分_MouseLeave);
            this.百分.MouseMove += new System.Windows.Forms.MouseEventHandler(this.百分_MouseMove);
            // 
            // 根号
            // 
            this.根号.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.根号.AutoSize = true;
            this.根号.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.根号.Location = new System.Drawing.Point(64, 174);
            this.根号.Margin = new System.Windows.Forms.Padding(2);
            this.根号.Name = "根号";
            this.根号.Size = new System.Drawing.Size(46, 24);
            this.根号.TabIndex = 14;
            this.根号.Text = "√ ";
            this.根号.Click += new System.EventHandler(this.根号_Click);
            this.根号.MouseLeave += new System.EventHandler(this.根号_MouseLeave);
            this.根号.MouseMove += new System.Windows.Forms.MouseEventHandler(this.根号_MouseMove);
            // 
            // 平方
            // 
            this.平方.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.平方.AutoSize = true;
            this.平方.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.平方.Location = new System.Drawing.Point(114, 177);
            this.平方.Margin = new System.Windows.Forms.Padding(2);
            this.平方.Name = "平方";
            this.平方.Size = new System.Drawing.Size(43, 21);
            this.平方.TabIndex = 15;
            this.平方.Text = "^2 ";
            this.平方.Click += new System.EventHandler(this.平方_Click);
            this.平方.MouseLeave += new System.EventHandler(this.平方_MouseLeave);
            this.平方.MouseMove += new System.Windows.Forms.MouseEventHandler(this.平方_MouseMove);
            // 
            // 分号
            // 
            this.分号.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.分号.AutoSize = true;
            this.分号.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.分号.Location = new System.Drawing.Point(163, 177);
            this.分号.Margin = new System.Windows.Forms.Padding(2);
            this.分号.Name = "分号";
            this.分号.Size = new System.Drawing.Size(43, 21);
            this.分号.TabIndex = 16;
            this.分号.Text = "1/x";
            this.分号.Click += new System.EventHandler(this.分号_Click);
            this.分号.MouseLeave += new System.EventHandler(this.分号_MouseLeave);
            this.分号.MouseMove += new System.Windows.Forms.MouseEventHandler(this.分号_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FullColor
            // 
            this.FullColor.Font = new System.Drawing.Font("微软雅黑", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FullColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripProgressBar2});
            this.FullColor.Location = new System.Drawing.Point(1, 359);
            this.FullColor.Name = "FullColor";
            this.FullColor.Size = new System.Drawing.Size(221, 22);
            this.FullColor.TabIndex = 17;
            this.FullColor.Text = "statusStrip1";
            // 
            // History
            // 
            this.History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.History.Location = new System.Drawing.Point(6, 1);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(61, 17);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Anthor
            // 
            this.Anthor.AutoSize = true;
            this.Anthor.Location = new System.Drawing.Point(123, 3);
            this.Anthor.Name = "Anthor";
            this.Anthor.Size = new System.Drawing.Size(55, 15);
            this.Anthor.TabIndex = 0;
            this.Anthor.Text = "Anthor";
            this.Anthor.MouseLeave += new System.EventHandler(this.Anthor_MouseLeave);
            this.Anthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Anthor_MouseMove);
            // 
            // Random
            // 
            this.Random.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Random.AutoSize = true;
            this.Random.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Random.Location = new System.Drawing.Point(64, 202);
            this.Random.Margin = new System.Windows.Forms.Padding(2);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(43, 21);
            this.Random.TabIndex = 14;
            this.Random.Text = "Ran";
            this.Random.Click += new System.EventHandler(this.Random_Click);
            this.Random.MouseLeave += new System.EventHandler(this.Random_MouseLeave);
            this.Random.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Random_MouseMove);
            // 
            // Explain
            // 
            this.Explain.AutoSize = true;
            this.Explain.BackColor = System.Drawing.Color.Transparent;
            this.Explain.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Explain.ForeColor = System.Drawing.Color.OliveDrab;
            this.Explain.Location = new System.Drawing.Point(15, 64);
            this.Explain.Name = "Explain";
            this.Explain.Size = new System.Drawing.Size(33, 12);
            this.Explain.TabIndex = 18;
            this.Explain.Text = "xxxx";
            this.Explain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Explain_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.ContextMenuStrip = this.Menu;
            this.Result.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Result.Location = new System.Drawing.Point(1, 109);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Result.Size = new System.Drawing.Size(221, 58);
            this.Result.TabIndex = 1;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 15);
            this.toolStripProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // 计算器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(223, 382);
            this.Controls.Add(this.Explain);
            this.Controls.Add(this.Anthor);
            this.Controls.Add(this.FullColor);
            this.Controls.Add(this.分号);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.平方);
            this.Controls.Add(this.根号);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.百分);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Dengyu1);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Dian1);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.正负号);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Judge);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "计算器";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计算器";
            this.Load += new System.EventHandler(this.计算器_Load);
            this.Menu.ResumeLayout(false);
            this.FullColor.ResumeLayout(false);
            this.FullColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Judge;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num3;
        private System.Windows.Forms.Label 正负号;
        private System.Windows.Forms.Label Num0;
        private System.Windows.Forms.Label Dian1;
        private System.Windows.Forms.Label Add;
        private System.Windows.Forms.Label Dengyu1;
        private System.Windows.Forms.Label Num4;
        private System.Windows.Forms.Label Num5;
        private System.Windows.Forms.Label Num6;
        private System.Windows.Forms.Label Remove;
        private System.Windows.Forms.Label Num7;
        private System.Windows.Forms.Label Num8;
        private System.Windows.Forms.Label Num9;
        private System.Windows.Forms.Label Multiply;
        private System.Windows.Forms.Label CE;
        private System.Windows.Forms.Label backspace;
        private System.Windows.Forms.Label Divide;
        private System.Windows.Forms.Label 百分;
        private System.Windows.Forms.Label 根号;
        private System.Windows.Forms.Label 平方;
        private System.Windows.Forms.Label 分号;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip FullColor;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label Anthor;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 裁剪ToolStripMenuItem;
        private System.Windows.Forms.Label Random;
        private System.Windows.Forms.Label Explain;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
    }
}

