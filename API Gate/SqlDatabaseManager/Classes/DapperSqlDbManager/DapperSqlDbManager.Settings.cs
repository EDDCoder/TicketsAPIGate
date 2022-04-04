using EngineContracts.Logging;
using SqlDatabaseManager.Interfaces;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace SqlDatabaseManager.Classes
{
    public partial class DapperSqlDbManager : ISqlDbManager
    {
        public async Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings)
        {
            var kek = _configuration.GetConnectionString("BloggingDatabase");
            return null;
        }
    }
}
