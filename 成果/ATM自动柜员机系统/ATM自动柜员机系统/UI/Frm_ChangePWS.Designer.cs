namespace UI
{
    partial class Frm_ChangePWS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangePWS));
            this.lbl_NewPWS = new System.Windows.Forms.Label();
            this.lbl_ReNewPWS = new System.Windows.Forms.Label();
            this.txt_NewPWS = new System.Windows.Forms.TextBox();
            this.txt_ReNewPWS = new System.Windows.Forms.TextBox();
            this.Btn_Sure = new System.Windows.Forms.Button();
            this.Btn_Init = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_NewPWS
            // 
            this.lbl_NewPWS.AutoSize = true;
            this.lbl_NewPWS.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NewPWS.Location = new System.Drawing.Point(9, 39);
            this.lbl_NewPWS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NewPWS.Name = "lbl_NewPWS";
            this.lbl_NewPWS.Size = new System.Drawing.Size(114, 20);
            this.lbl_NewPWS.TabIndex = 17;
            this.lbl_NewPWS.Text = "请输入新密码：";
            // 
            // lbl_ReNewPWS
            // 
            this.lbl_ReNewPWS.AutoSize = true;
            this.lbl_ReNewPWS.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ReNewPWS.Location = new System.Drawing.Point(11, 90);
            this.lbl_ReNewPWS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReNewPWS.Name = "lbl_ReNewPWS";
            this.lbl_ReNewPWS.Size = new System.Drawing.Size(114, 20);
            this.lbl_ReNewPWS.TabIndex = 17;
            this.lbl_ReNewPWS.Text = "请确定新密码：";
            // 
            // txt_NewPWS
            // 
            this.txt_NewPWS.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_NewPWS.Location = new System.Drawing.Point(122, 38);
            this.txt_NewPWS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NewPWS.Name = "txt_NewPWS";
            this.txt_NewPWS.PasswordChar = '*';
            this.txt_NewPWS.Size = new System.Drawing.Size(152, 27);
            this.txt_NewPWS.TabIndex = 0;
            // 
            // txt_ReNewPWS
            // 
            this.txt_ReNewPWS.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ReNewPWS.Location = new System.Drawing.Point(124, 87);
            this.txt_ReNewPWS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ReNewPWS.Name = "txt_ReNewPWS";
            this.txt_ReNewPWS.PasswordChar = '*';
            this.txt_ReNewPWS.Size = new System.Drawing.Size(152, 27);
            this.txt_ReNewPWS.TabIndex = 1;
            // 
            // Btn_Sure
            // 
            this.Btn_Sure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sure.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Sure.Location = new System.Drawing.Point(5, 128);
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
            this.Btn_Init.Location = new System.Drawing.Point(100, 128);
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
            this.Btn_Back.Location = new System.Drawing.Point(194, 128);
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
            // Frm_ChangePWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Init);
            this.Controls.Add(this.Btn_Sure);
            this.Controls.Add(this.txt_ReNewPWS);
            this.Controls.Add(this.txt_NewPWS);
            this.Controls.Add(this.lbl_ReNewPWS);
            this.Controls.Add(this.lbl_NewPWS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_ChangePWS";
            this.Text = "更改密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ChangePWS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_NewPWS;
        private System.Windows.Forms.Label lbl_ReNewPWS;
        private System.Windows.Forms.TextBox txt_NewPWS;
        private System.Windows.Forms.TextBox txt_ReNewPWS;
        private System.Windows.Forms.Button Btn_Sure;
        private System.Windows.Forms.Button Btn_Init;
        private System.Windows.Forms.Button Btn_Back;
    }
}