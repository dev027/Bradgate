using Bradgate.SeventyClub.Domain;

namespace Bradgate.UI.ViewModels.SeventyPercentClub.Index
{
    public class SeventyPercentClubViewModel
    {
        public VmHolders VmHolders { get; }
        public VmEntries VmEntries { get; }

        public SeventyPercentClubViewModel(
            SeventyPercentClubEntry holders,
            SeventyClub.Domain.SeventyPercentClub seventyPercentClub)
        {
            VmHolders = new VmHolders(holders);
            VmEntries = new VmEntries(seventyPercentClub);
        }
    }
}