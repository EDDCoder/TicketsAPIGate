using EngineContracts.Logging;
using SqlDatabaseManager.Interfaces;
using System.Collections.Concurrent;

namespace CoreEngine.Classes
{
    public partial class Settings : ISettings
    {
        private readonly ISqlDbManager _sqlDbManager;

        public Settings(ISqlDbManager sqlDbManager)
        {
            _sqlDbManager = sqlDbManager;
        }

        public async Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings)
        {
            Console.WriteLine();

            return new ResultInfo("AddSettingsAsync", "All good", null, true);
        }

        public Task<(ConcurrentDictionary<string, string>, ResultInfo)> GetSettings()
        {
            throw new NotImplementedException();
        }
    }
}
