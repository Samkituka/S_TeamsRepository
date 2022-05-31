using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class MoviesWatched
    {
        public string MovieTitle { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string LeadActor { get; set; }
        public int PersonalRating { get; set; }
    }
}
