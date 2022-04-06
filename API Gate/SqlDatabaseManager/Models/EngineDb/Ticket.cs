using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Ticket
    {
        public long? Offerid { get; set; } = null!;
        public bool? Verified { get; set; }
        public long? Region { get; set; }
        public bool? Deleted { get; set; }
        public long? Author { get; set; }
        public long? Tags { get; set; }
        public DateOnly? Createdate { get; set; }
        public DateOnly? Updatedate { get; set; }
        public long? Content { get; set; }
        public long? Geolink { get; set; }
    }
}
