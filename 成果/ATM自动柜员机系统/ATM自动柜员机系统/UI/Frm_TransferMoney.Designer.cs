namespace UI
{
    partial class Frm_BringMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BringMoney));
            this.lbl_Account = new System.Windows.Forms.Label();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.lbl_Money = new System.Windows.Forms.Label();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.Btn_Sure = new System.Windows.Forms.Button();
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Account
            // 
            this.lbl_Account.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Account.Location = new System.Drawing.Point(10, 38);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(167, 26);
            this.lbl_Account.TabIndex = 16;
            this.lbl_Account.Text = "请输入您要转账的卡号";
            // 
            // txt_Account
            // 
            this.txt_Account.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Account.Location = new System.Drawing.Point(9, 66);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Account.Multiline = true;
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(152, 34);
            this.txt_Account.TabIndex = 0;
            // 
            // lbl_Money
            // 
            this.lbl_Money.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Money.Location = new System.Drawing.Point(5, 118);
            this.lbl_Money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(167, 26);
            this.lbl_Money.TabIndex = 16;
            this.lbl_Money.Text = "请输入您要转账的金额";
            // 
            // txt_Money
            // 
            this.txt_Money.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Money.Location = new System.Drawing.Point(9, 146);
            this.txt_Money.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Money.Multiline = true;
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(152, 34);
            this.txt_Money.TabIndex = 1;
            // 
            // Btn_Sure
            // 
            this.Btn_Sure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sure.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Sure.Location = new System.Drawing.Point(182, 38);
            this.Btn_Sure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Sure.Name = "Btn_Sure";
            this.Btn_Sure.Size = new System.Drawing.Size(81, 33);
            this.Btn_Sure.TabIndex = 2;
            this.Btn_Sure.Text = "确  定";
            this.Btn_Sure.UseVisualStyleBackColor = true;
            this.Btn_Sure.Click += new System.EventHandler(this.Btn_Sure_Click);
            this.Btn_Sure.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Sure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // Btn_Init
            // 
            this.Btn_Init.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Init.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Init.Location = new System.Drawing.Point(182, 94);
            this.Btn_Init.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Init.Name = "Btn_Init";
            this.Btn_Init.Size = new System.Drawing.Size(81, 33);
            this.Btn_Init.TabIndex = 3;
            this.Btn_Init.Text = "重  置";
            this.Btn_Init.UseVisualStyleBackColor = true;
            this.Btn_Init.Click += new System.EventHandler(this.Btn_Init_Click);
            this.Btn_Init.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Init.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // Btn_Back
            // 
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Back.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Back.Location = new System.Drawing.Point(182, 148);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(81, 33);
            this.Btn_Back.TabIndex = 4;
            this.Btn_Back.Text = "返  回";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            this.Btn_Back.MouseLeave += new System.EventHandler(this.Btn_Back_MouseLeave);
            this.Btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Back_MouseMove);
            // 
            // Frm_BringMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(276, 190);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Init);
            this.Controls.Add(this.Btn_Sure);
            this.Controls.Add(this.txt_Money);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lbl_Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_BringMoney";
            this.Text = "转账界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_BringMoney_FormClosing);
            this.Load += new System.EventHandler(this.Frm_BringMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Label lbl_Money;
        private System.Windows.Forms.TextBox txt_Money;
        private System.Windows.Forms.Button Btn_Sure;
        private System.Windows.Forms.Button Btn_Init;
        private System.Windows.Forms.Button Btn_Back;
    }
}