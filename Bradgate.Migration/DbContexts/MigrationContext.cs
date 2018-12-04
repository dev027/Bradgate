using Bradgate.Migration.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace Bradgate.Migration.DbContexts
{
    public class MigrationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            const string connectionString = "data source=WRIGHT1\\SQLEXPRESS01;" +
                                            "initial catalog=Bradgate;" +
                                            "Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<SeventyPercentClubEntry> SeventyPercentClubEntries { get; set; }
    }
}