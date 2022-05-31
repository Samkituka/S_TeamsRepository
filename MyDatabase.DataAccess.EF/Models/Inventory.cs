using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public string Item { get; set; }
        public string Brand { get; set; }
        public string Location { get; set; }
        public decimal Cost { get; set; }
        public int CountOnHand { get; set; }
    }
}
