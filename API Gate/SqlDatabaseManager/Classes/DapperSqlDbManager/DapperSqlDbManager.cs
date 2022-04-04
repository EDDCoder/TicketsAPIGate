using EngineContracts.Logging;
using Microsoft.Extensions.Configuration;
using Npgsql;
using SqlDatabaseManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDatabaseManager.Classes
{
    public partial class DapperSqlDbManager : ISqlDbManager
    {
        private readonly IConfiguration _configuration;

        public DapperSqlDbManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public async Task<ResultInfo> AddSettingsAsync(IEnumerable<(string key, string value)> settings)
        //{
        //    using (var connection = new NpgsqlConnection("User ID=root;Password=myPassword;Host=localhost;Port=5432;Database=myDataBase;"))
        //    {

        //    }
        //    null;
        //}

    }
}
