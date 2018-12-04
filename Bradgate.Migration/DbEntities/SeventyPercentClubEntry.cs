using System;

namespace Bradgate.Migration.DbEntities
{
    public class SeventyPercentClubEntry
    {
        public SeventyPercentClubEntry(
            DateTime date,
            string player1,
            bool isPlayer1Visitor,
            string player2,
            bool isPlayer2Visitor,
            decimal score,
            string sessionDescription,
            int id = 0)
        {
            Id = id;
            Date = date;
            Player1 = player1;
            IsPlayer1Visitor = isPlayer1Visitor;
            Player2 = player2;
            IsPlayer2Visitor = isPlayer2Visitor;
            Score = score;
            SessionDescription = sessionDescription;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Player1 { get; set; }
        public bool IsPlayer1Visitor { get; set; }
        public string Player2 { get; set; }
        public bool IsPlayer2Visitor { get; set; }
        public decimal Score { get; set; }
        public string SessionDescription { get; set; }
    }
}