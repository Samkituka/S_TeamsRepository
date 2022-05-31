using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class FinancialInformation
    {
        public int AccountId { get; set; }
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
