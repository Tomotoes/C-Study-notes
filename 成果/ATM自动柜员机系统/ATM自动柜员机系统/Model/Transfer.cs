using System;

namespace Model
{
    public class Transfer
    {
        private int tradeID;
        public int TradeID
        {
            get { return tradeID; }
            set { tradeID = value; }
        }
        private string sourcecardID;
        public string SourceCardID
        {
            get { return sourcecardID; }
            set { sourcecardID = value; }
        }
        private string targetcardID;
        public string TargetCardID
        {
            get { return targetcardID; }
            set { targetcardID = value; }
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
        public Transfer(int tradeID, string sourcecardID, string targetcardID, float cash, float balance, DateTime time, string content)
        {
            this.tradeID = tradeID;
            this.sourcecardID = sourcecardID;
            this.targetcardID = targetcardID;
            this.cash = cash;
            this.balance = balance;
            this.time = time;
            this.content = content;
        }
    }
}
