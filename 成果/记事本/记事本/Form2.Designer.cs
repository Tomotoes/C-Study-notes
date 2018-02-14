namespace 记事本
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectText = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.DXX = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.UPS = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容(&N):";
            // 
            // SelectText
            // 
            this.SelectText.Location = new System.Drawing.Point(126, 27);
            this.SelectText.Name = "SelectText";
            this.SelectText.Size = new System.Drawing.Size(226, 25);
            this.SelectText.TabIndex = 1;
            this.SelectText.TextChanged += new System.EventHandler(this.SelectText_TextChanged);
            // 
            // Find
            // 
            this.Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find.Enabled = false;
            this.Find.Location = new System.Drawing.Point(370, 19);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(131, 37);
            this.Find.TabIndex = 2;
            this.Find.Text = "查找下一个(&F)";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // DXX
            // 
            this.DXX.AutoSize = true;
            this.DXX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DXX.Location = new System.Drawing.Point(24, 85);
            this.DXX.Name = "DXX";
            this.DXX.Size = new System.Drawing.Size(128, 19);
            this.DXX.TabIndex = 3;
            this.DXX.Text = "区分大小写(&C)";
            this.DXX.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.UPS);
            this.groupBox1.Location = new System.Drawing.Point(158, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 57);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Location = new System.Drawing.Point(109, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "向下(&D)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // UPS
            // 
            this.UPS.AutoSize = true;
            this.UPS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UPS.Location = new System.Drawing.Point(21, 24);
            this.UPS.Name = "UPS";
            this.UPS.Size = new System.Drawing.Size(82, 19);
            this.UPS.TabIndex = 0;
            this.UPS.Text = "向上(&U)";
            this.UPS.UseVisualStyleBackColor = true;
            this.UPS.CheckedChanged += new System.EventHandler(this.UPS_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Location = new System.Drawing.Point(370, 72);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(131, 33);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 131);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DXX);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.SelectText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectText;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.CheckBox DXX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton UPS;
        private System.Windows.Forms.Button Cancel;
    }
}