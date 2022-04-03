using System;
using System.Collections.Generic;

namespace SqlDatabaseManager.Models
{
    public partial class AuthorContact
    {
        public long Id { get; set; }
        public string? Email { get; set; }
        public string? Number { get; set; }
        public string? RealName { get; set; }
        public bool? Deleted { get; set; }
        public DateOnly? Updatedate { get; set; }
        public DateOnly? Createdate { get; set; }
    }
}
