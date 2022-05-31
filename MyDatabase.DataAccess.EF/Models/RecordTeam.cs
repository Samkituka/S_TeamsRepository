using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class RecordTeam
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string _2017season { get; set; }
        public string _2018season { get; set; }
        public string _2019season { get; set; }
        public string _2020season { get; set; }
        public string _2021season { get; set; }
    }
}
