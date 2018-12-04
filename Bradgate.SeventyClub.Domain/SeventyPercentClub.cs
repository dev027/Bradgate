using System.Collections.Generic;

namespace Bradgate.SeventyClub.Domain
{
    public class SeventyPercentClub
    {
        public SeventyPercentClub()
        {
            Entries = new List<SeventyPercentClubEntry>();
        }
        public IList<SeventyPercentClubEntry> Entries { get; }
    }
}