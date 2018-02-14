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

namespace 学生信息管理系统
{
    class Heart
    {
        #region 定义数据库成员
        static SqlDataAdapter Ada;
        static SqlCommandBuilder CB;
        static DataSet Set;
        #endregion
        #region 实例数据库对象
        static public void Start()
        {
            try
            {
                Ada = new SqlDataAdapter("select * from Information", "server=.;database=StudentPlus;integrated security=true");
                Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                CB = new SqlCommandBuilder(Ada);
                Set = new DataSet();
                Ada.Fill(Set);
            }
            catch { MessageBox.Show("数据库连接失败！请检查您的数据库！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); System.Environment.Exit(0); }
           
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
            if (Ac == null)
            {
                MessageBox.Show("该学号不存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
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
            try { Con.Open(); }
            catch { MessageBox.Show("数据库连接失败！请检查您的数据库！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); System.Environment.Exit(0); }
            SqlCommand Com = new SqlCommand(SelectText, Con);
            SqlDataReader Reader=null;
            Reader = Com.ExecuteReader();

            This.tabControl1.SelectedIndex = 1;
            This.dataGridView2.Rows.Clear();
            try
            {
                while (Reader.Read())
                {
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
            }
            catch(Exception e) { MessageBox.Show(e.Message); }
            if (This.dataGridView2.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("没有查到相关数据！", "Result", MessageBoxButtons.OK);
            }
            Con.Dispose();
            Com.Dispose();
            Reader.Close();
        }
        #endregion
        #region 更改信息数据索引
        static public void ChangeInfoIndex(int Key,ref int InfoIndex,ref int ImageIndex,ReadInfoForm This)
        {
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
        #region 获取信息中照片个数
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
        #region 增加图片
        static public bool InsertImage(int InfoIndex,int ImageIndex,ReadInfoForm This)
        {
            Start();
            int LastIndex = ImageIndexMax(InfoIndex,ImageIndex)+1;
            if (LastIndex+1 > Set.Tables[0].Columns.Count-1)
            {
                MessageBox.Show(Set.Tables[0].Rows[InfoIndex]["Name"].ToString() +
                    "的照片存储空间已满，请删除其他照片后再添加！");
                return false;
            }
            else
            {
                byte[] pictype;
                Stream S=null;
                OpenFileDialog A = new OpenFileDialog();
                A.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
                if (A.ShowDialog() == DialogResult.OK)
                {
                    if (A.FileName != "")
                    {
                        S = A.OpenFile();
                        //把图片转为字节数组
                        pictype = new byte[S.Length];
                        S.Position = 0;
                        S.Read(pictype, 0, Convert.ToInt32(S.Length));

                        //找到最后一个null字段，然后把图片赋给它
                        SqlConnection Con =
                        new SqlConnection("server=.;database=StudentPlus;integrated security=true");
                        Con.Open();
                        SqlCommand Com = new SqlCommand("select * from Information", Con);
                        SqlDataReader dr = Com.ExecuteReader();
                        int Now = -1;
                        string NowField = "";
                        while (dr.Read() && NowField == "")
                        {
                            if (++Now == InfoIndex)//找到当前行
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

                        Set.Tables[0].Rows[InfoIndex][NowField] = pictype;
                        MessageBox.Show("增加成功", "Insert", MessageBoxButtons.OK);
                        End();
                        Read(InfoIndex, ImageIndexMax(InfoIndex, 5), This);
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
        }
        #endregion
        #region 获取图片
        static public Image GetImage(byte[] Image_Bytes)
        {
            return new Bitmap(new MemoryStream(Image_Bytes));
        }
        #endregion
        #region 获取数据源
        static public DataSet GetDataSource()
        {
            Start();
            return Set;
        }
        #endregion
        #region 跳出菜单窗口
        static public void ShowMF()
        {
            new MainForm().Show();
        }
        #endregion
        #region 窗体最小化提示窗口
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
                else { N.Dispose();Environment.Exit(0);  MessageBox.Show("Bye-Bye."); }
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
        #region 退出放大图片
         void P_Click(object sender, EventArgs e)
        {
            ThePic.Close();
        }
        #endregion
    }
}
