using EngineContracts.Logging;
using System.Collections.Concurrent;

namespace CoreEngine.Classes
{
    public partial interface ISettings
    {
        public Task<ResultInfo> AddSettings();


        public Task<(ConcurrentDictionary<string, string>, ResultInfo)> GetSettings();
    }
}
