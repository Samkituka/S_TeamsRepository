using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Movie
    {
        public int MoviesId { get; set; }
        public string MovieTitle { get; set; }
        public short Year { get; set; }
        public string Director { get; set; }
        public string LeadActor { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
        public byte MyRating { get; set; }
    }
}
