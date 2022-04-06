using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Author
    {
        public long Id { get; set; }
        public string? Nickname { get; set; }
        public bool? Verified { get; set; }
        public bool? Deleted { get; set; }
        public DateOnly? Updatedate { get; set; }
        public DateOnly? Createdate { get; set; }
    }
}
