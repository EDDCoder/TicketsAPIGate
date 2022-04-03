using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Country
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Deleted { get; set; }
        public DateOnly? Createdate { get; set; }
        public DateOnly? Updatedate { get; set; }
    }
}
