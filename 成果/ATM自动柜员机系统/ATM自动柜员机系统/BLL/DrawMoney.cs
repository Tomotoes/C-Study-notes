using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DrawMoney
    {
        static public float GetUserMoney(string CardID)
        {
            return DAL.Users.GetUserMoney(CardID);
        }
        static public void ChangeUserMoney(string CardID,float DoMoney,bool AddOrReduce)
        {
            DAL.Users.ChangeUserMoney(CardID, DoMoney, AddOrReduce);
        }
        static public void SaveNewData(Model.Draw Draw)
        {
            DAL.Draw.SaveNewData(Draw);
        }
        
        #region 得到交易流水账号
        static int NewTradeID;
        static public void GetNewTradeID()
        {
            NewTradeID = new Random().Next(1000, 9999);
            if (TradeID.IsExistTradeID(NewTradeID))
            {
                GetNewTradeID();
            }
        }
        static public int GetTradeID()
        {
            GetNewTradeID();
            DAL.TradeID.AddNewTradeID(NewTradeID);
            return NewTradeID;
        }

        #endregion
    }
}
