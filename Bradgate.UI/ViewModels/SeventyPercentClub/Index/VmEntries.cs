using System.Collections.Generic;
using System.Linq;

namespace Bradgate.UI.ViewModels.SeventyPercentClub.Index
{
    public class VmEntries
    {
        public IReadOnlyList<VmEntry> Entries { get; }

        public VmEntries(SeventyClub.Domain.SeventyPercentClub seventyPercentClub)
        {
            Entries = seventyPercentClub.Entries
                .Select(entry => new VmEntry(
                    date: entry.Date,
                    player1: entry.Player1,
                    isPlayer1Visitor: entry.IsPlayer1Visitor,
                    player2: entry.Player2,
                    isPlayer2Visitor: entry.IsPlayer2Visitor,
                    score: entry.Score,
                    sessionDescription: entry.SessionDescription)).ToList();
        }
    }
}