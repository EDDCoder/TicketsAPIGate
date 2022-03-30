using SqlDatabaseManager.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDatabaseManager.Interfaces
{
    public partial interface ISqlDbManager
    {
        public Task<ResultInfo> GetAuthor();
        public Task<ResultInfo> GetAuthors();
        public Task<ResultInfo> GetTag();
        public Task<ResultInfo> GetTags();
        public Task<ResultInfo> GetRegion();
        public Task<ResultInfo> GetRegions();
        public Task<ResultInfo> GetCountry();
        public Task<ResultInfo> GetCountries();
        public Task<ResultInfo> GetContactInfo();
        public Task<ResultInfo> GetManyContactInfo();
        public Task<ResultInfo> GetTicket();
        public Task<ResultInfo> GetTickets();
    }
}
