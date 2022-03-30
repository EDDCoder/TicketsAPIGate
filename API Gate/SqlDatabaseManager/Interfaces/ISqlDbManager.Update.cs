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
        public Task<ResultInfo> UpdateAuthor();
        public Task<ResultInfo> UpdateAuthors();
        public Task<ResultInfo> UpdateTag();
        public Task<ResultInfo> UpdateTags();
        public Task<ResultInfo> UpdateRegion();
        public Task<ResultInfo> UpdateRegions();
        public Task<ResultInfo> UpdateCountry();
        public Task<ResultInfo> UpdateCountries();
        public Task<ResultInfo> UpdateContactInfo();
        public Task<ResultInfo> UpdateManyContactInfo();
        public Task<ResultInfo> UpdateTicket();
        public Task<ResultInfo> UpdateTickets();
    }
}
