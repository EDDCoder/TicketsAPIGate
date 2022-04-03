using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Region
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int? Country { get; set; }
        public bool? Deleted { get; set; }
        public DateOnly? Updatedate { get; set; }
        public DateOnly? Createdate { get; set; }
    }
}
