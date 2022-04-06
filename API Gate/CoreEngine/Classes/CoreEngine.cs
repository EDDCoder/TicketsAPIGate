using CoreEngine.Interfaces;
using EngineContracts.Logging;
using SqlDatabaseManager.Interfaces;

namespace CoreEngine.Classes
{
    public partial class SearchEngine : ICoreEngine
    {
        private readonly ISqlDbManager _sqlDbManager;

        public SearchEngine(ISqlDbManager sqlDbManager)
        {
            _sqlDbManager = sqlDbManager;
        }

        public async Task<ResultInfo> AddSettings(IEnumerable<(string key, string value)> settings)
        {
            await _sqlDbManager.AddSettingsAsync(settings.Select(setting => new KeyValuePair<string, string>(setting.key,setting.value)));

            return null;
        }

        public async Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings)
        {
            await _sqlDbManager.AddSettingsAsync(settings.Select(setting => new KeyValuePair<string, string>(setting.key, setting.value)));

            return null;
        }

        public Task<ResultInfo> AddTicket()
        {
            Console.WriteLine();

            _sqlDbManager.AddTicket();

            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddTicketAsync()
        {
            throw new NotImplementedException();
        }
    }
}
