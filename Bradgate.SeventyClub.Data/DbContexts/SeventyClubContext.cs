using Bradgate.SeventyClub.Data.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Bradgate.SeventyClub.Data.DbContexts
{
    public class SeventyClubContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            const string connectionString = "data source=WRIGHT1\\SQLEXPRESS01;" +
                                            "initial catalog=Bradgate;" +
                                            "Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<SeventyPercentClubEntryDto> SeventyPercentClubEntries { get; set; }
    }
}