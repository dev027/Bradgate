using Bradgate.General.Extensions.DateTimeExtensions;
using Bradgate.SeventyClub.Domain;
using System;

namespace Bradgate.UI.ViewModels.SeventyPercentClub
{
    public class HoldersViewModel
    {
        private string Player1 { get; }
        private string Player2 { get; }
        private DateTime HeldSince { get; }
        private decimal Score { get; }

        public TitleDetails Title { get; }

        public class TitleDetails
        {
            public string Heading => "Pam Leeson Trophy";
            public string Score => "Score";
            public string HeldSince => "Held Since";
        }

        public TextDetails Text { get; }

        public class TextDetails
        {
            public TextDetails(string player1, string player2, DateTime heldSince, decimal score)
            {
                Holders = $"{player1} & {player2}";
                HeldSince = heldSince.ToDD_MMM_YYYY();
                Score = $"{score}%";
            }

            public string Holders { get; }
            public string HeldSince { get; }
            public string Score { get; }
        }

        public HoldersViewModel(SeventyPercentClubEntry holders)
        {
            Player1 = holders.Player1;
            Player2 = holders.Player2;
            HeldSince = holders.Date;
            Score = holders.Score;

            Title = new TitleDetails();
            Text = new TextDetails(Player1, Player2, HeldSince, Score);
        }
    }
}