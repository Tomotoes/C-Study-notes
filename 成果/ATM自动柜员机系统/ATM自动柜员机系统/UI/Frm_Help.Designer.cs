namespace UI
{
    partial class Frm_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Help));
            this.lbl_Main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Main
            // 
            this.lbl_Main.AutoSize = true;
            this.lbl_Main.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Main.ForeColor = System.Drawing.Color.Black;
            this.lbl_Main.Location = new System.Drawing.Point(2, 9);
            this.lbl_Main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Main.Name = "lbl_Main";
            this.lbl_Main.Size = new System.Drawing.Size(418, 120);
            this.lbl_Main.TabIndex = 2;
            this.lbl_Main.Text = "1.退卡时请拿好您的卡\r\n2.ATM机周围的广告不要相信\r\n3.输入密码是请注意周边环境是否安全\r\n4.如果遇到紧急情况，请拨打银行电话\r\n5.有事请打110";
            this.lbl_Main.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Frm_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 139);
            this.Controls.Add(this.lbl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帮助界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Main;
    }
}