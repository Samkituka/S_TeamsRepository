using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Library
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime Year { get; set; }
        public string HaveRead { get; set; }
    }
}
