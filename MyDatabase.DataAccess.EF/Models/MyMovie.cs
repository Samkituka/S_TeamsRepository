using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class MyMovie
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public short Year { get; set; }
        public string Director { get; set; }
        public string LeadActor { get; set; }
        public byte MyRating { get; set; }
    }
}
