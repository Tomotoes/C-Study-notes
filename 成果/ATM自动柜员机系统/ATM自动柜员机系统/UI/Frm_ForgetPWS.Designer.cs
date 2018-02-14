namespace UI
{
    partial class Frm_ForgetPWS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ForgetPWS));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_Answer = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.Btn_Sure = new System.Windows.Forms.Button();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Question.Location = new System.Drawing.Point(12, 48);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(84, 20);
            this.lbl_Question.TabIndex = 8;
            this.lbl_Question.Text = "密保问题：";
            // 
            // lbl_Answer
            // 
            this.lbl_Answer.AutoSize = true;
            this.lbl_Answer.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Answer.Location = new System.Drawing.Point(15, 93);
            this.lbl_Answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Answer.Name = "lbl_Answer";
            this.lbl_Answer.Size = new System.Drawing.Size(84, 20);
            this.lbl_Answer.TabIndex = 8;
            this.lbl_Answer.Text = "正确答案：";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Location = new System.Drawing.Point(97, 93);
            this.txt_Answer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(96, 21);
            this.txt_Answer.TabIndex = 0;
            // 
            // Btn_Sure
            // 
            this.Btn_Sure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Sure.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Sure.Location = new System.Drawing.Point(217, 36);
            this.Btn_Sure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Sure.Name = "Btn_Sure";
            this.Btn_Sure.Size = new System.Drawing.Size(81, 87);
            this.Btn_Sure.TabIndex = 2;
            this.Btn_Sure.Text = "确 定";
            this.Btn_Sure.UseVisualStyleBackColor = true;
            this.Btn_Sure.Click += new System.EventHandler(this.Btn_Sure_Click);
            this.Btn_Sure.MouseLeave += new System.EventHandler(this.Btn_Sure_MouseLeave);
            this.Btn_Sure.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Sure_MouseMove);
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(97, 48);
            this.txt_Question.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.ReadOnly = true;
            this.txt_Question.Size = new System.Drawing.Size(96, 21);
            this.txt_Question.TabIndex = 8;
            // 
            // Frm_ForgetPWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(311, 134);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.Btn_Sure);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.lbl_Answer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_ForgetPWS";
            this.Text = "忘记密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ForgetPWS_FormClosed);
            this.Load += new System.EventHandler(this.Frm_ForgetPWS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_Answer;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Button Btn_Sure;
        private System.Windows.Forms.TextBox txt_Question;
    }
}