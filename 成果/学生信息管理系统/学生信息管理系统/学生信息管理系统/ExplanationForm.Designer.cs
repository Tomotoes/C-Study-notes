namespace 学生信息管理系统
{
    partial class ExplanationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplanationForm));
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
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ForNotify.SuspendLayout();
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
            this.ForNotify.Size = new System.Drawing.Size(122, 186);
            // 
            // 作者EToolStripMenuItem
            // 
            this.作者EToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("作者EToolStripMenuItem.Image")));
            this.作者EToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.作者EToolStripMenuItem.Name = "作者EToolStripMenuItem";
            this.作者EToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.作者EToolStripMenuItem.Text = "简介(&E)";
            this.作者EToolStripMenuItem.ToolTipText = "Anthor";
            this.作者EToolStripMenuItem.Click += new System.EventHandler(this.作者EToolStripMenuItem_Click);
            // 
            // 说明DToolStripMenuItem
            // 
            this.说明DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("说明DToolStripMenuItem.Image")));
            this.说明DToolStripMenuItem.Name = "说明DToolStripMenuItem";
            this.说明DToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.说明DToolStripMenuItem.Text = "说明(&D)";
            this.说明DToolStripMenuItem.ToolTipText = "Explanation";
            this.说明DToolStripMenuItem.Click += new System.EventHandler(this.作者EToolStripMenuItem_Click);
            // 
            // 搜索CToolStripMenuItem
            // 
            this.搜索CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("搜索CToolStripMenuItem.Image")));
            this.搜索CToolStripMenuItem.Name = "搜索CToolStripMenuItem";
            this.搜索CToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.搜索CToolStripMenuItem.Text = "搜索(&C)";
            this.搜索CToolStripMenuItem.ToolTipText = "Search";
            this.搜索CToolStripMenuItem.Click += new System.EventHandler(this.作者EToolStripMenuItem_Click);
            // 
            // 管理BToolStripMenuItem
            // 
            this.管理BToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("管理BToolStripMenuItem.Image")));
            this.管理BToolStripMenuItem.Name = "管理BToolStripMenuItem";
            this.管理BToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.管理BToolStripMenuItem.Text = "管理(&B)";
            this.管理BToolStripMenuItem.ToolTipText = "Manage";
            this.管理BToolStripMenuItem.Click += new System.EventHandler(this.作者EToolStripMenuItem_Click);
            // 
            // 预览XToolStripMenuItem
            // 
            this.预览XToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("预览XToolStripMenuItem.Image")));
            this.预览XToolStripMenuItem.Name = "预览XToolStripMenuItem";
            this.预览XToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.预览XToolStripMenuItem.Text = "菜单(&A)";
            this.预览XToolStripMenuItem.ToolTipText = "Read";
            this.预览XToolStripMenuItem.Click += new System.EventHandler(this.作者EToolStripMenuItem_Click);
            // 
            // 启动SToolStripMenuItem
            // 
            this.启动SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("启动SToolStripMenuItem.Image")));
            this.启动SToolStripMenuItem.Name = "启动SToolStripMenuItem";
            this.启动SToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.启动SToolStripMenuItem.Text = "启动(&S)";
            this.启动SToolStripMenuItem.ToolTipText = "Start";
            this.启动SToolStripMenuItem.Click += new System.EventHandler(this.启动SToolStripMenuItem_Click);
            // 
            // 设置QToolStripMenuItem
            // 
            this.设置QToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("设置QToolStripMenuItem.Image")));
            this.设置QToolStripMenuItem.Name = "设置QToolStripMenuItem";
            this.设置QToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.设置QToolStripMenuItem.Text = "退出(&G)";
            this.设置QToolStripMenuItem.ToolTipText = "Exit";
            this.设置QToolStripMenuItem.Click += new System.EventHandler(this.设置QToolStripMenuItem_Click);
            // 
            // Tip
            // 
            this.Tip.IsBalloon = true;
            this.Tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 373);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-7, -1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(871, 651);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("http://blog.csdn.net/Acceptee/article/details/73250933", System.UriKind.Absolute);
            // 
            // ExplanationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(860, 643);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExplanationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统说明";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExplanationForm_FormClosing);
            this.Load += new System.EventHandler(this.ExplanationForm_Load);
            this.SizeChanged += new System.EventHandler(this.ExplanationForm_SizeChanged);
            this.ForNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.NotifyIcon ForMF;
        public System.Windows.Forms.ContextMenuStrip ForNotify;
        private System.Windows.Forms.ToolStripMenuItem 作者EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 预览XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置QToolStripMenuItem;
        private System.Windows.Forms.ToolTip Tip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}