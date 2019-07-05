using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Collections;
using System.Drawing.Imaging;

namespace 学生信息管理系统
{
    class Heart
    {
        #region 定义数据库成员
        static SqlDataAdapter Ada;
        static SqlCommandBuilder CB;
        static public DataSet Set;
        static public bool Cmp = false;
        #endregion

        #region 实例数据库对象
        static public void Start()
        {
            Ada = new SqlDataAdapter("select * from Information", "server=.;database=StudentPlus;integrated security=true");
            Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            CB = new SqlCommandBuilder(Ada);
            Set = new DataSet();
            Ada.Fill(Set);
        }
        #endregion

        #region 释放数据库对象
        static public void End()
        {
            Ada.Update(Set);
            Ada.Dispose();
            CB.Dispose();
            Set.Dispose();
        }
        #endregion

        #region 判断数据库连接
        static public bool CmpCon()
        {
            SqlConnection Con = new SqlConnection("server =.; database = StudentPlus; integrated security = true");
            try { Con.Open();  }
            catch { Con.Dispose(); return false; }
            Con.Dispose(); 
            return Cmp = true;
        }
        #endregion

        #region 读取数据库数据
        static public void Read(int InfoIndex,int ImageIndex, ReadInfoForm ReadInfo)
        {
            Start();
            if (ImageIndex > 9)
            {
                ImageIndex = 5;
            }
            if (ImageIndex == 5)
            {
                ReadInfo.textBox1.Text = Set.Tables[0].Rows[InfoIndex][0].ToString();
                ReadInfo.textBox2.Text = Set.Tables[0].Rows[InfoIndex][1].ToString();
                ReadInfo.textBox3.Text = Set.Tables[0].Rows[InfoIndex][2].ToString();
                ReadInfo.textBox4.Text = Set.Tables[0].Rows[InfoIndex][3].ToString();
                ReadInfo.textBox5.Text = Set.Tables[0].Rows[InfoIndex][4].ToString();
            }
            if (Set.Tables[0].Rows[InfoIndex][5] == System.DBNull.Value)
            {
                ReadInfo.pictureBox1.Image = Image.FromFile("Image/NoPicture.jpg");
                ReadInfo.button5.Enabled = ReadInfo.button6.Enabled =
                ReadInfo.button8.Enabled = ReadInfo.button9.Enabled =
                false;
            }
            else
            {
                if (!ReadInfo.button6.Enabled)
                {
                    ReadInfo.button5.Enabled = ReadInfo.button6.Enabled =
                    ReadInfo.button8.Enabled = ReadInfo.button9.Enabled =
                    true;
                }
                try
                {
                    ReadInfo.pictureBox1.Image =
                        GetImage((byte[])Set.Tables[0].Rows[InfoIndex][ImageIndex]);
                }
                catch { MessageBox.Show(ImageIndex.ToString()); }
               
            }
            if (ReadInfo.button6.Enabled)
            {
                if (Heart.ImageIndexMax(InfoIndex,ImageIndex) == 5)
                {
                    ReadInfo.button5.Enabled = ReadInfo.button8.Enabled = 
                    ReadInfo.button9.Enabled = false;
                }
                else
                {
                    ReadInfo.button5.Enabled = ReadInfo.button8.Enabled =
                    ReadInfo.button9.Enabled = true;
                }
            }
            End();
        }
        #endregion

        #region 增加数据库数据
        static public bool Insert(string No,string Name,string Sex,string Age,string Dept,byte[] Image)
        {
            Start();
            if (No == "")
            {
                MessageBox.Show("学号不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Name == "")
            {
                MessageBox.Show("姓名不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Sex != "男" && Sex != "女")
            {
                MessageBox.Show("性别错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Age == "" ||
                Convert.ToInt32(Age) > 40 || Convert.ToInt32(Age) < 5)
            {
                MessageBox.Show("年龄错误！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Dept == "")
            {
                MessageBox.Show("专业不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Image == null)
            {
                MessageBox.Show("照片不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow Res = Set.Tables[0].Rows.Find(No);
            if (Res != null)
            {
                MessageBox.Show("该学号已经存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow Ac = Set.Tables[0].NewRow();
            Ac[0] = No;
            Ac[1] = Name;
            Ac[2] = Sex;
            Ac[3] = Age;
            Ac[4] = Dept;
            Ac[5] = Image;
            Set.Tables[0].Rows.Add(Ac);
            End();
            return true;
        }
        #endregion

        #region 删除数据库数据
        static public bool Delete(string No)
        {
            Start();
            DataRow Ac = Set.Tables[0].Rows.Find(No);
            if (MessageBox.Show("您确定要删除" + Ac[1].ToString() + "的信息吗？", "Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return false;
            }
            else
            {
                Ac.Delete();
            }
            
            End();
            return true;
        }
        #endregion

        #region 修改数据库数据
        static public bool Updata(string No,string Name,string Sex,string Age,string Dept)
        {
            Start();
            DataRow Ac = Set.Tables[0].Rows.Find(No);
            if (Name == Ac[1].ToString() && Sex == Ac[2].ToString() && Age == Ac[3].ToString() && Dept == Ac[4].ToString())
            {
                MessageBox.Show("必须修改一项信息！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Ac[1] = Name;
            Ac[2] = Sex;
            Ac[3] = Age;
            Ac[4] = Dept;
            End();
            return true;
        }
        #endregion

        #region 单查找数据库数据
        static public bool SingleSearch(string No, ManageInfoForm MThis)
        {
            Start();
            if (No == "")
            {
                MessageBox.Show("学号不能为空！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow Ac = Set.Tables[0].Rows.Find(No);
           
            MThis.textBox2.Text = Ac[1].ToString();
            MThis.comboBox1.Text = Ac[2].ToString();
            MThis.comboBox2.Text = Ac[3].ToString();
            MThis.textBox5.Text = Ac[4].ToString();
            if (Ac[5] != System.DBNull.Value)
            {
                MThis.pictureBox1.Image = GetImage((byte[])Ac[5]);
            }
            return true;
            End();
            
        }
        #endregion

        #region 多查找数据库数据
        static public void MoreSearch(string No,string Name,string Sex,string Age,string Dept,SearchInfoForm This)
        {
            string SelectText = "select * from Information where ";
            bool First = false;
            if (No == "" && Name == "" && Sex == "" && Age == "" && Dept == "")
            {
                MessageBox.Show("必须查询一项信息！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (No != "")
            {
                SelectText += "No='" + No + "'"; First = true;
            }
            if (Name != "")
            {
                if (First) { SelectText += " and "; }
                else { First = true; }
                SelectText += "Name like '%" + Name + "%'";
            }
            if (Sex != "")
            {
                if (First) { SelectText += " and "; }
                else { First = true; }
                SelectText += "Sex='" + Sex + "'";
            }
            if (Age != "")
            {
                if (First) { SelectText += " and "; }
                else { First = true; }
                SelectText += "Age='" + Age + "'";
            }
            if (Dept != "")
            {
                if (First) { SelectText += " and "; }
                SelectText += "Dept='" + Dept + "'";
            }
            
            SqlConnection Con = new SqlConnection("server=.;database=StudentPlus;integrated security=true");
            Con.Open();
            SqlCommand Com = new SqlCommand(SelectText, Con);
            SqlDataReader Reader = Com.ExecuteReader();
            This.tabControl1.SelectedIndex = 1;
            This.dataGridView2.Rows.Clear();
            bool Q = false;
            while (Reader.Read())
            {
                Q = true;
                foreach(DataGridViewRow Row in This.dataGridView1.Rows)
                {
                    if (Row.Cells[0].Value.ToString().CompareTo(Reader["No"].ToString())==0)
                    {
                        DataGridViewRow Result = (DataGridViewRow)(Row.Clone());
                        for(int i = 0; i < Row.Cells.Count; ++i)
                        {
                            Result.Cells[i].Value = Row.Cells[i].Value;
                        }
                        This.dataGridView2.Rows.Add(Result);
                        break;
                    }
                }
            }
            if (!Q){MessageBox.Show("没有查到相关数据！", "Result", MessageBoxButtons.OK);}
            Con.Dispose();
            Com.Dispose();
            Reader.Close();
        }
        #endregion

        #region 更改信息数据索引
        static public void ChangeInfoIndex(int Key,ref int InfoIndex,ref int ImageIndex,ReadInfoForm This)
        {
            This.button7.Enabled = true;
            Start();
            switch (Key)
            {
                case 1: if (++InfoIndex == Set.Tables[0].Rows.Count) { InfoIndex = 0; }
                    break;
                case 2: if (--InfoIndex == -1) { InfoIndex = Set.Tables[0].Rows.Count - 1; }
                    break;
                case 3: InfoIndex = 0;
                    break;
                case 4: InfoIndex = Set.Tables[0].Rows.Count - 1;
                    break;
            }
            Read(InfoIndex,ImageIndex = 5, This);
            End();
        }
        #endregion

        #region 更改图片数据索引
        static public void ChangeImageIndex(bool UpOrDown,int InfoIndex,ref int ImageIndex,ReadInfoForm This)
        {
            int ImageCount = ImageIndexMax(InfoIndex, ImageIndex);
            if (UpOrDown)
            {
                if (++ImageIndex > ImageCount)
                {
                    ImageIndex = 5;
                }
            }
            else
            {
                if (--ImageIndex < 5)
                {
                    ImageIndex = ImageCount;
                }
            }
            Read(InfoIndex, ImageIndex, This);
        }
        #endregion

        #region 获取信息照片个数
        static public int ImageIndexMax(int InfoIndex,int ImageIndex)
        {
            Start();
            if (Set.Tables[0].Rows[InfoIndex][9] != System.DBNull.Value) { return 9; }
            while (Set.Tables[0].Rows[InfoIndex][++ImageIndex] != System.DBNull.Value)
            {
                if (ImageIndex+1 >= 10)
                {
                    break;
                }
            }
            return ImageIndex-1;
            End();
        }
        #endregion

        #region 删除图片
        static public void DeleteImage(int InfoIndex,int ImageIndex,ReadInfoForm This)
        {
            DialogResult D = MessageBox.Show("您确定要删除当前照片吗？", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (D == DialogResult.OK)
            {
                Start();
                int Max = ImageIndexMax(InfoIndex, ImageIndex);

                while (ImageIndex <= Max)
                {
                    if (ImageIndex + 1 >= 10)
                    {
                        Set.Tables[0].Rows[InfoIndex][ImageIndex] = null;
                        break;
                    }
                    else
                    {
                        Set.Tables[0].Rows[InfoIndex][ImageIndex] =
                            Set.Tables[0].Rows[InfoIndex][ImageIndex + 1];
                    }
                    ImageIndex++;

                }
                End();

                Heart.Read(InfoIndex, ImageIndex = 5, This);
                MessageBox.Show("删除成功", "Delete", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region 保存图片
        static Stream S;
        static public void SaveImageToSQL()
        {
            Start();
            byte[] pictype;
            pictype = new byte[S.Length];
            S.Position = 0;
            S.Read(pictype, 0, Convert.ToInt32(S.Length));
            SqlConnection Con =
            new SqlConnection("server=.;database=StudentPlus;integrated security=true");
            Con.Open();
            SqlCommand Com = new SqlCommand("select * from Information", Con);
            SqlDataReader dr = Com.ExecuteReader();
            int Now = -1;
            string NowField = "";
            while (dr.Read() && NowField == "")
            {
                if (++Now == INFO)//找到当前行
                {
                    for (int i = 0; i < dr.FieldCount; ++i)
                    {
                        //最后一个图片之后的字段肯定为null
                        if (dr.GetValue(i) == System.DBNull.Value)
                        {
                            NowField = dr.GetName(i);
                            break;
                        }
                    }
                }
            }
            dr.Close();
            Com.Dispose();
            Con.Close();
            Set.Tables[0].Rows[INFO][NowField] = pictype;
            MessageBox.Show("增加成功", "Insert", MessageBoxButtons.OK);
            End();
            Read(INFO, ImageIndexMax(INFO, 5), ReadForm);
        }
        #endregion

        #region 增加图片入口
        static Form Model;
        static RadioButton FileImage, PickImage;
        static int INFO, IMAGE;
        static ReadInfoForm ReadForm;
        static ManageInfoForm ManageForm;
        static public void InsertImage(int InfoIndex,int ImageIndex,ReadInfoForm This)
        {
            bool F = false;
            int LastIndex = ImageIndexMax(InfoIndex,ImageIndex)+1;
            if (LastIndex+1 > Set.Tables[0].Columns.Count-1)
            {
                MessageBox.Show(Set.Tables[0].Rows[InfoIndex]["Name"].ToString() +
                    "的照片存储空间已满，请删除其他照片后再添加！");F = true;
            }
            INFO = InfoIndex;
            IMAGE = ImageIndex;
            ReadForm = This;
            if (F) { ExitReadFormPick(); return; }
            InsertImageForm(true,new ManageInfoForm());
        }
        #endregion

        #region 图片增加窗口
        static public void InsertImageForm(bool Key,ManageInfoForm This)
        {
            Model = new Form();
            Model.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Model.Size = new Size(180, 100);
            GroupBox GB = new GroupBox();
            GB.Size = Model.Size;
            FileImage = new RadioButton();
            FileImage.Text = "文件中选择";
            PickImage = new RadioButton();
            PickImage.Location = new Point(0, 30);
            PickImage.Text = "开启摄像头";
            PickImage.Checked = true;
            Model.Controls.Add(GB);
            GB.Controls.Add(FileImage);
            GB.Controls.Add(PickImage);
            if (Key)
            {
                Button Ok = new Button();
                Ok.Location = new Point(10, 60);
                Ok.Text = "确定";
                Ok.FlatStyle = FlatStyle.Popup;
                Ok.Click += Ok_Click;
                Button Cannel = new Button();
                Cannel.Location = new Point(90, 60);
                Cannel.Text = "取消";
                Cannel.FlatStyle = FlatStyle.Popup;
                Cannel.Click += Cannel_Click;
                GB.Controls.Add(Cannel);
                GB.Controls.Add(Ok);
            }
            else
            {
                ManageForm = This;
                Button Yes = new Button();
                Yes.Location = new Point(10, 60);
                Yes.Text = "确定";
                Yes.FlatStyle = FlatStyle.Popup;
                Yes.Click += Yes_Click;
                Button No = new Button();
                No.Location = new Point(90, 60);
                No.Text = "取消";
                No.FlatStyle = FlatStyle.Popup;
                No.Click += No_Click;
                GB.Controls.Add(No);
                GB.Controls.Add(Yes);
            }
            Model.Opacity = 0.8;
            Model.FormBorderStyle = FormBorderStyle.None;
            Model.Cursor = Cursors.Hand;
            Model.TopMost = true;
            Model.Activate();
            Model.ShowDialog();
        }
        #endregion

        #region 文件增加图片
        static public void FileImageInsert(bool Key)
        {
            if (Key)
            {
                ExitReadFormPick();
            }
            else
            {
                ExitManageFormPick();
            }
            OpenFileDialog A = new OpenFileDialog();
            A.Filter = "*.jpg|*.jpg|*.bmp|*.bmp|*.png|*.png";
            if (A.ShowDialog() == DialogResult.OK)
            {
                if (A.FileName != "")
                {
                    S = A.OpenFile();
                    if (Key)
                    {
                        SaveImageToSQL();
                    }
                    else
                    {
                        ManageForm.pictureBox1.Image = Image.FromStream(S);
                    }
                }
            }
        }
        #endregion

        #region 摄像增加图片
        static Pick pick;
        static public void PickImageInsert(bool Key)
        {
            if (Key)
            {
                ReadForm.button10.Visible = ReadForm.button11.Visible = ReadForm.pictureBox2.Visible = true;
                ReadForm.button10.Click += Button10_Click;
                ReadForm.button11.Click += Button11_Click;
                pick = new Pick(ReadForm.pictureBox2.Handle, 0, 0, ReadForm.pictureBox2.Width, ReadForm.pictureBox2.Height);
            }
            else
            {
                ManageForm.button5.Visible = ManageForm.button8.Visible = ManageForm.pictureBox2.Visible = true;
                ManageForm.button5.Click += Button5_Click;
                ManageForm.button8.Click += Button8_Click;
                pick = new Pick(ManageForm.pictureBox2.Handle, 0, 0, ManageForm.pictureBox2.Width, ManageForm.pictureBox2.Height);
            }
            pick.Start();
        }
        #endregion

        #region 管理窗口开始照相
        private static void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ExitManageFormPick();
                pick.GrabImage(@"C:/MyPhoto.jpg");
                ManageForm.pictureBox1.Image = Image.FromFile(@"C:/MyPhoto.jpg");
            }
            catch { MessageBox.Show("摄像头启动失败", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region 管理窗口图片上传
        private static void Yes_Click(object sender, EventArgs e)
        {
            Model.Close();
            if (FileImage.Checked)
            {
                FileImageInsert(false);
            }
            else
            {
                PickImageInsert(false);
            }
        }
        #endregion

        #region 管理窗口退出上传
        private static void No_Click(object sender, EventArgs e)
        {
            Model.Close();
            ExitManageFormPick();
        }
        #endregion

        #region 管理窗口退出摄像
        private static void Button8_Click(object sender, EventArgs e)
        {
            ExitManageFormPick();
        }
        #endregion

        #region 管理窗口退出处理
        static public void ExitManageFormPick()
        {
            for (int i = 0; i < ManageForm.Controls.Count; ++i)
            {
                ManageForm.Controls[i].Enabled = true;
            }
            ManageForm.button5.Visible = ManageForm.button8.Visible = ManageForm.pictureBox2.Visible = false;
        }
        #endregion

        #region 预览窗口开始照相
        private static void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                ExitReadFormPick();
                pick.GrabImage(@"C:/MyPhoto.jpg");
                S = File.Open(@"C:/MyPhoto.jpg", FileMode.OpenOrCreate);
                SaveImageToSQL();
            }
            catch { MessageBox.Show("摄像头启动失败", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion                    

        #region 预览窗口图片上传
        private static void Ok_Click(object sender, EventArgs e)
        {
            Model.Close();
            if (FileImage.Checked)
            {
                FileImageInsert(true);
            }
            else
            {
                PickImageInsert(true);
            }

        }
        #endregion

        #region 预览窗口退出上传
        private static void Cannel_Click(object sender, EventArgs e)
        {
            Model.Close();
            ExitReadFormPick();
        }
        #endregion

        #region 预览窗口退出摄像
        private static void Button11_Click(object sender, EventArgs e)
        {
            ExitReadFormPick();
            Read(INFO, IMAGE, ReadForm);
        }
        #endregion

        #region 预览窗口退出处理
        static public void ExitReadFormPick()
        {
            ReadForm.button10.Visible = ReadForm.button11.Visible = ReadForm.pictureBox2.Visible = false;
            ReadForm.button1.Enabled = ReadForm.button2.Enabled = ReadForm.button3.Enabled = ReadForm.button4.Enabled = ReadForm.button5.Enabled = ReadForm.button6.Enabled = ReadForm.button8.Enabled = ReadForm.button9.Enabled = ReadForm.button7.Enabled = true;
        }
        #endregion
                             
        #region 图片转化字节数组
        static public Byte[] ChangeByte(Image P)
        {
            byte[] buffer = null;
            ImageFormat format = P.RawFormat;
            MemoryStream ms = new MemoryStream();
            if (format.Equals(ImageFormat.Png))
            {
                P.Save(ms, ImageFormat.Png);
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                P.Save(ms, ImageFormat.Bmp);
            }
            else if (format.Equals(ImageFormat.Jpeg))
            {
                P.Save(ms, ImageFormat.Jpeg);
            }
            buffer = new byte[ms.Length];
            ms.Seek(0, SeekOrigin.Begin);
            ms.Read(buffer, 0, buffer.Length);
            ms = new MemoryStream();
            byte[] auffer = null;
            Image A = Image.FromFile("Image/NoPicture.jpg");
            A.Save(ms, ImageFormat.Jpeg);
            auffer = new byte[ms.Length];
            ms.Seek(0, SeekOrigin.Begin);
            ms.Read(auffer, 0, auffer.Length);
            ms.Dispose();
            if (auffer.Length != buffer.Length)
            {
                return buffer;
            }
            else
            {
                int i = 0;
                while (i < auffer.Length)
                {
                    if (auffer[i] != buffer[i])
                    {
                        return buffer;
                    }
                    ++i;
                }
            }
            return null;
        }
        #endregion

        #region 获取图片
        static public Image GetImage(byte[] Image_Bytes)
        {
            return new Bitmap(new MemoryStream(Image_Bytes));
        }
        #endregion

        #region 获取数据
        static public DataSet GetDataSource()
        {
            Start();
            return Set;
        }
        #endregion

        #region 跳出菜单窗口
        static public void ShowMF(Form This)
        {
            Thread B = new Thread((ThreadStart)delegate { Application.Run(new MainForm()); });
            B.SetApartmentState(ApartmentState.STA);
           
            B.Start();
        }
        #endregion

        #region 最小化提示窗
        static public void Form_SizeChanged(Form This)
        {
            if (This.WindowState == FormWindowState.Minimized)
            {
                Form MinTip = new Form();//实例窗体对象
                MinTip.Size = new Size(230, 200);//调整大小
                Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - MinTip.Width,
                    Screen.PrimaryScreen.WorkingArea.Height - MinTip.Height);//找到右下角坐标
                MinTip.PointToScreen(p);//将工作地区位置计算成屏幕坐标
                MinTip.Location = p;//设置坐标
                MinTip.Text = "Look me!";
                MinTip.BackgroundImage = Image.FromFile("Image/TipPic.jpg");//加载已经制作好的图片
                MinTip.BackgroundImageLayout = ImageLayout.Zoom;//设置图片格式
                MinTip.FormBorderStyle = FormBorderStyle.None;//设置窗体风格
                MinTip.Show();
                while (MinTip.Opacity > 0.1)//本来用移动窗体方法，一直移动到最下面，即可消失提示窗口
                //但每次移动，图片都会重新加载闪烁，所以改成透明度递减
                {
                    MinTip.Opacity -= 0.03;
                    Thread.Sleep(123);//设置间隔，主线程睡眠间隔
                }
                MinTip.Close();
            }
        }
        #endregion

        #region 调整窗体状态
        static public void ChangeSize(Form This)
        {
            if (This.WindowState == FormWindowState.Minimized)
            {
                This.WindowState = FormWindowState.Normal;
            }
        }
        #endregion

        #region 退出窗体
        static public void FormExit(EventArgs e,Form This,System.Windows.Forms.NotifyIcon N) 
        {
            try
            {
                This.TopMost = false;
                DialogResult D = MessageBox.Show("您确定要退出吗？", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (D == DialogResult.Cancel)
                {
                    This.TopMost = true;
                   (e as FormClosingEventArgs).Cancel = true; 
                }
                else { N.Dispose();Environment.Exit(0); }
            }
            catch { MessageBox.Show("Bye-Bye."); }
        }
        #endregion

        #region 放大图片
        Form ThePic;
         public void BigImage(PictureBox Q)
        {
            ThePic = new Form();
            ThePic.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ThePic.Size = new Size(1000, 705);
            PictureBox P = new PictureBox();
            P.Image = Q.Image;
            P.Size = ThePic.Size;
            ThePic.FormBorderStyle = FormBorderStyle.None;
            ThePic.Controls.Add(P);
            ThePic.Opacity = 0.8;
            P.Click += P_Click;
            ThePic.TopMost = true;
            ThePic.Show();
        }
        #endregion

        #region 退出放大
         void P_Click(object sender, EventArgs e)
        {
            ThePic.Close();
        }
        #endregion

        #region 错误提示
        static int X = 10;
        static int Y = 10;
        static public void ShowError(MainForm This)
        {
            for(int i = 0; i < This.Controls.Count; ++i)
            {
                This.Controls[i].Enabled = false;
            }
            This.ForMF.Dispose();
            This.ReadInfo.Text = "请";
            This.ManageInfo.Text = "检";
            This.SearchInfo.Text = "查";
            This.Explanation.Text = "连";
            This.Anthor.Text = "接";
            This.timer1.Enabled = true;
            This.label1.Enabled = true;
            This.label1.Visible = true;
        }
        #endregion

        #region 启动程序
        [STAThread]
         static void Main()
         {
             Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new MainForm());
         }
        #endregion
    }
}
