using System;

namespace BLL
{
    public class SaveMoney
    {
        static public void SaveNewData(Model.Save Save)
        {
            DAL.Save.SaveNewData(Save);
        }
    }
}
