using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Document
    {
        public int DocumentsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastDateUpdated { get; set; }
        public string Location { get; set; }
    }
}
