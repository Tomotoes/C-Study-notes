using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class Users
    {
        #region 定义数据库成员
        static SqlDataAdapter Ada;
        static SqlCommandBuilder CB;
        static public DataSet Set;
        static public SqlCommand Com;
        static public SqlConnection Con;
        #endregion

        #region 实例数据库对象
        static public void Start()
        {
            Ada = new SqlDataAdapter("select * from tb_Users", "server=.;database=db_ATM;integrated security=true");
            Ada.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            CB = new SqlCommandBuilder(Ada);
            Set = new DataSet();
            Ada.Fill(Set);
        }
        #endregion

        #region 释放数据库对象
        static public void End(bool Key)
        {
            if (Key)
            {
                Ada.Update(Set);
                Ada.Dispose();
                CB.Dispose();
                Set.Dispose();
            }
            else
            {
                Con.Dispose();
                Com.Dispose();
            }
        }
        #endregion

        #region 判断存在账号
        static public bool IsExistCardID(string AccountID)
        {
            Con = new SqlConnection("server=.;database=db_ATM;integrated security=true");
            Con.Open();
            Com = new SqlCommand("select CardID from tb_Users where CardID='" + AccountID + "'", Con);
            if (Com.ExecuteReader().HasRows)
            {
                End(false);
                return true;
            }
            else
            {
                End(false);
                return false;
            }
        }
        #endregion

        #region 判断存在身份证号
        static public bool IsExistUserID(string UserID)
        {
            Con = new SqlConnection("server=.;database=db_ATM;integrated security=true");
            Con.Open();
            Com = new SqlCommand("select CardID from tb_Users where UserID='" + UserID + "'", Con);
            if (Com.ExecuteReader().HasRows)
            {
                End(false);
                return true;
            }
            else
            {
                End(false);
                return false;
            }
        }
        #endregion

        #region 判断存在密码
        static public bool IsExistPWS(string CardID,string Password)
        {
            Con = new SqlConnection("server=.;database=db_ATM;integrated security=true");
            Con.Open();
            Com = new SqlCommand("select CardID from tb_Users where Password='" + Password + "'and CardID='" + CardID + "'", Con);
            if (Com.ExecuteReader().HasRows)
            {
                End(false);
                return true;
            }
            else
            {
                End(false);
                return false;
            }
        }
        #endregion

        #region 保存账号信息
        static public bool SaveNewUser(Model.Users User)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(User.CardID);
            if (Res != null)
            {
                MessageBox.Show("该卡号已经存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DataRow Ac = Set.Tables[0].NewRow();
            Ac["CardID"] = User.CardID;
            Ac["UserID"] = User.UserID;
            Ac["UserName"] = User.UserName;
            Ac["Password"] = User.Password;
            Ac["StartTime"] = User.StartTime;
            Ac["Balance"] = User.Balance;
            Ac["Frozen"] = User.Frozen;
            Ac["Content"] = User.Content;
            Ac["Question"] = User.Question;
            Ac["Answer"] = User.Answer;
            Set.Tables[0].Rows.Add(Ac);
            End(true);
            return true;
        }
        #endregion

        #region 获取密保问题
        static public string GetQuestion(string CardID)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            return Res["Question"].ToString();
        }
        #endregion

        #region 获取密保答案
        static public string GetAnswer(string CardID)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            return Res["Answer"].ToString();
        }
        #endregion

        #region 获取冻结状态
        static public bool GetFrozen(string CardID)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            return Convert.ToBoolean(Res["Frozen"]);
        }
        #endregion

        #region 获取用户余额
        static public float GetUserMoney(string CardID)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            return Convert.ToSingle(Res["Balance"]);
        }
        #endregion

        #region 更改冻结状态
        static public void ChangeFrozen(string CardID,bool Status)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            Res["Frozen"] = Status;
            End(true);
        }
        #endregion

        #region 更改用户密码
        static public void SaveNewPWS(string CardID,string NewPWS)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            Res["Password"] = NewPWS;
            End(true);
        }
        #endregion

        #region 更改用户余额
        static public void ChangeUserMoney(string CardID,float DoMoney,bool AddOrReduce)
        {
            Start();
            DataRow Res = Set.Tables[0].Rows.Find(CardID);
            float OldMoney = Convert.ToSingle(Res["Balance"]);
            if (AddOrReduce)
            {
                OldMoney += DoMoney;
            }
            else
            {
                OldMoney -= DoMoney;
            }
            Res["Balance"] = OldMoney.ToString();
            End(true);
        }
        #endregion

        static void Main(string[] args)
        {

        }
    }
}
