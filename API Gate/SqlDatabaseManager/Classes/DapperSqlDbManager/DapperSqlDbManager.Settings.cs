using EngineContracts.Logging;
using SqlDatabaseManager.Interfaces;
using Npgsql;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace SqlDatabaseManager.Classes
{
    public partial class DapperSqlDbManager : ISqlDbManager
    {
        public async Task<ResultInfo> AddSettingsAsync(IEnumerable<KeyValuePair<string,string>> settings)
        {
            try
            {
                using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("SettingsDb")))
                {
                    await connection.ExecuteAsync("INSERT INTO search_engine_settings (key, value) VALUES (@key,@value)", settings);
                }

                return new ResultInfo(nameof(AddSettingsAsync));
            }
            catch (Exception ex)
            {
                return new ResultInfo(nameof(AddSettingsAsync), "Failed while add setting to db", ex, false);
            }
        }
    }
}
