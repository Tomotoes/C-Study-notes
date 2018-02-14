using System;
using System.Data;

namespace BLL
{
    public class SelectData
    {
        static public DataSet GetSaveInfo()
        {
            return DAL.Save.GetDataSet();
        }
        static public DataSet GetDrawInfo()
        {
            return DAL.Draw.GetDataSet();
        }
        static public DataSet GetTransferInfo()
        {
            return DAL.Transfer.GetDataSet();
        }
    }
}
