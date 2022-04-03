using EngineContracts.Logging;

namespace CoreEngine.Interfaces
{
    public partial interface ICoreEngine
    {
        public Task<ResultInfo> AddTicket();
    }
}
