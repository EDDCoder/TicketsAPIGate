using CoreEngine.Interfaces;
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

        public Task<ResultInfo> AddSettings()
        {
            _sqlDbManager.AddTicket();

            throw new NotImplementedException();
        }

        public Task<(ConcurrentDictionary<string, string>, ResultInfo)> GetSettings()
        {
            throw new NotImplementedException();
        }
    }
}
