﻿using EngineContracts.Logging;
using SqlDatabaseManager.Interfaces;

namespace SqlDatabaseManager.Classes
{
    public partial class DapperSqlDbManager : ISqlDbManager
    {
        public Task<ResultInfo> AddAuthor()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddAuthorContacts()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddAuthors()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddContactInfo()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddCountries()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddCountry()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddGeolink()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddGeolinks()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddManyAuthorContacts()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddManyContactInfo()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddRegion()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddRegions()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddTag()
        {
            throw new NotImplementedException();
        }

        public Task<ResultInfo> AddTags()
        {
            throw new NotImplementedException();
        }

        public async Task<ResultInfo> AddTicket()
        {
            Console.WriteLine("123");

            

            return new ResultInfo("","",null,true); 
        }

        public Task<ResultInfo> AddTickets()
        {
            throw new NotImplementedException();
        }
    }
}
