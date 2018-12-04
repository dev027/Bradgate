using System;

namespace Bradgate.SeventyClub.Domain
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

        /// <summary>
        /// Seventy Percent Club Entry Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of achievement
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Player 1 name
        /// </summary>
        public string Player1 { get; set; }

        /// <summary>
        /// True if Player 1 is a visitor
        /// </summary>
        public bool IsPlayer1Visitor { get; set; }

        /// <summary>
        /// Player 2 name
        /// </summary>
        public string Player2 { get; set; }

        /// <summary>
        /// True if Player 2 is a visitor
        /// </summary>
        public bool IsPlayer2Visitor { get; set; }

        /// <summary>
        /// Score (percentage)
        /// </summary>
        public decimal Score { get; set; }

        /// <summary>
        /// Session description
        /// </summary>
        public string SessionDescription { get; set; }
    }
}