using System;

namespace Model
{
    public class Users
    {
        static public string CID;
        private string cardID;
        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }
        private string userID;
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private DateTime starttime;
        public DateTime StartTime
        {
            get { return starttime; }
            set { starttime = value; }
        }
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private bool frozen;
        public bool Frozen
        {
            get { return frozen; }
            set { frozen = value; }
        }
        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string question;
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        private string answer;
        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        public Users(string cardID, string userID, string username, string password, DateTime startname, float balance, bool forzen, string content, string question, string answer)
        {
            this.cardID = cardID;
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.starttime = startname;
            this.balance = balance;
            this.frozen = forzen;
            this.content = content;
            this.question = question;
            this.answer = answer;
        }
    }
}
