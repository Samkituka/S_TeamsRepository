using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class DemoTable
    {
        public int DemoId { get; set; }
        public string DemoTitle { get; set; }
        public string DemoName { get; set; }
    }
}
