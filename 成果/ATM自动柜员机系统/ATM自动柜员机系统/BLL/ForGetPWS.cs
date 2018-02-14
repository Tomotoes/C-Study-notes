using System;

namespace BLL
{
    public class ForGetPWS
    {
        static public string GetQuestion(string CardID)
        {
            return DAL.Users.GetQuestion(CardID);
        }
        static public string GetAnswer(string CardID)
        {
            return DAL.Users.GetAnswer(CardID);
        }
    }
}
