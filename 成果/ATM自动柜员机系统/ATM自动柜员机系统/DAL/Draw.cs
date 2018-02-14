using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Draw
    {
        #region 定义数据库成员
        static SqlDataAdapter Ada;
        static SqlCommandBuilder CB;
        static public DataSet Set;
        #endregion

        #region 实例数据库对象
        static public void Start()
        {
            Ada = new SqlDataAdapter("select * from tb_Draw", "server=.;database=db_ATM;integrated security=true");
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

        #region 保存新纪录
        static public void SaveNewData(Model.Draw Draw)
        {
            Start();
            DataRow Ac = Set.Tables[0].NewRow();
            Ac["TradeID"] = Draw.TradeID;
            Ac["CardID"] = Draw.CardID;
            Ac["Cash"] = Draw.Cash;
            Ac["Balance"] = Draw.Balance;
            Ac["Time"] = Draw.Time;
            Set.Tables[0].Rows.Add(Ac);
            End();
        }
        #endregion

        #region 得到数据源
        static public DataSet GetDataSet()
        {
            Ada = new SqlDataAdapter("select * from tb_Draw  where CardID='"+Model.Users.CID+"'", "server=.;database=db_ATM;integrated security=true");
            Set = new DataSet();
            Ada.Fill(Set);
            return Set;
        }
        #endregion
    }
}
