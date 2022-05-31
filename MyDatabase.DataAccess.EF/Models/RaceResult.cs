using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class RaceResult
    {
        public int RaceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int BibNumber { get; set; }
        public TimeSpan IntervalTime { get; set; }
        public TimeSpan Time { get; set; }
    }
}
