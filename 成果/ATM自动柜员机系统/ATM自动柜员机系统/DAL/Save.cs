using System;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Save
    {
         #region 定义数据库成员
        static SqlDataAdapter Ada;
        static SqlCommandBuilder CB;
        static public DataSet Set;
        #endregion

        #region 实例数据库对象
        static public void Start()
        {
            Ada = new SqlDataAdapter("select * from tb_Save", "server=.;database=db_ATM;integrated security=true");
            Ada.MissingSchemaAction =MissingSchemaAction.AddWithKey;
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
        static public void SaveNewData(Model.Save Save)
        {
            Start();
            DataRow Ac = Set.Tables[0].NewRow();
            Ac["TradeID"] = Save.TradeID;
            Ac["CardID"] = Save.CardID;
            Ac["Cash"] = Save.Cash;
            Ac["Balance"] = Save.Balance;
            Ac["Time"] = Save.Time;
            Set.Tables[0].Rows.Add(Ac);
            End();
        }
        #endregion

        #region 得到数据源
        static public DataSet GetDataSet()
        {
            Ada = new SqlDataAdapter("select * from tb_Save  where CardID='" + Model.Users.CID + "'", "server=.;database=db_ATM;integrated security=true");
            Set = new DataSet();
            Ada.Fill(Set);
            return Set;
        }
        #endregion
    }
}
