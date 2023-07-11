using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;

namespace Flc.Functions.Adapters
{
    public class DataContext
    {
        private DbSettings _dbSettings;

        public DataContext(IOptions<DbSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = $"Host={_dbSettings.Server}; Database={_dbSettings.Database}; Username={_dbSettings.UserId}; Password={_dbSettings.Password}; Port={_dbSettings.Port};";
            return new NpgsqlConnection(connectionString);
        }
    }
}
