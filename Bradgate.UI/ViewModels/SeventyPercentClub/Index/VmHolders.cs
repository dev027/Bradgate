using System;
using Bradgate.SeventyClub.Domain;

namespace Bradgate.UI.ViewModels.SeventyPercentClub.Index
{
    public class VmHolders
    {
        public string Player1 { get; }
        public string Player2 { get; }
        public DateTime HeldSince { get; }
        public decimal Score { get; }

        public VmHolders(SeventyPercentClubEntry holders)
        {
            Player1 = holders.Player1;
            Player2 = holders.Player2;
            HeldSince = holders.Date;
            Score = holders.Score;
        }
    }
}