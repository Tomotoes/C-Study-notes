namespace UI
{
    partial class Frm_SelectData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SelectData));
            this.dgv_Save = new System.Windows.Forms.DataGridView();
            this.TradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gBox_Choice = new System.Windows.Forms.GroupBox();
            this.rBtn_Bring = new System.Windows.Forms.RadioButton();
            this.rBtn_Draw = new System.Windows.Forms.RadioButton();
            this.rBtn_Save = new System.Windows.Forms.RadioButton();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.dgv_Draw = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Bring = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Save)).BeginInit();
            this.gBox_Choice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Draw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bring)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Save
            // 
            this.dgv_Save.AllowUserToAddRows = false;
            this.dgv_Save.AllowUserToDeleteRows = false;
            this.dgv_Save.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Save.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Save.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Save.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Save.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Save.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Save.ColumnHeadersHeight = 30;
            this.dgv_Save.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TradeID,
            this.CardID,
            this.Cash,
            this.Balance,
            this.Time});
            this.dgv_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Save.GridColor = System.Drawing.Color.Bisque;
            this.dgv_Save.Location = new System.Drawing.Point(-44, 28);
            this.dgv_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Save.Name = "dgv_Save";
            this.dgv_Save.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_Save.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Save.RowTemplate.Height = 27;
            this.dgv_Save.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Save.Size = new System.Drawing.Size(596, 245);
            this.dgv_Save.TabIndex = 0;
            // 
            // TradeID
            // 
            this.TradeID.DataPropertyName = "TradeID";
            this.TradeID.HeaderText = "交易流水号";
            this.TradeID.Name = "TradeID";
            this.TradeID.ReadOnly = true;
            // 
            // CardID
            // 
            this.CardID.DataPropertyName = "CardID";
            this.CardID.HeaderText = "卡号";
            this.CardID.Name = "CardID";
            this.CardID.ReadOnly = true;
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "存款金额";
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "当前余额";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "存款日期";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // gBox_Choice
            // 
            this.gBox_Choice.Controls.Add(this.rBtn_Bring);
            this.gBox_Choice.Controls.Add(this.rBtn_Draw);
            this.gBox_Choice.Controls.Add(this.rBtn_Save);
            this.gBox_Choice.Location = new System.Drawing.Point(9, 278);
            this.gBox_Choice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBox_Choice.Name = "gBox_Choice";
            this.gBox_Choice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gBox_Choice.Size = new System.Drawing.Size(542, 70);
            this.gBox_Choice.TabIndex = 16;
            this.gBox_Choice.TabStop = false;
            this.gBox_Choice.Text = "选择";
            // 
            // rBtn_Bring
            // 
            this.rBtn_Bring.AutoSize = true;
            this.rBtn_Bring.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_Bring.Location = new System.Drawing.Point(360, 28);
            this.rBtn_Bring.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Bring.Name = "rBtn_Bring";
            this.rBtn_Bring.Size = new System.Drawing.Size(87, 24);
            this.rBtn_Bring.TabIndex = 0;
            this.rBtn_Bring.TabStop = true;
            this.rBtn_Bring.Text = "转帐记录";
            this.rBtn_Bring.UseVisualStyleBackColor = true;
            this.rBtn_Bring.CheckedChanged += new System.EventHandler(this.rBtn_Bring_CheckedChanged);
            // 
            // rBtn_Draw
            // 
            this.rBtn_Draw.AutoSize = true;
            this.rBtn_Draw.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_Draw.Location = new System.Drawing.Point(180, 28);
            this.rBtn_Draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Draw.Name = "rBtn_Draw";
            this.rBtn_Draw.Size = new System.Drawing.Size(87, 24);
            this.rBtn_Draw.TabIndex = 0;
            this.rBtn_Draw.TabStop = true;
            this.rBtn_Draw.Text = "取款记录";
            this.rBtn_Draw.UseVisualStyleBackColor = true;
            this.rBtn_Draw.CheckedChanged += new System.EventHandler(this.rBtn_Draw_CheckedChanged);
            // 
            // rBtn_Save
            // 
            this.rBtn_Save.AutoSize = true;
            this.rBtn_Save.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rBtn_Save.Location = new System.Drawing.Point(14, 28);
            this.rBtn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBtn_Save.Name = "rBtn_Save";
            this.rBtn_Save.Size = new System.Drawing.Size(87, 24);
            this.rBtn_Save.TabIndex = 0;
            this.rBtn_Save.TabStop = true;
            this.rBtn_Save.Text = "存款记录";
            this.rBtn_Save.UseVisualStyleBackColor = true;
            this.rBtn_Save.CheckedChanged += new System.EventHandler(this.rBtn_Save_CheckedChanged);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Exit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Exit.Location = new System.Drawing.Point(189, 364);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(171, 58);
            this.Btn_Exit.TabIndex = 15;
            this.Btn_Exit.Text = "退  卡";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            this.Btn_Exit.MouseLeave += new System.EventHandler(this.Btn_Print_MouseLeave);
            this.Btn_Exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Print_MouseMove);
            // 
            // Btn_Back
            // 
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Back.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Back.Location = new System.Drawing.Point(369, 364);
            this.Btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(171, 58);
            this.Btn_Back.TabIndex = 15;
            this.Btn_Back.Text = "返回菜单";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            this.Btn_Back.MouseLeave += new System.EventHandler(this.Btn_Print_MouseLeave);
            this.Btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Print_MouseMove);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // dgv_Draw
            // 
            this.dgv_Draw.AllowUserToAddRows = false;
            this.dgv_Draw.AllowUserToDeleteRows = false;
            this.dgv_Draw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Draw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Draw.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Draw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Draw.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Draw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Draw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Draw.ColumnHeadersHeight = 30;
            this.dgv_Draw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_Draw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Draw.GridColor = System.Drawing.Color.Bisque;
            this.dgv_Draw.Location = new System.Drawing.Point(-44, 28);
            this.dgv_Draw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Draw.Name = "dgv_Draw";
            this.dgv_Draw.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_Draw.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Draw.RowTemplate.Height = 27;
            this.dgv_Draw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Draw.Size = new System.Drawing.Size(607, 245);
            this.dgv_Draw.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TradeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "交易流水号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CardID";
            this.dataGridViewTextBoxColumn2.HeaderText = "卡号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cash";
            this.dataGridViewTextBoxColumn3.HeaderText = "取款金额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Balance";
            this.dataGridViewTextBoxColumn4.HeaderText = "当前余额";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "取款日期";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dgv_Bring
            // 
            this.dgv_Bring.AllowUserToAddRows = false;
            this.dgv_Bring.AllowUserToDeleteRows = false;
            this.dgv_Bring.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Bring.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Bring.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_Bring.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Bring.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Bring.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Bring.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Bring.ColumnHeadersHeight = 30;
            this.dgv_Bring.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.SourceCardID,
            this.TargetCardID,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgv_Bring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Bring.GridColor = System.Drawing.Color.Bisque;
            this.dgv_Bring.Location = new System.Drawing.Point(-42, 28);
            this.dgv_Bring.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Bring.Name = "dgv_Bring";
            this.dgv_Bring.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_Bring.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Bring.RowTemplate.Height = 27;
            this.dgv_Bring.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Bring.Size = new System.Drawing.Size(594, 245);
            this.dgv_Bring.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TradeID";
            this.dataGridViewTextBoxColumn7.HeaderText = "交易流水号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // SourceCardID
            // 
            this.SourceCardID.DataPropertyName = "SourceCardID";
            this.SourceCardID.HeaderText = "转帐源卡号";
            this.SourceCardID.Name = "SourceCardID";
            this.SourceCardID.ReadOnly = true;
            // 
            // TargetCardID
            // 
            this.TargetCardID.DataPropertyName = "TargetCardID";
            this.TargetCardID.HeaderText = "转帐目标卡号";
            this.TargetCardID.Name = "TargetCardID";
            this.TargetCardID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cash";
            this.dataGridViewTextBoxColumn8.HeaderText = "转帐金额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn9.HeaderText = "转账日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Btn_Print
            // 
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Print.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Print.Location = new System.Drawing.Point(9, 364);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(171, 58);
            this.Btn_Print.TabIndex = 15;
            this.Btn_Print.Text = "打印详单";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            this.Btn_Print.MouseLeave += new System.EventHandler(this.Btn_Print_MouseLeave);
            this.Btn_Print.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Print_MouseMove);
            // 
            // Frm_SelectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(549, 438);
            this.Controls.Add(this.gBox_Choice);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.dgv_Bring);
            this.Controls.Add(this.dgv_Draw);
            this.Controls.Add(this.dgv_Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Frm_SelectData";
            this.Text = "记录窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_SelectData_FormClosing);
            this.Load += new System.EventHandler(this.Frm_SelectData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Save)).EndInit();
            this.gBox_Choice.ResumeLayout(false);
            this.gBox_Choice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Draw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Bring)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Save;
        private System.Windows.Forms.GroupBox gBox_Choice;
        private System.Windows.Forms.RadioButton rBtn_Bring;
        private System.Windows.Forms.RadioButton rBtn_Draw;
        private System.Windows.Forms.RadioButton rBtn_Save;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.DataGridView dgv_Draw;
        private System.Windows.Forms.DataGridView dgv_Bring;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button Btn_Print;
    }
}