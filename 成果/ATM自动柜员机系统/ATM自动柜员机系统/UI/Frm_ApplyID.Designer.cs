namespace UI
{
    partial class Frm_CardID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CardID));
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.lbl_PWSQuestion = new System.Windows.Forms.Label();
            this.cbox_PWSQuestion = new System.Windows.Forms.ComboBox();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_PWSAnswer = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.Btn_Sure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserName.Location = new System.Drawing.Point(8, 40);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(54, 20);
            this.lbl_UserName.TabIndex = 9;
            this.lbl_UserName.Text = "姓名：";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(82, 42);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(96, 21);
            this.txt_UserName.TabIndex = 0;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_UserID.Location = new System.Drawing.Point(8, 154);
            this.lbl_UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(84, 20);
            this.lbl_UserID.TabIndex = 9;
            this.lbl_UserID.Text = "身份证号：";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(82, 157);
            this.txt_UserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(96, 21);
            this.txt_UserID.TabIndex = 3;
            // 
            // lbl_PWSQuestion
            // 
            this.lbl_PWSQuestion.AutoSize = true;
            this.lbl_PWSQuestion.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PWSQuestion.Location = new System.Drawing.Point(192, 41);
            this.lbl_PWSQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_PWSQuestion.Name = "lbl_PWSQuestion";
            this.lbl_PWSQuestion.Size = new System.Drawing.Size(84, 20);
            this.lbl_PWSQuestion.TabIndex = 9;
            this.lbl_PWSQuestion.Text = "密保问题：";
            // 
            // cbox_PWSQuestion
            // 
            this.cbox_PWSQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_PWSQuestion.FormattingEnabled = true;
            this.cbox_PWSQuestion.Items.AddRange(new object[] {
            "您的口头禅是？",
            "您的母校是？",
            "您父亲的姓名？",
            "您母亲的姓名？",
            "您爱人的姓名？"});
            this.cbox_PWSQuestion.Location = new System.Drawing.Point(275, 40);
            this.cbox_PWSQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbox_PWSQuestion.Name = "cbox_PWSQuestion";
            this.cbox_PWSQuestion.Size = new System.Drawing.Size(96, 20);
            this.cbox_PWSQuestion.TabIndex = 4;
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Answer.Location = new System.Drawing.Point(192, 75);
            this.lbl_Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(84, 20);
            this.lbl_Answer.TabIndex = 9;
            this.lbl_Answer.Text = "密保答案：";
            // 
            // txt_PWSAnswer
            // 
            this.txt_PWSAnswer.Location = new System.Drawing.Point(275, 75);
            this.txt_PWSAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PWSAnswer.Name = "txt_PWSAnswer";
            this.txt_PWSAnswer.Size = new System.Drawing.Size(96, 21);
            this.txt_PWSAnswer.TabIndex = 5;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(82, 117);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(96, 21);
            this.txt_Password.TabIndex = 2;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(8, 114);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(54, 20);
            this.lbl_Password.TabIndex = 13;
            this.lbl_Password.Text = "密码：";
            // 
            // Btn_Sure
            // 
            this.Btn_Sure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sure.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Sure.Location = new System.Drawing.Point(196, 126);
            this.Btn_Sure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Sure.Name = "Btn_Sure";
            this.Btn_Sure.Size = new System.Drawing.Size(176, 53);
            this.Btn_Sure.TabIndex = 6;
            this.Btn_Sure.Text = "确  定  注  册";
            this.Btn_Sure.UseVisualStyleBackColor = true;
            this.Btn_Sure.Click += new System.EventHandler(this.Btn_Sure_Click);
            this.Btn_Sure.MouseLeave += new System.EventHandler(this.Btn_Sure_MouseLeave);
            this.Btn_Sure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Sure_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "卡号：";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(82, 78);
            this.txt_CardID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(96, 21);
            this.txt_CardID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "卡号密码 长度小于8位 可英文数字";
            // 
            // Frm_CardID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(380, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Sure);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.cbox_PWSQuestion);
            this.Controls.Add(this.txt_PWSAnswer);
            this.Controls.Add(this.txt_CardID);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.lbl_Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PWSQuestion);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_CardID";
            this.Text = "注册账号";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ApplyID_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label lbl_PWSQuestion;
        private System.Windows.Forms.ComboBox cbox_PWSQuestion;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_PWSAnswer;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button Btn_Sure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.Label label2;
    }
}