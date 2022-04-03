using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class Content
    {
        public long Id { get; set; }
        public string? Content1 { get; set; }
        public DateOnly? Updatedate { get; set; }
        public DateOnly? Createdate { get; set; }
    }
}
