using EngineContracts.Logging;
using System.Collections.Concurrent;

namespace CoreEngine.Classes
{
    public partial interface ISettings
    {
        public Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings);


        public Task<(ConcurrentDictionary<string, string>, ResultInfo)> GetSettings();
    }
}
