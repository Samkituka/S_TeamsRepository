using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class FilesTable
    {
        public int FilesId { get; set; }
        public string Myfiles { get; set; }
        public string Customerfiles { get; set; }
    }
}
