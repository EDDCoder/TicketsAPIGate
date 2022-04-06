using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Geolink
    {
        public long? Id { get; set; }
        public string? Geolink1 { get; set; }
        public DateOnly? Updatedate { get; set; }
        public DateOnly? Createdata { get; set; }
    }
}
