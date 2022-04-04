﻿using EngineContracts.Logging;

namespace CoreEngine.Interfaces
{
    public partial interface ICoreEngine
    {
        public Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings);
        public Task<ResultInfo> AddTicketAsync();
    }
}
