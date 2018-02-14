namespace UI
{
    partial class Frm_PrintDrawM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PrintDrawM));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.lbl_TradeID = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.lbl_Content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(29, 74);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(84, 20);
            this.lbl_Name.TabIndex = 20;
            this.lbl_Name.Text = "取款卡号：";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Money.Location = new System.Drawing.Point(29, 108);
            this.lbl_Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(84, 20);
            this.lbl_Money.TabIndex = 20;
            this.lbl_Money.Text = "取款金额：";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Time.Location = new System.Drawing.Point(29, 177);
            this.lbl_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(84, 20);
            this.lbl_Time.TabIndex = 20;
            this.lbl_Time.Text = "取款日期：";
            // 
            // Btn_Back
            // 
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Back.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Back.Location = new System.Drawing.Point(28, 283);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(166, 33);
            this.Btn_Back.TabIndex = 22;
            this.Btn_Back.Text = "返回主菜单";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            this.Btn_Back.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // Btn_Print
            // 
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Print.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Print.Location = new System.Drawing.Point(114, 246);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(81, 33);
            this.Btn_Print.TabIndex = 23;
            this.Btn_Print.Text = "打印凭条";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            this.Btn_Print.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Print.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Exit.Location = new System.Drawing.Point(28, 246);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(81, 33);
            this.Btn_Exit.TabIndex = 24;
            this.Btn_Exit.Text = "退  卡";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            this.Btn_Exit.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // lbl_TradeID
            // 
            this.lbl_TradeID.AutoSize = true;
            this.lbl_TradeID.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TradeID.Location = new System.Drawing.Point(15, 39);
            this.lbl_TradeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TradeID.Name = "lbl_TradeID";
            this.lbl_TradeID.Size = new System.Drawing.Size(99, 20);
            this.lbl_TradeID.TabIndex = 20;
            this.lbl_TradeID.Text = "交易流水号：";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Balance.Location = new System.Drawing.Point(29, 142);
            this.lbl_Balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(84, 20);
            this.lbl_Balance.TabIndex = 20;
            this.lbl_Balance.Text = "当前余额：";
            // 
            // lbl_Content
            // 
            this.lbl_Content.AutoSize = true;
            this.lbl_Content.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Content.Location = new System.Drawing.Point(58, 213);
            this.lbl_Content.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Content.Name = "lbl_Content";
            this.lbl_Content.Size = new System.Drawing.Size(54, 20);
            this.lbl_Content.TabIndex = 20;
            this.lbl_Content.Text = "备注：";
            // 
            // Frm_PrintDrawM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(264, 327);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.lbl_Content);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_TradeID);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_PrintDrawM";
            this.Text = "打印凭条";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_PrintDrawM_FormClosing);
            this.Load += new System.EventHandler(this.Frm_PrintDrawM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.Label lbl_TradeID;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Label lbl_Content;
    }
}