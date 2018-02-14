namespace UI
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_ApplyID = new System.Windows.Forms.Button();
            this.Btn_ForgetPWS = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.lbl_Passwrod = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.lbl_Tip = new System.Windows.Forms.Label();
            this.pic_Title = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Login.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Login.Location = new System.Drawing.Point(191, 201);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(81, 26);
            this.Btn_Login.TabIndex = 10;
            this.Btn_Login.Text = "开始登陆";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_Login.MouseLeave += new System.EventHandler(this.Btn_Login_MouseLeave);
            this.Btn_Login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Login_MouseMove);
            // 
            // Btn_ApplyID
            // 
            this.Btn_ApplyID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ApplyID.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_ApplyID.Location = new System.Drawing.Point(191, 165);
            this.Btn_ApplyID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ApplyID.Name = "Btn_ApplyID";
            this.Btn_ApplyID.Size = new System.Drawing.Size(81, 26);
            this.Btn_ApplyID.TabIndex = 14;
            this.Btn_ApplyID.Text = "注册账号";
            this.Btn_ApplyID.UseVisualStyleBackColor = true;
            this.Btn_ApplyID.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_ApplyID.MouseLeave += new System.EventHandler(this.Btn_Login_MouseLeave);
            this.Btn_ApplyID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Login_MouseMove);
            // 
            // Btn_ForgetPWS
            // 
            this.Btn_ForgetPWS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ForgetPWS.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_ForgetPWS.Location = new System.Drawing.Point(191, 126);
            this.Btn_ForgetPWS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ForgetPWS.Name = "Btn_ForgetPWS";
            this.Btn_ForgetPWS.Size = new System.Drawing.Size(81, 26);
            this.Btn_ForgetPWS.TabIndex = 13;
            this.Btn_ForgetPWS.Text = "忘记密码";
            this.Btn_ForgetPWS.UseVisualStyleBackColor = true;
            this.Btn_ForgetPWS.Click += new System.EventHandler(this.Btn_Login_Click);
            this.Btn_ForgetPWS.MouseLeave += new System.EventHandler(this.Btn_Login_MouseLeave);
            this.Btn_ForgetPWS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Login_MouseMove);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(72, 170);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 21);
            this.txt_Password.TabIndex = 8;
            // 
            // txt_Account
            // 
            this.txt_Account.Location = new System.Drawing.Point(72, 131);
            this.txt_Account.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(100, 21);
            this.txt_Account.TabIndex = 6;
            // 
            // lbl_Passwrod
            // 
            this.lbl_Passwrod.AutoSize = true;
            this.lbl_Passwrod.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Passwrod.Location = new System.Drawing.Point(11, 170);
            this.lbl_Passwrod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Passwrod.Name = "lbl_Passwrod";
            this.lbl_Passwrod.Size = new System.Drawing.Size(58, 20);
            this.lbl_Passwrod.TabIndex = 9;
            this.lbl_Passwrod.Text = "密 码：";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Account.Location = new System.Drawing.Point(11, 131);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(58, 20);
            this.lbl_Account.TabIndex = 7;
            this.lbl_Account.Text = "卡 号：";
            // 
            // lbl_Tip
            // 
            this.lbl_Tip.AutoSize = true;
            this.lbl_Tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Tip.Location = new System.Drawing.Point(5, 97);
            this.lbl_Tip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tip.Name = "lbl_Tip";
            this.lbl_Tip.Size = new System.Drawing.Size(176, 17);
            this.lbl_Tip.TabIndex = 16;
            this.lbl_Tip.Text = "本系统目前支持存款，取款操作";
            // 
            // pic_Title
            // 
            this.pic_Title.Image = ((System.Drawing.Image)(resources.GetObject("pic_Title.Image")));
            this.pic_Title.Location = new System.Drawing.Point(1, 26);
            this.pic_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Title.Name = "pic_Title";
            this.pic_Title.Size = new System.Drawing.Size(284, 87);
            this.pic_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Title.TabIndex = 15;
            this.pic_Title.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 203);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 241);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Tip);
            this.Controls.Add(this.pic_Title);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Btn_ApplyID);
            this.Controls.Add(this.Btn_ForgetPWS);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Account);
            this.Controls.Add(this.lbl_Passwrod);
            this.Controls.Add(this.lbl_Account);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.Text = "用户登陆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_ApplyID;
        private System.Windows.Forms.Button Btn_ForgetPWS;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.Label lbl_Passwrod;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Label lbl_Tip;
        private System.Windows.Forms.PictureBox pic_Title;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}