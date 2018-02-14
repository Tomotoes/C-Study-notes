using System;

namespace BLL
{
    public class BringMoney
    {
        static public void SaveNewData(Model.Transfer Transfer)
        {
            DAL.Transfer.SaveNewData(Transfer);
        }
    }
}
