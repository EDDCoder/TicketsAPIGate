using SqlDatabaseManager.Classes;

namespace SqlDatabaseManager.Interfaces
{
    public partial interface ISqlDbManager
    {
        public Task<ResultInfo> AddAuthor();
        public Task<ResultInfo> AddAuthors();

        public Task<ResultInfo> AddTag();
        public Task<ResultInfo> AddTags();

        public Task<ResultInfo> AddRegion();
        public Task<ResultInfo> AddRegions();

        public Task<ResultInfo> AddCountry();
        public Task<ResultInfo> AddCountries();

        public Task<ResultInfo> AddContactInfo();
        public Task<ResultInfo> AddManyContactInfo();

        public Task<ResultInfo> AddTicket();
        public Task<ResultInfo> AddTickets();

        public Task<ResultInfo> AddGeolink();
        public Task<ResultInfo> AddGeolinks();

        public Task<ResultInfo> AddAuthorContacts();
        public Task<ResultInfo> AddManyAuthorContacts();
    }
}
