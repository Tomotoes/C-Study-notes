namespace UI
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Btn_Draw = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Bring = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Btn_Change = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            this.lbl_First = new System.Windows.Forms.Label();
            this.lbl_One = new System.Windows.Forms.Label();
            this.lbl_Two = new System.Windows.Forms.Label();
            this.lbl_Three = new System.Windows.Forms.Label();
            this.lbl_Four = new System.Windows.Forms.Label();
            this.lbl_Five = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.pic_Second = new System.Windows.Forms.PictureBox();
            this.pic_First = new System.Windows.Forms.PictureBox();
            this.pic_Third = new System.Windows.Forms.PictureBox();
            this.pic_Fourth = new System.Windows.Forms.PictureBox();
            this.pic_Fivth = new System.Windows.Forms.PictureBox();
            this.lbl_Second = new System.Windows.Forms.Label();
            this.lbl_Third = new System.Windows.Forms.Label();
            this.lbl_Fourth = new System.Windows.Forms.Label();
            this.lbl_Fivth = new System.Windows.Forms.Label();
            this.Btn_SelectData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_First)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Third)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fourth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fivth)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Draw
            // 
            this.Btn_Draw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Draw.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Draw.Location = new System.Drawing.Point(11, 37);
            this.Btn_Draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Draw.Name = "Btn_Draw";
            this.Btn_Draw.Size = new System.Drawing.Size(81, 33);
            this.Btn_Draw.TabIndex = 14;
            this.Btn_Draw.Text = "取  款";
            this.Btn_Draw.UseVisualStyleBackColor = true;
            this.Btn_Draw.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_Draw.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_Save
            // 
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Save.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Save.Location = new System.Drawing.Point(11, 91);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(81, 33);
            this.Btn_Save.TabIndex = 14;
            this.Btn_Save.Text = "存  款";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_Save.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Save.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_Bring
            // 
            this.Btn_Bring.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Bring.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Bring.Location = new System.Drawing.Point(11, 142);
            this.Btn_Bring.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Bring.Name = "Btn_Bring";
            this.Btn_Bring.Size = new System.Drawing.Size(81, 33);
            this.Btn_Bring.TabIndex = 14;
            this.Btn_Bring.Text = "转  账";
            this.Btn_Bring.UseVisualStyleBackColor = true;
            this.Btn_Bring.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_Bring.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Bring.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Exit.Location = new System.Drawing.Point(11, 200);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(81, 33);
            this.Btn_Exit.TabIndex = 14;
            this.Btn_Exit.Text = "退  卡";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            this.Btn_Exit.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_Select
            // 
            this.Btn_Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Select.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Select.Location = new System.Drawing.Point(316, 37);
            this.Btn_Select.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(81, 33);
            this.Btn_Select.TabIndex = 14;
            this.Btn_Select.Text = "查询余额";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_Select.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Select.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_Change
            // 
            this.Btn_Change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Change.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Change.Location = new System.Drawing.Point(316, 91);
            this.Btn_Change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Change.Name = "Btn_Change";
            this.Btn_Change.Size = new System.Drawing.Size(81, 33);
            this.Btn_Change.TabIndex = 14;
            this.Btn_Change.Text = "修改密码";
            this.Btn_Change.UseVisualStyleBackColor = true;
            this.Btn_Change.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_Change.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_Change.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Btn_About
            // 
            this.Btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_About.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_About.Location = new System.Drawing.Point(316, 200);
            this.Btn_About.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(81, 33);
            this.Btn_About.TabIndex = 14;
            this.Btn_About.Text = "关于我们";
            this.Btn_About.UseVisualStyleBackColor = true;
            this.Btn_About.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_About.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_About.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // lbl_First
            // 
            this.lbl_First.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_First.Location = new System.Drawing.Point(106, 37);
            this.lbl_First.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(194, 26);
            this.lbl_First.TabIndex = 15;
            this.lbl_First.Text = "切忌用生日做为银行卡密码.";
            // 
            // lbl_One
            // 
            this.lbl_One.AutoSize = true;
            this.lbl_One.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_One.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_One.ForeColor = System.Drawing.Color.White;
            this.lbl_One.Location = new System.Drawing.Point(114, 218);
            this.lbl_One.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_One.Name = "lbl_One";
            this.lbl_One.Size = new System.Drawing.Size(15, 17);
            this.lbl_One.TabIndex = 17;
            this.lbl_One.Text = "1";
            // 
            // lbl_Two
            // 
            this.lbl_Two.AutoSize = true;
            this.lbl_Two.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Two.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Two.ForeColor = System.Drawing.Color.White;
            this.lbl_Two.Location = new System.Drawing.Point(155, 218);
            this.lbl_Two.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Two.Name = "lbl_Two";
            this.lbl_Two.Size = new System.Drawing.Size(15, 17);
            this.lbl_Two.TabIndex = 17;
            this.lbl_Two.Text = "2";
            // 
            // lbl_Three
            // 
            this.lbl_Three.AutoSize = true;
            this.lbl_Three.BackColor = System.Drawing.Color.Gray;
            this.lbl_Three.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Three.ForeColor = System.Drawing.Color.White;
            this.lbl_Three.Location = new System.Drawing.Point(196, 218);
            this.lbl_Three.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Three.Name = "lbl_Three";
            this.lbl_Three.Size = new System.Drawing.Size(15, 17);
            this.lbl_Three.TabIndex = 17;
            this.lbl_Three.Text = "3";
            // 
            // lbl_Four
            // 
            this.lbl_Four.AutoSize = true;
            this.lbl_Four.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Four.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Four.ForeColor = System.Drawing.Color.White;
            this.lbl_Four.Location = new System.Drawing.Point(238, 218);
            this.lbl_Four.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Four.Name = "lbl_Four";
            this.lbl_Four.Size = new System.Drawing.Size(15, 17);
            this.lbl_Four.TabIndex = 17;
            this.lbl_Four.Text = "4";
            // 
            // lbl_Five
            // 
            this.lbl_Five.AutoSize = true;
            this.lbl_Five.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Five.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Five.ForeColor = System.Drawing.Color.White;
            this.lbl_Five.Location = new System.Drawing.Point(279, 218);
            this.lbl_Five.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Five.Name = "lbl_Five";
            this.lbl_Five.Size = new System.Drawing.Size(15, 17);
            this.lbl_Five.TabIndex = 17;
            this.lbl_Five.Text = "5";
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // pic_Second
            // 
            this.pic_Second.Image = ((System.Drawing.Image)(resources.GetObject("pic_Second.Image")));
            this.pic_Second.Location = new System.Drawing.Point(111, 65);
            this.pic_Second.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Second.Name = "pic_Second";
            this.pic_Second.Size = new System.Drawing.Size(183, 148);
            this.pic_Second.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Second.TabIndex = 16;
            this.pic_Second.TabStop = false;
            // 
            // pic_First
            // 
            this.pic_First.Image = ((System.Drawing.Image)(resources.GetObject("pic_First.Image")));
            this.pic_First.Location = new System.Drawing.Point(111, 65);
            this.pic_First.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_First.Name = "pic_First";
            this.pic_First.Size = new System.Drawing.Size(182, 148);
            this.pic_First.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_First.TabIndex = 16;
            this.pic_First.TabStop = false;
            // 
            // pic_Third
            // 
            this.pic_Third.Image = ((System.Drawing.Image)(resources.GetObject("pic_Third.Image")));
            this.pic_Third.Location = new System.Drawing.Point(111, 65);
            this.pic_Third.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Third.Name = "pic_Third";
            this.pic_Third.Size = new System.Drawing.Size(183, 148);
            this.pic_Third.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Third.TabIndex = 16;
            this.pic_Third.TabStop = false;
            // 
            // pic_Fourth
            // 
            this.pic_Fourth.Image = ((System.Drawing.Image)(resources.GetObject("pic_Fourth.Image")));
            this.pic_Fourth.Location = new System.Drawing.Point(111, 65);
            this.pic_Fourth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Fourth.Name = "pic_Fourth";
            this.pic_Fourth.Size = new System.Drawing.Size(183, 148);
            this.pic_Fourth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Fourth.TabIndex = 16;
            this.pic_Fourth.TabStop = false;
            // 
            // pic_Fivth
            // 
            this.pic_Fivth.Image = ((System.Drawing.Image)(resources.GetObject("pic_Fivth.Image")));
            this.pic_Fivth.Location = new System.Drawing.Point(111, 65);
            this.pic_Fivth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Fivth.Name = "pic_Fivth";
            this.pic_Fivth.Size = new System.Drawing.Size(183, 148);
            this.pic_Fivth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Fivth.TabIndex = 16;
            this.pic_Fivth.TabStop = false;
            this.pic_Fivth.Visible = false;
            // 
            // lbl_Second
            // 
            this.lbl_Second.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Second.Location = new System.Drawing.Point(106, 37);
            this.lbl_Second.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Second.Name = "lbl_Second";
            this.lbl_Second.Size = new System.Drawing.Size(194, 26);
            this.lbl_Second.TabIndex = 15;
            this.lbl_Second.Text = "必须防止别人偷窥您的密码.";
            // 
            // lbl_Third
            // 
            this.lbl_Third.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Third.Location = new System.Drawing.Point(106, 34);
            this.lbl_Third.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Third.Name = "lbl_Third";
            this.lbl_Third.Size = new System.Drawing.Size(194, 26);
            this.lbl_Third.TabIndex = 15;
            this.lbl_Third.Text = "若前面有人一定要保持距离.";
            // 
            // lbl_Fourth
            // 
            this.lbl_Fourth.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Fourth.Location = new System.Drawing.Point(106, 34);
            this.lbl_Fourth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fourth.Name = "lbl_Fourth";
            this.lbl_Fourth.Size = new System.Drawing.Size(194, 26);
            this.lbl_Fourth.TabIndex = 15;
            this.lbl_Fourth.Text = "身份证银行卡不能放在一起.";
            // 
            // lbl_Fivth
            // 
            this.lbl_Fivth.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Fivth.Location = new System.Drawing.Point(106, 34);
            this.lbl_Fivth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fivth.Name = "lbl_Fivth";
            this.lbl_Fivth.Size = new System.Drawing.Size(194, 26);
            this.lbl_Fivth.TabIndex = 15;
            this.lbl_Fivth.Text = "取完钱后不要丢弃交易凭条.";
            // 
            // Btn_SelectData
            // 
            this.Btn_SelectData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_SelectData.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_SelectData.Location = new System.Drawing.Point(316, 142);
            this.Btn_SelectData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_SelectData.Name = "Btn_SelectData";
            this.Btn_SelectData.Size = new System.Drawing.Size(81, 33);
            this.Btn_SelectData.TabIndex = 14;
            this.Btn_SelectData.Text = "查询记录";
            this.Btn_SelectData.UseVisualStyleBackColor = true;
            this.Btn_SelectData.Click += new System.EventHandler(this.Btn_Bring_Click);
            this.Btn_SelectData.MouseLeave += new System.EventHandler(this.Btn_Exit_MouseLeave);
            this.Btn_SelectData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Exit_MouseMove);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(410, 245);
            this.Controls.Add(this.lbl_Five);
            this.Controls.Add(this.lbl_Four);
            this.Controls.Add(this.lbl_Three);
            this.Controls.Add(this.lbl_Two);
            this.Controls.Add(this.lbl_One);
            this.Controls.Add(this.pic_Fivth);
            this.Controls.Add(this.pic_Fourth);
            this.Controls.Add(this.pic_Third);
            this.Controls.Add(this.pic_Second);
            this.Controls.Add(this.pic_First);
            this.Controls.Add(this.lbl_Fivth);
            this.Controls.Add(this.lbl_Fourth);
            this.Controls.Add(this.lbl_Third);
            this.Controls.Add(this.lbl_Second);
            this.Controls.Add(this.lbl_First);
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Bring);
            this.Controls.Add(this.Btn_SelectData);
            this.Controls.Add(this.Btn_Change);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.Btn_Draw);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.Text = "主页面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_First)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Third)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fourth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Fivth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Draw;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Bring;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.Button Btn_Change;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.Label lbl_One;
        private System.Windows.Forms.Label lbl_Two;
        private System.Windows.Forms.Label lbl_Three;
        private System.Windows.Forms.Label lbl_Four;
        private System.Windows.Forms.Label lbl_Five;
        private System.Windows.Forms.PictureBox pic_Second;
        private System.Windows.Forms.PictureBox pic_First;
        private System.Windows.Forms.PictureBox pic_Third;
        private System.Windows.Forms.PictureBox pic_Fourth;
        private System.Windows.Forms.PictureBox pic_Fivth;
        private System.Windows.Forms.Label lbl_Second;
        private System.Windows.Forms.Label lbl_Third;
        private System.Windows.Forms.Label lbl_Fourth;
        private System.Windows.Forms.Label lbl_Fivth;
        public System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button Btn_SelectData;
    }
}