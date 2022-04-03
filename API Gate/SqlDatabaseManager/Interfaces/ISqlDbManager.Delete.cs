using EngineContracts.Logging;

namespace SqlDatabaseManager.Interfaces
{
    public partial interface ISqlDbManager
    {
        public Task<ResultInfo> DeleteAuthor();
        public Task<ResultInfo> DeleteAuthors();
        public Task<ResultInfo> DeleteTag();
        public Task<ResultInfo> DeleteTags();
        public Task<ResultInfo> DeleteRegion();
        public Task<ResultInfo> DeleteRegions();
        public Task<ResultInfo> DeleteCountry();
        public Task<ResultInfo> DeleteCountries();
        public Task<ResultInfo> DeleteContactInfo();
        public Task<ResultInfo> DeleteManyContactInfo();
        public Task<ResultInfo> DeleteTicket();
        public Task<ResultInfo> DeleteTickets();
    }
}
