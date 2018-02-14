using System;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class Login
    {
        static public void FormExit()
        {
            MessageBox.Show("请取回您的卡！");
            Environment.Exit(0);
        }
        static public bool ExistCardID(string CardID)
        {
            return DAL.Users.IsExistCardID(CardID) ? true : false;
        }
        static public bool ExistUserID(string CardID)
        {
            return DAL.Users.IsExistUserID(CardID) ? true : false;
        }
        static public bool ExitstAccountPWS(string CardID, string PWS)
        {
            return DAL.Users.IsExistPWS(CardID, PWS) ? true : false;
        }
        static public bool GetAccountFrozen(string CardID)
        {
            return DAL.Users.GetFrozen(CardID);
        }
        static public void ChangeAccountFrozen(string CardID,bool Status)
        {
            DAL.Users.ChangeFrozen(CardID, Status);
        }
        static void Main(string[] args)
        {
        }
    }
}
