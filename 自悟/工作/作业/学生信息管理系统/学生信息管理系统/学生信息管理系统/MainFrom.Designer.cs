namespace 学生信息管理系统
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ForMF = new System.Windows.Forms.NotifyIcon(this.components);
            this.ForNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.作者EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.预览XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.ReadInfo = new System.Windows.Forms.Button();
            this.ManageInfo = new System.Windows.Forms.Button();
            this.SearchInfo = new System.Windows.Forms.Button();
            this.Explanation = new System.Windows.Forms.Button();
            this.Anthor = new System.Windows.Forms.Button();
            this.DS = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ForNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // ForMF
            // 
            this.ForMF.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ForMF.BalloonTipTitle = "Click me!";
            this.ForMF.ContextMenuStrip = this.ForNotify;
            this.ForMF.Icon = ((System.Drawing.Icon)(resources.GetObject("ForMF.Icon")));
            this.ForMF.Text = "学生信息管理系统";
            this.ForMF.Visible = true;
            // 
            // ForNotify
            // 
            this.ForNotify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForNotify.BackgroundImage")));
            this.ForNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ForNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者EToolStripMenuItem,
            this.说明DToolStripMenuItem,
            this.搜索CToolStripMenuItem,
            this.管理BToolStripMenuItem,
            this.预览XToolStripMenuItem,
            this.启动SToolStripMenuItem,
            this.设置QToolStripMenuItem});
            this.ForNotify.Name = "ForNotify";
            this.ForNotify.Size = new System.Drawing.Size(134, 186);
            // 
            // 作者EToolStripMenuItem
            // 
            this.作者EToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("作者EToolStripMenuItem.Image")));
            this.作者EToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.作者EToolStripMenuItem.Name = "作者EToolStripMenuItem";
            this.作者EToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.作者EToolStripMenuItem.Text = "简介(&E)";
            this.作者EToolStripMenuItem.ToolTipText = "Anthor";
            this.作者EToolStripMenuItem.Click += new System.EventHandler(this.ReadInfo_Click);
            // 
            // 说明DToolStripMenuItem
            // 
            this.说明DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("说明DToolStripMenuItem.Image")));
            this.说明DToolStripMenuItem.Name = "说明DToolStripMenuItem";
            this.说明DToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.说明DToolStripMenuItem.Text = "说明(&D)";
            this.说明DToolStripMenuItem.ToolTipText = "Explanation";
            this.说明DToolStripMenuItem.Click += new System.EventHandler(this.ReadInfo_Click);
            // 
            // 搜索CToolStripMenuItem
            // 
            this.搜索CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("搜索CToolStripMenuItem.Image")));
            this.搜索CToolStripMenuItem.Name = "搜索CToolStripMenuItem";
            this.搜索CToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.搜索CToolStripMenuItem.Text = "搜索(&C)";
            this.搜索CToolStripMenuItem.ToolTipText = "Search";
            this.搜索CToolStripMenuItem.Click += new System.EventHandler(this.ReadInfo_Click);
            // 
            // 管理BToolStripMenuItem
            // 
            this.管理BToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("管理BToolStripMenuItem.Image")));
            this.管理BToolStripMenuItem.Name = "管理BToolStripMenuItem";
            this.管理BToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.管理BToolStripMenuItem.Text = "管理(&B)";
            this.管理BToolStripMenuItem.ToolTipText = "Manage";
            this.管理BToolStripMenuItem.Click += new System.EventHandler(this.ReadInfo_Click);
            // 
            // 预览XToolStripMenuItem
            // 
            this.预览XToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("预览XToolStripMenuItem.Image")));
            this.预览XToolStripMenuItem.Name = "预览XToolStripMenuItem";
            this.预览XToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.预览XToolStripMenuItem.Text = "预览(&A)";
            this.预览XToolStripMenuItem.ToolTipText = "Read";
            this.预览XToolStripMenuItem.Click += new System.EventHandler(this.ReadInfo_Click);
            // 
            // 启动SToolStripMenuItem
            // 
            this.启动SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("启动SToolStripMenuItem.Image")));
            this.启动SToolStripMenuItem.Name = "启动SToolStripMenuItem";
            this.启动SToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.启动SToolStripMenuItem.Text = "启动(&S)";
            this.启动SToolStripMenuItem.ToolTipText = "Start";
            this.启动SToolStripMenuItem.Click += new System.EventHandler(this.启动SToolStripMenuItem_Click);
            // 
            // 设置QToolStripMenuItem
            // 
            this.设置QToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置QToolStripMenuItem.Image")));
            this.设置QToolStripMenuItem.Name = "设置QToolStripMenuItem";
            this.设置QToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.设置QToolStripMenuItem.Text = "退出(&G)";
            this.设置QToolStripMenuItem.ToolTipText = "Exit";
            this.设置QToolStripMenuItem.Click += new System.EventHandler(this.退出QToolStripMenuItem_Click);
            // 
            // Tip
            // 
            this.Tip.IsBalloon = true;
            this.Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ReadInfo
            // 
            this.ReadInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadInfo.BackColor = System.Drawing.Color.Transparent;
            this.ReadInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadInfo.ForeColor = System.Drawing.Color.Black;
            this.ReadInfo.Location = new System.Drawing.Point(-7, -2);
            this.ReadInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ReadInfo.Name = "ReadInfo";
            this.ReadInfo.Size = new System.Drawing.Size(489, 125);
            this.ReadInfo.TabIndex = 1;
            this.ReadInfo.Text = "信 息 预 览";
            this.ReadInfo.UseVisualStyleBackColor = false;
            this.ReadInfo.Click += new System.EventHandler(this.ReadInfo_Click);
            this.ReadInfo.MouseLeave += new System.EventHandler(this.ReadInfo_MouseLeave);
            this.ReadInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadInfo_MouseMove);
            // 
            // ManageInfo
            // 
            this.ManageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageInfo.BackColor = System.Drawing.Color.Transparent;
            this.ManageInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManageInfo.ForeColor = System.Drawing.Color.Black;
            this.ManageInfo.Location = new System.Drawing.Point(-7, 119);
            this.ManageInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ManageInfo.Name = "ManageInfo";
            this.ManageInfo.Size = new System.Drawing.Size(489, 112);
            this.ManageInfo.TabIndex = 1;
            this.ManageInfo.Text = "信 息 管 理";
            this.ManageInfo.UseVisualStyleBackColor = false;
            this.ManageInfo.Click += new System.EventHandler(this.ReadInfo_Click);
            this.ManageInfo.MouseLeave += new System.EventHandler(this.ReadInfo_MouseLeave);
            this.ManageInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadInfo_MouseMove);
            // 
            // SearchInfo
            // 
            this.SearchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchInfo.BackColor = System.Drawing.Color.Transparent;
            this.SearchInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchInfo.ForeColor = System.Drawing.Color.Black;
            this.SearchInfo.Location = new System.Drawing.Point(-7, 226);
            this.SearchInfo.Margin = new System.Windows.Forms.Padding(4);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(489, 110);
            this.SearchInfo.TabIndex = 1;
            this.SearchInfo.Text = "信 息 搜 索";
            this.SearchInfo.UseVisualStyleBackColor = false;
            this.SearchInfo.Click += new System.EventHandler(this.ReadInfo_Click);
            this.SearchInfo.MouseLeave += new System.EventHandler(this.ReadInfo_MouseLeave);
            this.SearchInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadInfo_MouseMove);
            // 
            // Explanation
            // 
            this.Explanation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Explanation.BackColor = System.Drawing.Color.Transparent;
            this.Explanation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Explanation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Explanation.ForeColor = System.Drawing.Color.Black;
            this.Explanation.Location = new System.Drawing.Point(-7, 334);
            this.Explanation.Margin = new System.Windows.Forms.Padding(4);
            this.Explanation.Name = "Explanation";
            this.Explanation.Size = new System.Drawing.Size(489, 111);
            this.Explanation.TabIndex = 1;
            this.Explanation.Text = "功 能 说 明";
            this.Explanation.UseVisualStyleBackColor = false;
            this.Explanation.Click += new System.EventHandler(this.ReadInfo_Click);
            this.Explanation.MouseLeave += new System.EventHandler(this.ReadInfo_MouseLeave);
            this.Explanation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadInfo_MouseMove);
            // 
            // Anthor
            // 
            this.Anthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Anthor.BackColor = System.Drawing.Color.Transparent;
            this.Anthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Anthor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Anthor.ForeColor = System.Drawing.Color.Black;
            this.Anthor.Location = new System.Drawing.Point(-7, 441);
            this.Anthor.Margin = new System.Windows.Forms.Padding(4);
            this.Anthor.Name = "Anthor";
            this.Anthor.Size = new System.Drawing.Size(489, 118);
            this.Anthor.TabIndex = 1;
            this.Anthor.Text = "系 统 简 介";
            this.Anthor.UseVisualStyleBackColor = false;
            this.Anthor.Click += new System.EventHandler(this.ReadInfo_Click);
            this.Anthor.MouseLeave += new System.EventHandler(this.ReadInfo_MouseLeave);
            this.Anthor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ReadInfo_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库连接失败\r\n整体功能已停止";
            this.label1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Anthor);
            this.Controls.Add(this.Explanation);
            this.Controls.Add(this.SearchInfo);
            this.Controls.Add(this.ManageInfo);
            this.Controls.Add(this.ReadInfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.ForNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon ForMF;
        public System.Windows.Forms.ContextMenuStrip ForNotify;
        public System.Windows.Forms.ToolStripMenuItem 预览XToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 启动SToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 设置QToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 作者EToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 说明DToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 搜索CToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 管理BToolStripMenuItem;
        public System.Windows.Forms.ToolTip Tip;
        public System.Windows.Forms.Button ReadInfo;
        public System.Windows.Forms.Button ManageInfo;
        public System.Windows.Forms.Button SearchInfo;
        public System.Windows.Forms.Button Explanation;
        public System.Windows.Forms.Button Anthor;
        public System.Windows.Forms.BindingSource DS;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label1;
    }
}

