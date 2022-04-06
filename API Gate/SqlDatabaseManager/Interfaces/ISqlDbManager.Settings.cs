using EngineContracts.Logging;

namespace SqlDatabaseManager.Interfaces
{
    public partial interface ISqlDbManager
    {
        public Task<ResultInfo> AddSettingsAsync(IEnumerable<KeyValuePair<string, string>> settings);
    }
}
