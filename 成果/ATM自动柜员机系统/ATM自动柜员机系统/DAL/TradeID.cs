using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class TradeID
    {
        #region 定义数据库成员
        static public SqlCommand Com;
        static public SqlConnection Con;
        #endregion

        #region 释放数据库对象
        static public void End()
        {
            Com.Dispose();
            Con.Dispose();
        }
        #endregion

        /// <summary>
        /// 查找重复流水号
        /// </summary>
        static public bool IsExistTradeID(int TradeID)
        {
            Con = new SqlConnection("server=.;database=db_ATM;integrated security=true");
            Con.Open();
            Com = new SqlCommand("select TradeID from tb_TradeID where TradeID='" + TradeID + "'", Con);
            if (Com.ExecuteReader().HasRows)
            {
                End();
                return true;
            }
            else
            {
                End();
                return false;
            }
        }

        static public void AddNewTradeID(int TradeID)
        {
            Con = new SqlConnection("server=.;database=db_ATM;integrated security=true");
            Con.Open();
            Com = new SqlCommand("insert into tb_TradeID (TradeID) values (" + TradeID + ")", Con);
            Com.ExecuteNonQuery();
            End();
        }
        

    }
}
