using EngineContracts.Logging;

namespace SqlDatabaseManager.Interfaces
{
    public partial interface ISqlDbManager
    {
        public Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings);
    }
}
