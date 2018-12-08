using System.Collections.Generic;

namespace Bradgate.SeventyClub.Domain
{
    public class SeventyPercentClub
    {
        public SeventyPercentClub(IReadOnlyList<SeventyPercentClubEntry> entries)
        {
            Entries = entries;
        }
        public IReadOnlyList<SeventyPercentClubEntry> Entries { get; }
    }
}