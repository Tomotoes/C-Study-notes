using System;
using System.Windows.Forms;

namespace BLL
{
    public class ChangePWS
    {
        static public void SaveNewPWS(string CardID,string NewPWS)
        {
            DAL.Users.SaveNewPWS(CardID, NewPWS);
            MessageBox.Show("更改密码成功！", "Change", MessageBoxButtons.OK);
        }
    }
}
