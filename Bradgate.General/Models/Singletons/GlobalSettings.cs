namespace Bradgate.General.Models.Singletons
{
    public class GlobalSettings
    {
        public GlobalSettings(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
    }
}