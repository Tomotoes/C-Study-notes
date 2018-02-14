using System;

namespace Model
{
    public class Draw
    {

        private int tradeID;
        public int TradeID
        {
            get { return tradeID; }
            set { tradeID = value; }
        }
        private string cardID;
        public string CardID
        {
            get { return cardID; }
            set { cardID = value; }
        }
        private float cash;
        public float Cash
        {
            get { return cash; }
            set { cash = value; }
        }
        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public Draw(int tradeID, string cardID, float cash, DateTime time, string content,float balance)
        {
            this.tradeID = tradeID;
            this.cardID = cardID;
            this.cash = cash;
            this.time = time;
            this.content = content;
            this.balance = balance;
        }
        static void Main(string[] args)
        {
        }
    }
}


